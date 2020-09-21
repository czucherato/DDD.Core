using Xunit;
using System;
using DDD.Core.Common.Messages;

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

    }

    public class Result { }

    public class ExtendedCommand : Command<Result>
    {
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}