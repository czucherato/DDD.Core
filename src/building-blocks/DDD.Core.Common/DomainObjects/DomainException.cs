using System;
using System.Runtime.Serialization;

namespace DDD.Core.Common.DomainObjects
{
    /// <summary>
    /// Class for domain exception implementation
    /// </summary>
    [Serializable]
    public class DomainException : Exception
    {
        /// <summary>
        /// DomainException constructor
        /// </summary>
        public DomainException() { }

        /// <summary>
        /// DomainException constructor
        /// </summary>
        /// <param name="message">Error message</param>
        public DomainException(string message) : base(message) { }

        /// <summary>
        /// DomainException constructor
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">Inner exception</param>
        public DomainException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// DomainException constructor
        /// </summary>
        /// <param name="info">Data store for serialzation</param>
        /// <param name="context">Source and destination of a given serialized stream</param>
        protected DomainException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}