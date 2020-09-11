using Xunit;
using System;
using DDD.Core.Common.DomainObjects;

namespace DDD.Core.Common.Tests.DomainObjects
{
    public class EntityTests
    {
        [Fact]
        public void Entity_IsNot_Equals_To()
        {
            //Arrange
            var entityA = new EntityA();
            var entityB = new EntityB();

            //Act & Assert
            Assert.False(entityA.Equals(entityB));
        }

        [Fact]
        public void Entity_GetHashCode_Is_Higher_Than_Zero()
        {
            //Arrange 
            var entityA = new EntityA();

            //Act & Assert
            Assert.True(entityA.GetHashCode() > 0);
        }

        [Fact]
        public void Entity_ToString_Is_Not_Empty()
        {
            //Arrange 
            var entityA = new EntityA();

            //Act & Assert
            Assert.False(string.IsNullOrEmpty(entityA.ToString()));
        }

        [Fact]
        public void Equals_Returns_False_When_Compare_Entity_Is_Null()
        {
            //Arrange 
            var entityA = new EntityA();

            //Act & Assert
            Assert.False(entityA.Equals(null));
        }

        [Fact]
        public void Equals_Returns_True_When_Compare_Entity_Has_The_Same_Reference()
        {
            //Arrange 
            var entityA = new EntityA();
            var entityAClone = entityA;

            //Act & Assert
            Assert.True(entityA.Equals(entityAClone));
        }
    }

    public class EntityA : Entity
    {
        public EntityA()
        {
            Id = Guid.NewGuid();
        }
    }

    public class EntityB : Entity
    {
        public EntityB()
        {
            Id = Guid.NewGuid();
        }
    }
}