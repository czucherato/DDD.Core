using System;

namespace DDD.Core.Common.DomainObjects
{
    /// <summary>
    /// A generic implementation of domain entity
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Unique identifier for domain entity
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Overriden method Equals
        /// </summary>
        /// <param name="obj">Receive an objet to compare</param>
        /// <returns>Return a boolean that defines if the equality is true or false</returns>
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return Id.Equals(compareTo.Id);
        }

        /// <summary>
        /// Overriden method GetHashCode
        /// </summary>
        /// <returns>Returns an integer that is a hash code generation of the class</returns>
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        /// <summary>
        /// Overriden method ToString
        /// </summary>
        /// <returns>Returns a formatted string</returns>
        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }
    }
}