namespace DDD.Core.Common.Specification.Validation
{
    /// <summary>
    /// Class that holds a class specification rule
    /// </summary>
    /// <typeparam name="T">Class reference implementation</typeparam>
    public class Rule<T>
    {
        private readonly Specification<T> _specificationSpec;

        /// <summary>
        /// Rule constructor
        /// </summary>
        /// <param name="spec">Class specification</param>
        /// <param name="errorMessage">Error message text</param>
        public Rule(Specification<T> spec, string errorMessage)
        {
            _specificationSpec = spec;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Error message text
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        /// Validates a class based in your specification
        /// </summary>
        /// <param name="obj">Class object</param>
        /// <returns>Returns a boolean that defines if class is valid or not</returns>
        public bool Validate(T obj)
        {
            return _specificationSpec.IsSatisfiedBy(obj);
        }
    }
}