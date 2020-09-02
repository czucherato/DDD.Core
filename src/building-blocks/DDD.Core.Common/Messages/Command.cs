using System;
using MediatR;
using FluentValidation.Results;

namespace DDD.Core.Common.Messages
{
    public abstract class Command<T> : Message, IRequest<T>
    {
        protected Command()
            : base() { }

        public ValidationResult ValidationResult { get; protected set; }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}