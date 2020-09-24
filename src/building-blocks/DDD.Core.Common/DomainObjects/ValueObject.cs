using System;
using System.Linq;
using System.Collections.Generic;

namespace DDD.Core.Common.DomainObjects
{
    /// <summary>
    /// A generic implementation of domain value object
    /// </summary>
    public abstract class ValueObject
    {
        /// <summary>
        /// A generic implementation of equality comparision
        /// </summary>
        /// <returns>Returns a collection with the compered elements</returns>
        protected abstract IEnumerable<object> GetEqualityComponents();

        /// <summary>
        /// Overriden method Equals
        /// </summary>
        /// <param name="obj">Receive an objet to compare</param>
        /// <returns>Return a boolean that defines if the equality is true or false</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var valueObject = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
        }

        /// <summary>
        /// Overriden method GetHashCode
        /// </summary>
        /// <returns>Returns an integer that is a hash code generation of the class</returns>
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + obj.GetHashCode();
                    }
                });
        }
    }
}