using MediatR;
using System.Threading.Tasks;
using DDD.Core.Common.Messages;

namespace DDD.Core.Common.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Publish<T>(T @event) where T : Event
        {
            await _mediator.Publish(@event);
        }

        public async Task<U> Query<T, U>(T @params) where T : Query<U>
        {
            return await _mediator.Send(@params);
        }

        public async Task<U> Send<T, U>(T command) where T : Command<U>
        {
            return await _mediator.Send(command);
        }
    }
}