using Xunit;
using System.Collections.Generic;
using DDD.Core.Common.DomainObjects;

namespace DDD.Core.Common.Tests.DomainObjects
{
    public class ValueObjectTests
    {
        [Fact]
        public void ValueObject_IsNot_Equals_To()
        {
            //Arrange
            var valueA = new ValueObjectA("Some Value A", 1);
            var valueB = new ValueObjectB("Some Value B", 2);

            //Act & Assert
            Assert.False(valueA.Equals(valueB));
        }

        [Fact]
        public void ValueObject_Is_Equals_To()
        {
            //Arrange
            var valueA = new ValueObjectA("Some Value A", 1);
            var valueB = valueA;

            //Act & Assert
            Assert.True(valueA.Equals(valueB));
        }

        [Fact]
        public void ValueObject_GetHashCode_Is_Not_Equal_To_Zero()
        {
            //Arrange
            var valueA = new ValueObjectA("Some Value A", 1);

            //Act & Assert
            Assert.True(valueA.GetHashCode() != 0);
        }

        [Fact]
        public void Equals_Returns_False_When_Compare_ValueObject_Is_Null()
        {
            //Arrange
            var valueA = new ValueObjectA("Some Value A", 1);

            //Act & Assert
            Assert.False(valueA.Equals(null));
        }
    }

    public class ValueObjectA : ValueObject
    {
        public ValueObjectA(string propertOne, int propertTwo)
        {
            PropertOne = propertOne;
            PropertTwo = propertTwo;
        }

        public string PropertOne { get; private set; }

        public int PropertTwo { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PropertOne;
            yield return PropertTwo;
        }
    }

    public class ValueObjectB : ValueObject
    {
        public ValueObjectB(string propertOne, int propertTwo)
        {
            PropertOne = propertOne;
            PropertTwo = propertTwo;
        }

        public string PropertOne { get; private set; }

        public int PropertTwo { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PropertOne;
            yield return PropertTwo;
        }
    }
}