﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Threading;

namespace System.Web.Mvc.Async.Test
{
    public class MockAsyncResult : IAsyncResult
    {
        private volatile object _asyncState;
        private volatile ManualResetEvent _asyncWaitHandle = new ManualResetEvent(false);
        private volatile bool _completedSynchronously;
        private volatile bool _isCompleted;

        public object AsyncState
        {
            get { return _asyncState; }
            set { _asyncState = value; }
        }

        public ManualResetEvent AsyncWaitHandle
        {
            get { return _asyncWaitHandle; }
            set { _asyncWaitHandle = value; }
        }

        public bool CompletedSynchronously
        {
            get { return _completedSynchronously; }
            set { _completedSynchronously = value; }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

        #region IAsyncResult Members

        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get { return _asyncWaitHandle; }
        }

        #endregion
    }
}
