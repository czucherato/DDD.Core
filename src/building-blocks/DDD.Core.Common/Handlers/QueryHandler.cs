using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    /// <summary>
    /// A generic implementation of Query Handler
    /// </summary>
    public abstract class QueryHandler : Handler
    {
        /// <summary>
        /// Query Handler constructor
        /// </summary>
        /// <param name="validationResult">Receives a ValidationResult object</param>
        protected QueryHandler(ValidationResult validationResult)
            : base(validationResult) { }
    }
}