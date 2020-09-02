using MediatR;

namespace DDD.Core.Common.Messages
{
    public class Event : Message, INotification
    {
        public Event()
            : base() { }
    }
}