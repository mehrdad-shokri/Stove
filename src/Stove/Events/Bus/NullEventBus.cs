﻿using System;
using System.Threading;
using System.Threading.Tasks;

using Stove.Events.Bus.Factories;
using Stove.Events.Bus.Handlers;
using Stove.Utils.Etc;

namespace Stove.Events.Bus
{
    /// <summary>
    ///     An event bus that implements Null object pattern.
    /// </summary>
    public sealed class NullEventBus : IEventBus
    {
        private NullEventBus()
        {
        }

        /// <summary>
        ///     Gets single instance of <see cref="NullEventBus" /> class.
        /// </summary>
        public static NullEventBus Instance { get; } = new NullEventBus();

        public IDisposable Register<TEvent>(Action<TEvent, Headers> action) where TEvent : IEvent
        {
            return null;
        }

        public void RegisterPublishingBehaviour(EventPublishingBehaviour behaviour)
        {
        }

        public IDisposable Register<TEvent>(IEventHandler<TEvent> handler) where TEvent : IEvent
        {
            return NullDisposable.Instance;
        }

        public IDisposable Register<TEvent, THandler>()
            where TEvent : IEvent
            where THandler : IEventHandler<TEvent>, new()
        {
            return NullDisposable.Instance;
        }

        public IDisposable Register(Type eventType, IEventHandler handler)
        {
            return NullDisposable.Instance;
        }

        public IDisposable Register<TEvent>(IEventHandlerFactory handlerFactory) where TEvent : IEvent
        {
            return NullDisposable.Instance;
        }

        public IDisposable Register(Type eventType, IEventHandlerFactory handlerFactory)
        {
            return NullDisposable.Instance;
        }

        public void Unregister<TEvent>(Action<TEvent, Headers> action) where TEvent : IEvent
        {
        }

        public void Unregister<TEvent>(IEventHandler<TEvent> handler) where TEvent : IEvent
        {
        }

        public void Unregister(Type eventType, IEventHandler handler)
        {
        }

        public void Unregister<TEvent>(IEventHandlerFactory factory) where TEvent : IEvent
        {
        }

        public void Unregister(Type eventType, IEventHandlerFactory factory)
        {
        }

        public void UnregisterAll<TEvent>() where TEvent : IEvent
        {
        }

        public void UnregisterAll(Type @event)
        {
        }

        public void Publish<TEvent>(TEvent @event, Headers headers) where TEvent : IEvent
        {
        }

        public void Publish(Type eventType, IEvent @event, Headers headers)
        {
        }

        public Task PublishAsync<TEvent>(TEvent @event, Headers headers, CancellationToken cancellationToken = default) where TEvent : IEvent
        {
            return null;
        }

        public Task PublishAsync(Type eventType, IEvent @event, Headers headers, CancellationToken cancellationToken = default)
        {
            return null;
        }
    }
}
