﻿using MassTransit;

using Stove.MQ;

namespace Stove.RabbitMQ.RabbitMQ
{
    public class RabbitMQMessageBus : IMessageBus
    {
        private readonly IBus _bus;

        public RabbitMQMessageBus(IBus bus)
        {
            _bus = bus;
        }

        public void Publish<TMessage>(TMessage message) where TMessage : class
        {
            _bus.Publish(message);
        }
    }
}
