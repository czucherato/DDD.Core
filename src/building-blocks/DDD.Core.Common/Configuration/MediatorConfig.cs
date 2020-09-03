using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core.Common.Configuration
{
    public static class MediatorConfig
    {
        public static void AddMediator<T>(this IServiceCollection services)
        {
            services.AddMediatR(typeof(T));
        }
    }
}