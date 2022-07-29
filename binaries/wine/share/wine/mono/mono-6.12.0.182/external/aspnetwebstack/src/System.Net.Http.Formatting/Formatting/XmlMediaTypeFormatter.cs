﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http.Internal;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace System.Net.Http.Formatting
{
    /// <summary>
    /// <see cref="MediaTypeFormatter"/> class to handle Xml.
    /// </summary>
    public class XmlMediaTypeFormatter : MediaTypeFormatter
    {
        private static readonly MediaTypeHeaderValue[] _supportedMediaTypes = new MediaTypeHeaderValue[]
        {
            MediaTypeConstants.ApplicationXmlMediaType,
            MediaTypeConstants.TextXmlMediaType
        };

        private ConcurrentDictionary<Type, object> _serializerCache = new ConcurrentDictionary<Type, object>();
        private XmlDictionaryReaderQuotas _readerQuotas = FormattingUtilities.CreateDefaultReaderQuotas();

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlMediaTypeFormatter"/> class.
        /// </summary>
        public XmlMediaTypeFormatter()
        {
            // Set default supported media types
            foreach (MediaTypeHeaderValue value in _supportedMediaTypes)
            {
                SupportedMediaTypes.Add(value);
            }

            // Set default supported character encodings
            SupportedEncodings.Add(new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true));
            SupportedEncodings.Add(new UnicodeEncoding(bigEndian: false, byteOrderMark: true, throwOnInvalidBytes: true));
        }

        /// <summary>
        /// Gets the default media type for xml, namely "application/xml".
        /// </summary>
        /// <value>
        /// <remarks>
        /// The default media type does not have any <c>charset</c> parameter as 
        /// the <see cref="Encoding"/> can be configured on a per <see cref="XmlMediaTypeFormatter"/> 
        /// instance basis.
        /// </remarks>
        /// Because <see cref="MediaTypeHeaderValue"/> is mutable, the value
        /// returned will be a new instance every time.
        /// </value>
        public static MediaTypeHeaderValue DefaultMediaType
        {
            get { return MediaTypeConstants.ApplicationXmlMediaType; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to use <see cref="XmlSerializer"/> instead of <see cref="DataContractSerializer"/> by default.
        /// </summary>
        /// <value>
        ///     <c>true</c> if use <see cref="XmlSerializer"/> by default; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool UseXmlSerializer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to indent elements when writing data. 
        /// </summary>
        public bool Indent { get; set; }

        /// <summary>
        /// Gets or sets the maximum depth allowed by this formatter.
        /// </summary>
        public int MaxDepth
        {
            get
            {
                return _readerQuotas.MaxDepth;
            }
            set
            {
                if (value < FormattingUtilities.DefaultMinDepth)
                {
                    throw new ArgumentOutOfRangeException("value", value, RS.Format(Properties.Resources.ArgumentMustBeGreaterThanOrEqualTo, FormattingUtilities.DefaultMinDepth));
                }

                _readerQuotas.MaxDepth = value;
            }
        }

        /// <summary>
        /// Registers the <see cref="XmlObjectSerializer"/> to use to read or write
        /// the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of object that will be serialized or deserialized with <paramref name="serializer"/>.</param>
        /// <param name="serializer">The <see cref="XmlObjectSerializer"/> instance to use.</param>
        public void SetSerializer(Type type, XmlObjectSerializer serializer)
        {
            VerifyAndSetSerializer(type, serializer);
        }

        /// <summary>
        /// Registers the <see cref="XmlObjectSerializer"/> to use to read or write
        /// the specified <typeparamref name="T"/> type.
        /// </summary>
        /// <typeparam name="T">The type of object that will be serialized or deserialized with <paramref name="serializer"/>.</typeparam>
        /// <param name="serializer">The <see cref="XmlObjectSerializer"/> instance to use.</param>
        [SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "The T represents a Type parameter.")]
        public void SetSerializer<T>(XmlObjectSerializer serializer)
        {
            SetSerializer(typeof(T), serializer);
        }

        /// <summary>
        /// Registers the <see cref="XmlSerializer"/> to use to read or write
        /// the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of objects for which <paramref name="serializer"/> will be used.</param>
        /// <param name="serializer">The <see cref="XmlSerializer"/> instance to use.</param>
        public void SetSerializer(Type type, XmlSerializer serializer)
        {
            VerifyAndSetSerializer(type, serializer);
        }

        /// <summary>
        /// Registers the <see cref="XmlSerializer"/> to use to read or write
        /// the specified <typeparamref name="T"/> type.
        /// </summary>
        /// <typeparam name="T">The type of object that will be serialized or deserialized with <paramref name="serializer"/>.</typeparam>
        /// <param name="serializer">The <see cref="XmlSerializer"/> instance to use.</param>
        [SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "The T represents a Type parameter.")]
        public void SetSerializer<T>(XmlSerializer serializer)
        {
            SetSerializer(typeof(T), serializer);
        }

        /// <summary>
        /// Unregisters the serializer currently associated with the given <paramref name="type"/>.
        /// </summary>
        /// <remarks>
        /// Unless another serializer is registered for the <paramref name="type"/>, a default one will be created.
        /// </remarks>
        /// <param name="type">The type of object whose serializer should be removed.</param>
        /// <returns><c>true</c> if a serializer was registered for the <paramref name="type"/>; otherwise <c>false</c>.</returns>
        public bool RemoveSerializer(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            object value;
            return _serializerCache.TryRemove(type, out value);
        }

        internal bool ContainsSerializerForType(Type type)
        {
            return _serializerCache.ContainsKey(type);
        }

        /// <summary>
        /// Determines whether this <see cref="XmlMediaTypeFormatter"/> can read objects
        /// of the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of object that will be read.</param>
        /// <returns><c>true</c> if objects of this <paramref name="type"/> can be read, otherwise <c>false</c>.</returns>
        public override bool CanReadType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            // If there is a registered non-null serializer, we can support this type.
            // Otherwise attempt to create the default serializer.
            object serializer = _serializerCache.GetOrAdd(
                type,
                (t) => CreateDefaultSerializer(t, throwOnError: false));

            // Null means we tested it before and know it is not supported
            return serializer != null;
        }

        /// <summary>
        /// Determines whether this <see cref="XmlMediaTypeFormatter"/> can write objects
        /// of the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of object that will be written.</param>
        /// <returns><c>true</c> if objects of this <paramref name="type"/> can be written, otherwise <c>false</c>.</returns>
        public override bool CanWriteType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (UseXmlSerializer)
            {
                MediaTypeFormatter.TryGetDelegatingTypeForIEnumerableGenericOrSame(ref type);
            }
            else
            {
                MediaTypeFormatter.TryGetDelegatingTypeForIQueryableGenericOrSame(ref type);
            }

            // If there is a registered non-null serializer, we can support this type.
            object serializer = _serializerCache.GetOrAdd(
                type,
                (t) => CreateDefaultSerializer(t, throwOnError: false));

            // Null means we tested it before and know it is not supported
            return serializer != null;
        }

        /// <summary>
        /// Called during deserialization to read an object of the specified <paramref name="type"/>
        /// from the specified <paramref name="stream"/>.
        /// </summary>
        /// <param name="type">The type of object to read.</param>
        /// <param name="stream">The <see cref="Stream"/> from which to read.</param>
        /// <param name="contentHeaders">The <see cref="HttpContentHeaders"/> for the content being read.</param>
        /// <param name="formatterLogger">The <see cref="IFormatterLogger"/> to log events to.</param>
        /// <returns>A <see cref="Task"/> whose result will be the object instance that has been read.</returns>
        public override Task<object> ReadFromStreamAsync(Type type, Stream stream, HttpContentHeaders contentHeaders, IFormatterLogger formatterLogger)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            return TaskHelpers.RunSynchronously<object>(() =>
            {
                // If content length is 0 then return default value for this type
                if (contentHeaders != null && contentHeaders.ContentLength == 0)
                {
                    return GetDefaultValueForType(type);
                }

                // Get the character encoding for the content
                Encoding effectiveEncoding = SelectCharacterEncoding(contentHeaders);

                object serializer = GetSerializerForType(type);

                try
                {
                    using (XmlReader reader = XmlDictionaryReader.CreateTextReader(new NonClosingDelegatingStream(stream), effectiveEncoding, _readerQuotas, null))
                    {
                        XmlSerializer xmlSerializer = serializer as XmlSerializer;
                        if (xmlSerializer != null)
                        {
                            return xmlSerializer.Deserialize(reader);
                        }
                        else
                        {
                            XmlObjectSerializer xmlObjectSerializer = (XmlObjectSerializer)serializer;
                            return xmlObjectSerializer.ReadObject(reader);
                        }
                    }
                }
                catch (Exception e)
                {
                    if (formatterLogger == null)
                    {
                        throw;
                    }
                    formatterLogger.LogError(String.Empty, e.Message);
                    return GetDefaultValueForType(type);
                }
            });
        }

        /// <summary>
        /// Called during serialization to write an object of the specified <paramref name="type"/>
        /// to the specified <paramref name="stream"/>.
        /// </summary>
        /// <param name="type">The type of object to write.</param>
        /// <param name="value">The object to write.</param>
        /// <param name="stream">The <see cref="Stream"/> to which to write.</param>
        /// <param name="contentHeaders">The <see cref="HttpContentHeaders"/> for the content being written.</param>
        /// <param name="transportContext">The <see cref="TransportContext"/>.</param>
        /// <returns>A <see cref="Task"/> that will write the value to the stream.</returns>
        public override Task WriteToStreamAsync(Type type, object value, Stream stream, HttpContentHeaders contentHeaders, TransportContext transportContext)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            return TaskHelpers.RunSynchronously(() =>
            {
                bool isRemapped = false;
                if (UseXmlSerializer)
                {
                    isRemapped = MediaTypeFormatter.TryGetDelegatingTypeForIEnumerableGenericOrSame(ref type);
                }
                else
                {
                    isRemapped = MediaTypeFormatter.TryGetDelegatingTypeForIQueryableGenericOrSame(ref type);
                }

                if (isRemapped && value != null)
                {
                    value = MediaTypeFormatter.GetTypeRemappingConstructor(type).Invoke(new object[] { value });
                }

                Encoding effectiveEncoding = SelectCharacterEncoding(contentHeaders);
                XmlWriterSettings writerSettings = new XmlWriterSettings
                {
                    OmitXmlDeclaration = true,
                    Indent = Indent,
                    Encoding = effectiveEncoding,
                    CloseOutput = false
                };

                object serializer = GetSerializerForType(type);

                using (XmlWriter writer = XmlWriter.Create(stream, writerSettings))
                {
                    XmlSerializer xmlSerializer = serializer as XmlSerializer;
                    if (xmlSerializer != null)
                    {
                        xmlSerializer.Serialize(writer, value);
                    }
                    else
                    {
                        XmlObjectSerializer xmlObjectSerializer = (XmlObjectSerializer)serializer;
                        xmlObjectSerializer.WriteObject(writer, value);
                    }
                }
            });
        }

        private object CreateDefaultSerializer(Type type, bool throwOnError)
        {
            Contract.Assert(type != null, "type cannot be null.");
            Exception exception = null;
            object serializer = null;

            try
            {
                if (UseXmlSerializer)
                {
                    serializer = new XmlSerializer(type);
                }
                else
                {
                    serializer = new DataContractSerializer(type);
                }
            }
            catch (InvalidOperationException invalidOperationException)
            {
                exception = invalidOperationException;
            }
            catch (NotSupportedException notSupportedException)
            {
                exception = notSupportedException;
            }

            // The serializer throws one of the exceptions above if it cannot
            // support this type.
            if (exception != null)
            {
                if (throwOnError)
                {
                    throw new InvalidOperationException(
                        RS.Format(Properties.Resources.SerializerCannotSerializeType,
                                  UseXmlSerializer ? typeof(XmlSerializer).Name : typeof(DataContractSerializer).Name,
                                  type.Name),
                        exception);
                }
            }

            return serializer;
        }

        private void VerifyAndSetSerializer(Type type, object serializer)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (serializer == null)
            {
                throw new ArgumentNullException("serializer");
            }

            SetSerializerInternal(type, serializer);
        }

        private void SetSerializerInternal(Type type, object serializer)
        {
            Contract.Assert(type != null, "type cannot be null.");
            Contract.Assert(serializer != null, "serializer cannot be null.");

            _serializerCache.AddOrUpdate(type, serializer, (key, value) => serializer);
        }

        private object GetSerializerForType(Type type)
        {
            Contract.Assert(type != null, "Type cannot be null");
            object serializer = _serializerCache.GetOrAdd(type, (t) => CreateDefaultSerializer(t, throwOnError: true));

            if (serializer == null)
            {
                // A null serializer indicates the type has already been tested
                // and found unsupportable.
                throw new InvalidOperationException(
                    RS.Format(Properties.Resources.SerializerCannotSerializeType,
                              UseXmlSerializer ? typeof(XmlSerializer).Name : typeof(DataContractSerializer).Name,
                              type.Name));
            }

            Contract.Assert(serializer is XmlSerializer || serializer is XmlObjectSerializer, "Only XmlSerializer or XmlObjectSerializer are supported.");
            return serializer;
        }
    }
}
