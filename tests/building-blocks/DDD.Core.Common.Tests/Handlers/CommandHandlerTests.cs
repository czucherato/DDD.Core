using Moq;
using Xunit;
using System;
using DDD.Core.Common.Handlers;
using DDD.Core.Common.Messages;
using FluentValidation.Results;

namespace DDD.Core.Common.Tests.Handlers
{
    public class CommandHandlerTests
    {
        [Fact]
        public void CommandHandler_Validate_Returns_True()
        {
            //Arrange
            var commandMock = new Mock<ActionCommand>();
            commandMock.Setup(x => x.IsValid()).Returns(true);
            var commandHandler = new AggregateCommandHandler(new Mock<ValidationResult>().Object);

            //Act
            var result = commandHandler.ExternalValidate(commandMock.Object);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CommandHandler_Validate_Returns_False()
        {
            //Arrange
            var commandMock = new Mock<ActionCommand>();
            commandMock.Setup(x => x.IsValid()).Returns(false);
            var commandHandler = new AggregateCommandHandler(new Mock<ValidationResult>().Object);

            //Act
            var result = commandHandler.ExternalValidate(commandMock.Object);

            //Assert
            Assert.False(result);
        }
    }

    public class ActionCommand : Command<ValidationResult>
    {
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }

    public class AggregateCommandHandler : CommandHandler
    {
        public AggregateCommandHandler(ValidationResult validationResult)
            : base(validationResult) { }

        public bool ExternalValidate(ActionCommand command) => Validate<ActionCommand, ValidationResult>(command);
    }
}