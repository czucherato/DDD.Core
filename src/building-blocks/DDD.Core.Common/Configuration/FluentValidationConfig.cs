using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core.Common.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddScoped<ValidationResult>();
        }
    }
}