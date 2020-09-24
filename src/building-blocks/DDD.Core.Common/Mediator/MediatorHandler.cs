using MediatR;
using System.Threading.Tasks;
using DDD.Core.Common.Messages;

namespace DDD.Core.Common.Mediator
{
    /// <summary>
    /// A Mediator Handler implementation
    /// </summary>
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Mediator Handler constructor
        /// </summary>
        /// <param name="mediator">MediatR interface</param>
        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Implementation of CQRS event publish
        /// </summary>
        /// <typeparam name="T">Event reference implementation</typeparam>
        /// <param name="event">Event implementation</param>
        /// <returns>Task for async flow</returns>
        public async Task Publish<T>(T @event) where T : Event
        {
            await _mediator.Publish(@event);
        }

        /// <summary>
        ///  Implementation of CQRS query
        /// </summary>
        /// <typeparam name="T">Query reference implementation</typeparam>
        /// <typeparam name="U">Query result</typeparam>
        /// <param name="params">Query implementation</param>
        /// <returns>Task for async flow</returns>
        public async Task<U> Query<T, U>(T @params) where T : Query<U>
        {
            return await _mediator.Send(@params);
        }

        /// <summary>
        /// Implementation of CQRS command send
        /// </summary>
        /// <typeparam name="T">Command reference implementation</typeparam>
        /// <typeparam name="U">Command result</typeparam>
        /// <param name="command">Command implementation</param>
        /// <returns>Task for async flow</returns>
        public async Task<U> Send<T, U>(T command) where T : Command<U>
        {
            return await _mediator.Send(command);
        }
    }
}