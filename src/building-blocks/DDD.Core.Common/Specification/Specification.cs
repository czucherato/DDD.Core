using System;
using System.Linq.Expressions;

namespace DDD.Core.Common.Specification
{
    /// <summary>
    /// A generic specification implementation
    /// </summary>
    /// <typeparam name="T">Class reference implementation</typeparam>
    public abstract class Specification<T>
    {
        /// <summary>
        /// Method that satisfy a specification condition
        /// </summary>
        /// <param name="entity">Class object</param>
        /// <returns>Returns a boolean that defines if the condition was satisfied or not</returns>
        public bool IsSatisfiedBy(T entity)
        {
            var predicate = ToExpression().Compile();
            return predicate(entity);
        }

        /// <summary>
        /// A generic expression tree implementation
        /// </summary>
        /// <returns>Returns a expression tree</returns>
        public abstract Expression<Func<T, bool>> ToExpression();

        /// <summary>
        /// Aggregates a AndSpecification
        /// </summary>
        /// <param name="specification">Specification implementation</param>
        /// <returns>Returns a AndSpecification objetc</returns>
        public Specification<T> And(Specification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        /// <summary>
        /// Aggregates a OrSpecification
        /// </summary>
        /// <param name="specification">Specification implementation</param>
        /// <returns>Returns a OrSpecification objetc</returns>
        public Specification<T> Or(Specification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }

        /// <summary>
        /// Aggregates a NotSpecification
        /// </summary>
        /// <returns>Returns a NotSpecification objetc</returns>
        public Specification<T> Not()
        {
            return new NotSpecification<T>(this);
        }
    }
}