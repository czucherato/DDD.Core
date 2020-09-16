using Xunit;
using MediatR;
using DDD.Core.Common.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Core.Common.Tests.Configuration
{
    public class MediatorConfigTests
    {
        [Fact]
        public void Adding_MediatR_To_ServiceCollection()
        {
            //Arrange
            IServiceCollection services = new ServiceCollection();

            //Act
            services.AddMediator<Startup>();

            //Assert
            Assert.Contains(services, x => x.ServiceType == typeof(IMediator));
        }
    }

    public class Startup { }
}