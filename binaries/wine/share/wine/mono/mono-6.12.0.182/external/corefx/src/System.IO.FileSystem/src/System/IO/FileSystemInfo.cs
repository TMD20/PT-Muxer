// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.Serialization;

namespace System.IO
{
    [Serializable]
    public abstract partial class FileSystemInfo : MarshalByRefObject, ISerializable
    {
        // FullPath and OriginalPath are documented fields
        protected string FullPath;          // fully qualified path of the file or directory
        protected string OriginalPath;      // path passed in by the user

        internal string _name;

        protected FileSystemInfo(SerializationInfo info, StreamingContext context)
        {
#if MONO // copy behavior from reference source
            if (info == null)
                throw new ArgumentNullException("info");

            // Must use V1 field names here, since V1 didn't implement
            // ISerializable.
            FullPath = Path.GetFullPathInternal(info.GetString("FullPath"));
            OriginalPath = info.GetString("OriginalPath");
            _name = info.GetString("Name");
#endif
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
#if MONO // copy behavior from reference source
            info.AddValue("OriginalPath", OriginalPath, typeof(String));
            info.AddValue("FullPath", FullPath, typeof(String));
            info.AddValue("Name", Name, typeof(String));
#endif
        }

        // Full path of the directory/file
        public virtual string FullName => FullPath;

        public string Extension
        {
            get
            {
                int length = FullPath.Length;
                for (int i = length; --i >= 0;)
                {
                    char ch = FullPath[i];
                    if (ch == '.')
                        return FullPath.Substring(i, length - i);
                    if (PathInternal.IsDirectorySeparator(ch) || ch == Path.VolumeSeparatorChar)
                        break;
                }
                return string.Empty;
            }
        }

        public virtual string Name => _name;

        // Whether a file/directory exists
        public virtual bool Exists
        {
            get
            {
                try
                {
                    return ExistsCore;
                }
                catch
                {
                    return false;
                }
            }
        }

        // Delete a file/directory
        public abstract void Delete();

        public DateTime CreationTime
        {
            get => CreationTimeUtc.ToLocalTime();
            set => CreationTimeUtc = value.ToUniversalTime();
        }

        public DateTime CreationTimeUtc
        {
            get => CreationTimeCore.UtcDateTime;
            set => CreationTimeCore = File.GetUtcDateTimeOffset(value);
        }


        public DateTime LastAccessTime
        {
            get => LastAccessTimeUtc.ToLocalTime();
            set => LastAccessTimeUtc = value.ToUniversalTime();
        }

        public DateTime LastAccessTimeUtc
        {
            get => LastAccessTimeCore.UtcDateTime;
            set => LastAccessTimeCore = File.GetUtcDateTimeOffset(value);
        }

        public DateTime LastWriteTime
        {
            get => LastWriteTimeUtc.ToLocalTime();
            set => LastWriteTimeUtc = value.ToUniversalTime();
        }

        public DateTime LastWriteTimeUtc
        {
            get => LastWriteTimeCore.UtcDateTime;
            set => LastWriteTimeCore = File.GetUtcDateTimeOffset(value);
        }

        /// <summary>
        /// Returns the original path. Use FullName or Name properties for the full path or file/directory name.
        /// </summary>
        public override string ToString() => OriginalPath ?? string.Empty;
    }
}
