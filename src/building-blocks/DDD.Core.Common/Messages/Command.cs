using MediatR;
using FluentValidation.Results;

namespace DDD.Core.Common.Messages
{
    /// <summary>
    /// A generic CQRS command implementation
    /// </summary>
    /// <typeparam name="T">Command result</typeparam>
    public abstract class Command<T> : Message, IRequest<T>
    {
        /// <summary>
        /// Command constructor
        /// </summary>
        protected Command()
            : base() { }

        /// <summary>
        /// ValidationResult property
        /// </summary>
        public ValidationResult ValidationResult { get; protected set; } = new ValidationResult();

        /// <summary>
        /// A generic implementation of class validation
        /// </summary>
        /// <returns>Returns a boolean that defines if class is valid or not</returns>
        public abstract bool IsValid();
    }
}