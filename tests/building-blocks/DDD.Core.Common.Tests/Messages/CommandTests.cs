using Xunit;
using System;
using DDD.Core.Common.Messages;
using FluentValidation.Results;

namespace DDD.Core.Common.Tests.Messages
{
    public class CommandTests
    {
        [Fact]
        public void Inherited_ValidationResult_Is_Not_Null()
        {
            //Arrange & Act & Assert
            Assert.NotNull(new ExtendedCommand().ValidationResult);
        }

        [Fact]
        public void Inherited_Class_Setting_ValidationResult()
        {
            //Arrange 
            var command = new ExtendedCommand();

            //Act 
            command.SetValidationResult();

            //Assert
            Assert.NotNull(command.ValidationResult);
        }

    }

    public class Result { }

    public class ExtendedCommand : Command<Result>
    {
        public void SetValidationResult()
        {
            ValidationResult = new ValidationResult();
        }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}