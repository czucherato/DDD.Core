using Xunit;
using System;
using DDD.Core.Common.DomainObjects;

namespace DDD.Core.Common.Tests.DomainObjects
{
    public class DomainExceptionTests
    {
        [Fact]
        public void Parameterless_Constructor_Expects_Throwing_Exception()
        {
            //Arrage & Act & Assert
            Assert.ThrowsAsync<DomainException>(() => throw new DomainException()).GetAwaiter().GetResult();
        }

        [Fact]
        public void Passing_Message_Expects_Throwing_Exception()
        {
            //Arrage & Act & Assert
            Assert.ThrowsAsync<DomainException>(() => throw new DomainException("Exception message")).GetAwaiter().GetResult();
        }

        [Fact]
        public void Passing_InnerException_Expects_Throwing_Exception()
        {
            //Arrage
            var exception = new Exception("Exception message");
            
            //Act & Assert
            Assert.ThrowsAsync<DomainException>(() => throw new DomainException(exception.Message, exception)).GetAwaiter().GetResult();
        }
    }
}