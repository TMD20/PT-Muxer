﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace System.Web.Mvc
{
    [Serializable]
    public class ModelError
    {
        public ModelError(Exception exception)
            : this(exception, null /* errorMessage */)
        {
        }

        public ModelError(Exception exception, string errorMessage)
            : this(errorMessage)
        {
            if (exception == null)
            {
                throw new ArgumentNullException("exception");
            }

            Exception = exception;
        }

        public ModelError(string errorMessage)
        {
            ErrorMessage = errorMessage ?? String.Empty;
        }

        public Exception Exception { get; private set; }

        public string ErrorMessage { get; private set; }
    }
}
