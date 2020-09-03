using System;
using DDD.Core.Common.DomainObjects;

namespace DDD.Core.Common.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}