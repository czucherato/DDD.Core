using System;

namespace DDD.Core.Common.Messages
{
    /// <summary>
    /// A generic CQRS message implementation
    /// </summary>
    public abstract class Message
    {
        /// <summary>
        /// Message constructor
        /// </summary>
        protected Message()
        {
            TimeStamp = DateTime.Now;
            MessageType = GetType().Name;
        }

        /// <summary>
        /// Type of the message
        /// </summary>
        public string MessageType { get; private set; }

        /// <summary>
        /// Domain aggregate root reference
        /// </summary>
        public Guid AggregateId { get; protected set; }

        /// <summary>
        /// Date and time the message was created
        /// </summary>
        public DateTime TimeStamp { get; private set; }
    }
}