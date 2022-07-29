﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Collections;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.Internal;
using System.Web.Http.Metadata;
using System.Web.Http.ModelBinding.Binders;
using System.Web.Http.Properties;

namespace System.Web.Http.ModelBinding
{
    internal static class ModelBindingHelper
    {
        internal static TModel CastOrDefault<TModel>(object model)
        {
            return (model is TModel) ? (TModel)model : default(TModel);
        }

        internal static string CreateIndexModelName(string parentName, int index)
        {
            return CreateIndexModelName(parentName, index.ToString(CultureInfo.InvariantCulture));
        }

        internal static string CreateIndexModelName(string parentName, string index)
        {
            return (parentName.Length == 0) ? "[" + index + "]" : parentName + "[" + index + "]";
        }

        internal static string CreatePropertyModelName(string prefix, string propertyName)
        {
            if (String.IsNullOrEmpty(prefix))
            {
                return propertyName ?? String.Empty;
            }
            else if (String.IsNullOrEmpty(propertyName))
            {
                return prefix ?? String.Empty;
            }
            else
            {
                return prefix + "." + propertyName;
            }
        }

        // Concatenate model keys, if suffix is an indexer, concat strings; otherwise insert a period between the two
        internal static string ConcatenateKeys(string prefix, string suffix)
        {
            Contract.Assert(!String.IsNullOrEmpty(prefix));
            if (String.IsNullOrEmpty(suffix))
            {
                return prefix;
            }
            return suffix.StartsWith("[", StringComparison.Ordinal) ? prefix + suffix : prefix + "." + suffix;
        }

        internal static IModelBinder GetPossibleBinderInstance(Type closedModelType, Type openModelType, Type openBinderType)
        {
            Type[] typeArguments = TypeHelper.GetTypeArgumentsIfMatch(closedModelType, openModelType);
            return (typeArguments != null) ? (IModelBinder)Activator.CreateInstance(openBinderType.MakeGenericType(typeArguments)) : null;
        }

        internal static object[] RawValueToObjectArray(object rawValue)
        {
            // precondition: rawValue is not null

            // Need to special-case String so it's not caught by the IEnumerable check which follows
            if (rawValue is string)
            {
                return new[] { rawValue };
            }

            object[] rawValueAsObjectArray = rawValue as object[];
            if (rawValueAsObjectArray != null)
            {
                return rawValueAsObjectArray;
            }

            IEnumerable rawValueAsEnumerable = rawValue as IEnumerable;
            if (rawValueAsEnumerable != null)
            {
                return rawValueAsEnumerable.Cast<object>().ToArray();
            }

            // fallback
            return new[] { rawValue };
        }

        internal static void ReplaceEmptyStringWithNull(ModelMetadata modelMetadata, ref object model)
        {
            if (model is string &&
                modelMetadata.ConvertEmptyStringToNull &&
                String.IsNullOrWhiteSpace(model as string))
            {
                model = null;
            }
        }

        // Returns true if the ModelBinderAttribute specifies a binder provider of <TProvider> or binder instance of <TBinder>
        internal static bool IsModelBinderFor<TProvider, TBinder>(ModelBinderAttribute modelBinderAttribute)
        {
            Contract.Assert(modelBinderAttribute != null, "modelBinderAttribute cannot be null");
            Type binderType = modelBinderAttribute.BinderType;
            return binderType != null &&
                   (typeof(TProvider).IsAssignableFrom(binderType) ||
                    typeof(TBinder).IsAssignableFrom(binderType));
        }

        internal static bool TryGetProviderFromAttribute(Type modelType, ModelBinderAttribute modelBinderAttribute, out ModelBinderProvider provider)
        {
            Contract.Assert(modelType != null, "modelType cannot be null.");
            Contract.Assert(modelBinderAttribute != null, "modelBinderAttribute cannot be null");

            if (typeof(ModelBinderProvider).IsAssignableFrom(modelBinderAttribute.BinderType))
            {
                // REVIEW: DI?
                provider = (ModelBinderProvider)Activator.CreateInstance(modelBinderAttribute.BinderType);
            }
            else if (typeof(IModelBinder).IsAssignableFrom(modelBinderAttribute.BinderType))
            {
                Type closedBinderType =
                    modelBinderAttribute.BinderType.IsGenericTypeDefinition
                        ? modelBinderAttribute.BinderType.MakeGenericType(modelType.GetGenericArguments())
                        : modelBinderAttribute.BinderType;

                IModelBinder binderInstance = (IModelBinder)Activator.CreateInstance(closedBinderType);
                provider = new SimpleModelBinderProvider(modelType, binderInstance) { SuppressPrefixCheck = modelBinderAttribute.SuppressPrefixCheck };
            }
            else
            {
                throw Error.InvalidOperation(SRResources.ModelBinderProviderCollection_InvalidBinderType, modelBinderAttribute.BinderType, typeof(ModelBinderProvider), typeof(IModelBinder));
            }

            return true;
        }

        internal static bool TryGetProviderFromAttributes(Type modelType, out ModelBinderProvider provider)
        {
            ModelBinderAttribute attr = TypeDescriptorHelper.Get(modelType).GetAttributes().OfType<ModelBinderAttribute>().FirstOrDefault();
            if (attr == null)
            {
                provider = null;
                return false;
            }

            return TryGetProviderFromAttribute(modelType, attr, out provider);
        }

        internal static bool TryGetProviderFromAttributes(HttpParameterDescriptor parameterDescriptor, out ModelBinderProvider provider)
        {
            Contract.Assert(parameterDescriptor != null, "parameterDescriptor cannot be null.");

            Type modelType = parameterDescriptor.ParameterType;

            ModelBinderAttribute attr = parameterDescriptor.GetCustomAttributes<ModelBinderAttribute>().FirstOrDefault();
            if (attr == null)
            {
                attr = TypeDescriptorHelper.Get(modelType).GetAttributes().OfType<ModelBinderAttribute>().FirstOrDefault();
            }

            if (attr == null)
            {
                provider = null;
                return false;
            }

            return TryGetProviderFromAttribute(modelType, attr, out provider);
        }

        internal static void ValidateBindingContext(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw Error.ArgumentNull("bindingContext");
            }

            if (bindingContext.ModelMetadata == null)
            {
                throw Error.Argument("bindingContext", SRResources.ModelBinderUtil_ModelMetadataCannotBeNull);
            }
        }

        internal static void ValidateBindingContext(ModelBindingContext bindingContext, Type requiredType, bool allowNullModel)
        {
            ValidateBindingContext(bindingContext);

            if (bindingContext.ModelType != requiredType)
            {
                throw Error.Argument("bindingContext", SRResources.ModelBinderUtil_ModelTypeIsWrong, bindingContext.ModelType, requiredType);
            }

            if (!allowNullModel && bindingContext.Model == null)
            {
                throw Error.Argument("bindingContext", SRResources.ModelBinderUtil_ModelCannotBeNull, requiredType);
            }

            if (bindingContext.Model != null && !requiredType.IsInstanceOfType(bindingContext.Model))
            {
                throw Error.Argument("bindingContext", SRResources.ModelBinderUtil_ModelInstanceIsWrong, bindingContext.Model.GetType(), requiredType);
            }
        }
    }
}
