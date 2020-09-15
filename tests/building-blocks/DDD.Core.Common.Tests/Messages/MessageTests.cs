using Xunit;
using System;
using DDD.Core.Common.Messages;

namespace DDD.Core.Common.Tests.Messages
{
    public class MessageTests
    {
        [Fact]
        public void MessageType_Is_Properly_Filled()
        {
            //Arrange
            var message = new FakeMessage();

            //Act & Assert
            Assert.NotNull(message.MessageType);
        }

        [Fact]
        public void TimeStamp_Is_Properly_Filled()
        {
            //Arrange
            var message = new FakeMessage();

            //Act & Assert
            Assert.True(message.TimeStamp > DateTime.MinValue);
        }

        [Fact]
        public void AggregateId_Is_Properly_Filled()
        {
            //Arrange
            var message = new FakeMessage();

            //Act
            message.AggregateIdExternalSet();

            //Assert
            Assert.True(message.AggregateId != Guid.Empty);
        }
    }

    public class FakeMessage : Message 
    {
        public void AggregateIdExternalSet() => AggregateId = Guid.NewGuid();
    }
}