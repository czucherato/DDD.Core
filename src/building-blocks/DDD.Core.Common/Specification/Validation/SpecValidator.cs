using FluentValidation.Results;
using System.Collections.Generic;

namespace DDD.Core.Common.Specification.Validation
{
    /// <summary>
    /// Class that validates another class based in your specifications
    /// </summary>
    /// <typeparam name="T">Class reference implementation</typeparam>
    public class SpecValidator<T>
    {
        private readonly Dictionary<string, Rule<T>> _validations = new Dictionary<string, Rule<T>>();

        /// <summary>
        /// Validates a class based in your specifications
        /// </summary>
        /// <param name="obj">Class object</param>
        /// <returns>Returns a ValidationResult with the specification errors</returns>
        public ValidationResult Validate(T obj)
        {
            var validationResult = new ValidationResult();
            foreach (var rule in _validations.Keys)
            {
                var validation = _validations[rule];
                if (!validation.Validate(obj))
                    validationResult.Errors.Add(new ValidationFailure(obj.GetType().Name, validation.ErrorMessage));
            }

            return validationResult;
        }

        /// <summary>
        /// Adds a specification rule
        /// </summary>
        /// <param name="name">Rune name</param>
        /// <param name="rule">Rule object</param>
        public void Add(string name, Rule<T> rule)
        {
            _validations.Add(name, rule);
        }

        /// <summary>
        /// Removes a specification rule
        /// </summary>
        /// <param name="name">Rule name</param>
        public void Remove(string name)
        {
            _validations.Remove(name);
        }

        /// <summary>
        /// Gets a specification rule
        /// </summary>
        /// <param name="name">Rule name</param>
        /// <returns></returns>
        public Rule<T> GetRule(string name)
        {
            _validations.TryGetValue(name, out var rule);
            return rule;
        }
    }
}