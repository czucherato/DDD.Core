using Xunit;
using DDD.Core.Common.Specification;

namespace DDD.Core.Common.Tests.Specification
{
    public class GenericSpecificationTests
    {
        [Fact]
        public void Generic_Specification_IsSatisfiedBy_Returns_True()
        {
            //Arrange
            var spec = new GenericSpecification<ClassA>(x => x.Property == true);
            var classA = new ClassA { Property = true };

            //Act
            var result = spec.IsSatisfiedBy(classA);

            //Assert
            Assert.True(result);
        }
    }

    public class ClassA 
    {
        public bool Property { get; set; }
    }
}