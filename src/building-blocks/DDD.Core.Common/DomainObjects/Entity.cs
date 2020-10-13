using System;
using System.Linq;
using DDD.Core.Common.Messages;
using System.Collections.Generic;

namespace DDD.Core.Common.DomainObjects
{
    /// <summary>
    /// A generic implementation of domain entity
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Entity constructor
        /// </summary>
        protected Entity()
        {
            _events = new List<Event>();
        }

        /// <summary>
        /// Unique identifier for domain entity
        /// </summary>
        public virtual Guid Id { get; protected set; }

        private readonly IList<Event> _events;
        /// <summary>
        /// List of domain events
        /// </summary>
        public virtual IReadOnlyCollection<Event> Events => _events.ToList();

        /// <summary>
        /// Adding event to entity event list
        /// </summary>
        /// <param name="event">Domain event</param>
        public virtual void AddEvent(Event @event) => _events.Add(@event);

        /// <summary>
        /// Cleaning entity event list
        /// </summary>
        public virtual void ClearEvents() => _events.Clear();

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
        public override int GetHashCode() => (GetType().GetHashCode() * 907) + Id.GetHashCode();

        /// <summary>
        /// Overriden method ToString
        /// </summary>
        /// <returns>Returns a formatted string</returns>
        public override string ToString() => $"{GetType().Name} [Id={Id}]";
    }
}