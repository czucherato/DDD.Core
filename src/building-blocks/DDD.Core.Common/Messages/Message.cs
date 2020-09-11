using System;

namespace DDD.Core.Common.Messages
{
    public abstract class Message
    {
        protected Message()
        {
            TimeStamp = DateTime.Now;
            MessageType = GetType().Name;
        }

        public string MessageType { get; private set; }

        public Guid AggregateId { get; protected set; }

        public DateTime TimeStamp { get; private set; }
    }
}