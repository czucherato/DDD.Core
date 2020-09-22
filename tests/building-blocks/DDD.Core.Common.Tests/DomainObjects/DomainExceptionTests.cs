using Xunit;
using System;
using System.Runtime.Serialization;
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

        [Fact]
        public void Calling_Protected_Constructor()
        {
            //Arrange
            SerializationInfo info = new SerializationInfo(typeof(ExtendedDomainException), new FormatterConverter());
            info.AddValue("Message", string.Empty);
            info.AddValue("InnerException", new ArgumentException());
            info.AddValue("HelpURL", string.Empty);
            info.AddValue("StackTraceString", string.Empty);
            info.AddValue("RemoteStackTraceString", string.Empty);
            info.AddValue("RemoteStackIndex", 0);
            info.AddValue("ExceptionMethod", string.Empty);
            info.AddValue("HResult", 1);
            info.AddValue("Source", string.Empty);
            StreamingContext context = new StreamingContext();

            //Act
            var exception = new ExtendedDomainException(info, context);

            //Assert
            Assert.NotNull(exception);
        }
    }

    public class ExtendedDomainException : DomainException
    {
        public ExtendedDomainException(SerializationInfo info, StreamingContext context)
            : base (info, context) { }
    }
}