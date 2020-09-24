using MediatR;

namespace DDD.Core.Common.Messages
{
    /// <summary>
    /// A CQRS event implementation
    /// </summary>
    public class Event : Message, INotification
    {
        /// <summary>
        /// Event constructor
        /// </summary>
        public Event()
            : base() { }
    }
}