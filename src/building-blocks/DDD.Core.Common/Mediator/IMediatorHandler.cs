using System.Threading.Tasks;
using DDD.Core.Common.Messages;

namespace DDD.Core.Common.Mediator
{
    /// <summary>
    /// A generic implementation of MediatR
    /// </summary>
    public interface IMediatorHandler
    {
        /// <summary>
        /// A generic implementation of CQRS event publish
        /// </summary>
        /// <typeparam name="T">Event reference implementation</typeparam>
        /// <param name="event">Event implementation</param>
        /// <returns>Task for async flow</returns>
        Task Publish<T>(T @event) where T : Event;

        /// <summary>
        ///  A generic implementation of CQRS query
        /// </summary>
        /// <typeparam name="T">Query reference implementation</typeparam>
        /// <typeparam name="U">Query result</typeparam>
        /// <param name="params">Query implementation</param>
        /// <returns>Task for async flow</returns>
        Task<U> Query<T, U>(T @params) where T : Query<U>;

        /// <summary>
        /// A generic implementation of CQRS command send
        /// </summary>
        /// <typeparam name="T">Command reference implementation</typeparam>
        /// <typeparam name="U">Command result</typeparam>
        /// <param name="command">Command implementation</param>
        /// <returns>Task for async flow</returns>
        Task<U> Send<T, U>(T command) where T : Command<U>;
    }
}