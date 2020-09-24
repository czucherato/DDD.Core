using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core.Common.Configuration
{
    /// <summary>
    /// Class with extension method for inject ValidationResult in ServiceCollection
    /// </summary>
    public static class FluentValidationConfig
    {
        /// <summary>
        /// This method injects ValidationResult in ServiceCollection
        /// </summary>
        /// <param name="services">ServiceCollection from DependencyInjection</param>
        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddScoped<ValidationResult>();
        }
    }
}