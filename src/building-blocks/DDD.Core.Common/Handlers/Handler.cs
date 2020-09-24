using FluentValidation.Results;

namespace DDD.Core.Common.Handlers
{
    /// <summary>
    /// A generic implementation of Handler
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// Handler constructor
        /// </summary>
        /// <param name="validationResult">Receives a ValidationResult object</param>
        protected Handler(ValidationResult validationResult)
        {
            _validationResult = validationResult;
        }

        /// <summary>
        /// ValidationResult read only property
        /// </summary>
        protected readonly ValidationResult _validationResult;

        /// <summary>
        /// Method that adds an error to ValidationResult collection
        /// </summary>
        /// <param name="errorMessage">Text of the error message</param>
        protected void AddError(string errorMessage)
        {
            _validationResult.Errors.Add(new ValidationFailure(string.Empty, errorMessage));
        }

        /// <summary>
        /// Method that clerar all errors from ValidationResult collection
        /// </summary>
        protected void ClearErrors()
        {
            _validationResult.Errors.Clear();
        }
    }
}