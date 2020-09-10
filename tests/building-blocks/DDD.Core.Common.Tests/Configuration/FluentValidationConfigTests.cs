using Xunit;
using FluentValidation.Results;
using DDD.Core.Common.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core.Common.Tests.Configuration
{
    public class FluentValidationConfigTests
    {
        [Fact]
        public void Adding_ValidationResult_To_ServiceCollection()
        {
            //Arrange
            IServiceCollection services = new ServiceCollection();

            //Act
            services.AddFluentValidation();

            //Assert
            Assert.Contains(services, x => x.ServiceType == typeof(ValidationResult));
        }
    }
}