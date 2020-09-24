using System;
using System.Linq.Expressions;

namespace DDD.Core.Common.Specification
{
    /// <summary>
    /// A generic specification implementation
    /// </summary>
    /// <typeparam name="T">Class reference implementation</typeparam>
    public class GenericSpecification<T>
    {
        private Expression<Func<T, bool>> Expression { get; }

        /// <summary>
        /// Generic Specification constructor
        /// </summary>
        /// <param name="expression">Expression tree</param>
        public GenericSpecification(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }

        /// <summary>
        /// Method that satisfy a specification condition
        /// </summary>
        /// <param name="entity">Class object</param>
        /// <returns>Returns a boolean that defines if the condition was satisfied or not</returns>
        public bool IsSatisfiedBy(T entity)
        {
            return Expression.Compile().Invoke(entity);
        }
    }
}