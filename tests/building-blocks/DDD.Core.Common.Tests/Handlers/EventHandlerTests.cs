using Xunit;
using DDD.Core.Common.Handlers;
using FluentValidation.Results;

namespace DDD.Core.Common.Tests.Handlers
{
    public class EventHandlerTests
    {
        [Fact]
        public void EventHandler_Instantiation()
        {
            //Arrange & Act & Assert
            Assert.NotNull(new ExtendedEventHandler(new ValidationResult()));

        }
    }

    public class ExtendedEventHandler : EventHandler
    {
        public ExtendedEventHandler(ValidationResult validationResult)
            : base(validationResult) { }
    }
}