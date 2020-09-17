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
            var commandMock = new Mock<CommandA>();
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
            var commandMock = new Mock<CommandA>();
            commandMock.Setup(x => x.IsValid()).Returns(false);
            var commandHandler = new AggregateCommandHandler(new Mock<ValidationResult>().Object);

            //Act
            var result = commandHandler.ExternalValidate(commandMock.Object);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CommandHandler_Validate_With_Validation_Errors()
        {
            //Arrange
            var command = new CommandB();
            command.AddError("Somer property", "Some error message");
            var commandHandler = new AggregateCommandHandler(new Mock<ValidationResult>().Object);

            //Act 
            var result = commandHandler.ExternalValidate(command);

            //Assert
            Assert.False(result);
        }
    }

    public class CommandA : Command<ValidationResult>
    {
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }

    public class CommandB : Command<ValidationResult>
    {
        public override bool IsValid() => false;

        public void AddError(string property, string errorMessage) => ValidationResult.Errors.Add(new ValidationFailure(property, errorMessage));
    }

    public class AggregateCommandHandler : CommandHandler
    {
        public AggregateCommandHandler(ValidationResult validationResult)
            : base(validationResult) { }

        public bool ExternalValidate(CommandA command) => Validate<CommandA, ValidationResult>(command);

        public bool ExternalValidate(CommandB command) => Validate<CommandB, ValidationResult>(command);
    }
}