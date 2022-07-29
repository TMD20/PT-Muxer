﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

#if !NO_SYNCCTX
using System.Reactive.Disposables;
using System.Threading;

namespace System.Reactive.Concurrency
{
    /// <summary>
    /// Represents an object that schedules units of work on a provided <seealso cref="T:System.Threading.SynchronizationContext"/>.
    /// </summary>
    public class SynchronizationContextScheduler : LocalScheduler
    {
        private readonly SynchronizationContext _context;
        private readonly bool _alwaysPost;

        /// <summary>
        /// Creates an object that schedules units of work on the provided <see cref="T:System.Threading.SynchronizationContext"/>.
        /// </summary>
        /// <param name="context">Synchronization context to schedule units of work on.</param>
        /// <exception cref="ArgumentNullException"><paramref name="context"/> is null.</exception>
        public SynchronizationContextScheduler(SynchronizationContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");
            
            _context = context;
            _alwaysPost = true;
        }

        /// <summary>
        /// Creates an object that schedules units of work on the provided <see cref="T:System.Threading.SynchronizationContext"/>.
        /// </summary>
        /// <param name="context">Synchronization context to schedule units of work on.</param>
        /// <param name="alwaysPost">Configures whether scheduling always posts to the synchronization context, regardless whether the caller is on the same synchronization context.</param>
        /// <exception cref="ArgumentNullException"><paramref name="context"/> is null.</exception>
        public SynchronizationContextScheduler(SynchronizationContext context, bool alwaysPost)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
            _alwaysPost = alwaysPost;
        }

        /// <summary>
        /// Schedules an action to be executed.
        /// </summary>
        /// <typeparam name="TState">The type of the state passed to the scheduled action.</typeparam>
        /// <param name="state">State passed to the action to be executed.</param>
        /// <param name="action">Action to be executed.</param>
        /// <returns>The disposable object used to cancel the scheduled action (best effort).</returns>
        /// <exception cref="ArgumentNullException"><paramref name="action"/> is null.</exception>
        public override IDisposable Schedule<TState>(TState state, Func<IScheduler, TState, IDisposable> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            var d = new SingleAssignmentDisposable();

            if (!_alwaysPost && _context == SynchronizationContext.Current)
            {
                d.Disposable = action(this, state);
            }
            else
            {
                _context.PostWithStartComplete(() =>
                {
                    if (!d.IsDisposed)
                        d.Disposable = action(this, state);
                });
            }

            return d;
        }

        /// <summary>
        /// Schedules an action to be executed after dueTime.
        /// </summary>
        /// <typeparam name="TState">The type of the state passed to the scheduled action.</typeparam>
        /// <param name="state">State passed to the action to be executed.</param>
        /// <param name="action">Action to be executed.</param>
        /// <param name="dueTime">Relative time after which to execute the action.</param>
        /// <returns>The disposable object used to cancel the scheduled action (best effort).</returns>
        /// <exception cref="ArgumentNullException"><paramref name="action"/> is null.</exception>
        public override IDisposable Schedule<TState>(TState state, TimeSpan dueTime, Func<IScheduler, TState, IDisposable> action)
        {
            if (action == null)
                throw new ArgumentNullException("action");

            var dt = Scheduler.Normalize(dueTime);
            if (dt.Ticks == 0)
                return Schedule(state, action);

            return DefaultScheduler.Instance.Schedule(state, dt, (_, state1) => Schedule(state1, action));
        }
    }
}
#endif