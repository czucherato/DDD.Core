using Xunit;
using DDD.Core.Common.Handlers;
using FluentValidation.Results;

namespace DDD.Core.Common.Tests.Handlers
{
    public class QueryHandlerTests
    {
        [Fact]
        public void QueryHandler_Instantiation()
        {
            //Arrange & Act & Assert
            Assert.NotNull(new ExtendedQueryHandler(new ValidationResult()));

        }
    }

    public class ExtendedQueryHandler : QueryHandler
    {
        public ExtendedQueryHandler(ValidationResult validationResult)
            : base(validationResult) { }
    }
}