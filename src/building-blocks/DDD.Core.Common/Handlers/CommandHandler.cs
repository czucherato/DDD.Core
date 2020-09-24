using DDD.Core.Common.Messages;
using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    /// <summary>
    /// A genetic implementation of Command Handler
    /// </summary>
    public abstract class CommandHandler : Handler
    {
        /// <summary>
        /// Command Handler constructor
        /// </summary>
        /// <param name="validationResult">Receives a ValidationResult object</param>
        protected CommandHandler(ValidationResult validationResult)
            : base(validationResult) { }

        /// <summary>
        /// Validates the class based on your business rules
        /// </summary>
        /// <typeparam name="T">Command reference implementation</typeparam>
        /// <typeparam name="U">Command result</typeparam>
        /// <param name="command">Command implementation</param>
        /// <returns>Returns an boolean that defines if validation succedes or not</returns>
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