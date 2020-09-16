using Moq;
using Xunit;
using System.Linq;
using DDD.Core.Common.Handlers;
using FluentValidation.Results;

namespace DDD.Core.Common.Tests.Handlers
{
    public class HandlerTests
    {
        [Fact]
        public void Adding_Handler_Errors()
        {
            //Arrange
            var validationResult = new Mock<ValidationResult>().Object;
            var handler = new ExtendedHandler(validationResult);

            //Act
            handler.ExternalAddError("Some error");

            //Assert
            Assert.True(handler.ContainsError());
        }

        [Fact]
        public void Clearing_Handler_Errors()
        {
            //Arrange
            var validationResult = new Mock<ValidationResult>().Object;
            var handler = new ExtendedHandler(validationResult);
            handler.ExternalAddError("Some error");

            //Act
            handler.ExternalClearErrors();

            //Assert
            Assert.False(handler.ContainsError());
        }
    }

    public class ExtendedHandler : Handler
    {
        public ExtendedHandler(ValidationResult validationResult)
            : base (validationResult) { }

        public void ExternalAddError(string errorMessage) => AddError(errorMessage);

        public void ExternalClearErrors() => ClearErrors();

        public bool ContainsError() => _validationResult.Errors.Any();
    }
}