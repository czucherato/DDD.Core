using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    /// <summary>
    /// A genetic implementation of Event Handler
    /// </summary>
    public abstract class EventHandler : Handler
    {
        /// <summary>
        /// Event Handler constructor
        /// </summary>
        /// <param name="validationResult">Receives a ValidationResult object</param>
        protected EventHandler(ValidationResult validationResult)
            : base(validationResult) { }
    }
}