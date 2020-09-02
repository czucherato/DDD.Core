using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    public abstract class EventHandler : Handler
    {
        protected EventHandler(ValidationResult validationResult)
            : base(validationResult) { }
    }
}