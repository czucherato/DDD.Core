using System.Threading.Tasks;
using DDD.Core.Common.Messages;

namespace DDD.Core.Common.Mediator
{
    public interface IMediatorHandler
    {
        Task Publish<T>(T @event) where T : Event;

        Task<U> Query<T, U>(T @params) where T : Query<U>;

        Task<U> Send<T, U>(T command) where T : Command<U>;
    }
}