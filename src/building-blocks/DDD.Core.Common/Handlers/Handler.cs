using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    public abstract class Handler
    {
        protected Handler(ValidationResult validationResult)
        {
            _validationResult = validationResult;
        }

        protected readonly ValidationResult _validationResult;

        protected void AddError(string errorMessage)
        {
            _validationResult.Errors.Add(new ValidationFailure(string.Empty, errorMessage));
        }

        protected void ClearErrors()
        {
            _validationResult.Errors.Clear();
        }
    }
}