using System;
using DDD.Core.Common.DomainObjects;

namespace DDD.Core.Common.Data
{
    /// <summary>
    /// A generic implementation of repository pattern
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public interface IRepository<T> : IDisposable where T : IAggregateRoot { }
}