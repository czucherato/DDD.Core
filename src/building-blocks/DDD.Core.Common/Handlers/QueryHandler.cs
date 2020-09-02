using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    public abstract class QueryHandler : Handler
    {
        protected QueryHandler(ValidationResult validationResult)
            : base(validationResult) { }
    }
}