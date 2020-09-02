using MediatR;

namespace DDD.Core.Common.Messages
{
    public abstract class Query<T> : Message, IRequest<T>
    {
        protected Query()
            : base() { }
    }
}