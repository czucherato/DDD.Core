using MediatR;

namespace DDD.Core.Common.Messages
{
    /// <summary>
    /// A generic CQRS query implementation
    /// </summary>
    /// <typeparam name="T">Query result</typeparam>
    public abstract class Query<T> : Message, IRequest<T>
    {
        /// <summary>
        /// Query constructor
        /// </summary>
        protected Query()
            : base() { }
    }
}