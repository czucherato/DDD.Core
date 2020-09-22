using Xunit;
using System;
using System.Linq.Expressions;
using DDD.Core.Common.Specification;

namespace DDD.Core.Common.Tests.Specification
{
    public class SpecificationTests
    {
        [Fact]
        public void Specification_IsSatisfiedBy_Class()
        {
            //Arrange
            var spec = new ClassBSpecification();
            var classB = new ClassB() { Property1 = true };

            //Act
            var result = spec.IsSatisfiedBy(classB);

            //Assert
            Assert.True(result);
        }
    }

    public class ClassBSpecification : Specification<ClassB>
    {
        public override Expression<Func<ClassB, bool>> ToExpression()
        {
            return value => value.Property1 == true;
        }
    }

    public class ClassB
    {
        public bool Property1 { get; set; }

        public bool Property2 { get; set; }
    }
}