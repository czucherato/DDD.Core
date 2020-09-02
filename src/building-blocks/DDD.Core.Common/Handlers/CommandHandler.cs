using DDD.Core.Common.Messages;
using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    public abstract class CommandHandler : Handler
    {
        protected CommandHandler(ValidationResult validationResult)
            : base(validationResult) { }

        protected bool Validate<T,U>(T command) where T : Command<U>
        {
            var result = command.IsValid();
            foreach (var error in command.ValidationResult.Errors)
            {
                _validationResult.Errors.Add(error);
            }

            return result;
        }
    }
}