using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core.Common.Configuration
{
    /// <summary>
    /// Class with extension method for inject MediatR in ServiceCollection
    /// </summary>
    public static class MediatorConfig
    {
        /// <summary>
        /// This method injects MediatR in ServiceCollection
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="services">ServiceCollection from DependencyInjection</param>
        public static void AddMediator<T>(this IServiceCollection services)
        {
            services.AddMediatR(typeof(T));
        }
    }
}