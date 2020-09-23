using Xunit;
using System;
using System.Linq.Expressions;
using DDD.Core.Common.Specification;
using DDD.Core.Common.Specification.Validation;

namespace DDD.Core.Common.Tests.Specification
{
    public class SpecValidatorTests
    {
        [Fact]
        public void Adding_Rule()
        {
            //Arrange
            var specValidator = new SpecValidator<ClassD>();
            var spec = new ClassDCSpecification();
            var rule = new Rule<ClassD>(spec, "Property can't be false");

            //Act & Assert
            specValidator.Add("Rule 1", rule);
        }

        [Fact]
        public void Removing_Rule()
        {
            //Arrange
            var specValidator = new SpecValidator<ClassD>();
            var spec = new ClassDCSpecification();
            var rule = new Rule<ClassD>(spec, "Property can't be false");
            specValidator.Add("Rule 1", rule);

            //Act & Assert
            specValidator.Remove("Rule 1");
        }

        [Fact]
        public void Getting_Rule()
        {
            //Arrange
            var specValidator = new SpecValidator<ClassD>();
            var spec = new ClassDCSpecification();
            var rule = new Rule<ClassD>(spec, "Property can't be false");
            specValidator.Add("Rule 1", rule);

            //Act
            var result = specValidator.GetRule("Rule 1");

            //Assert
            Assert.Equal(rule, result);
        }

        [Fact]
        public void Validate_Without_Spec_Errors()
        {
            //Arrange
            var classD = new ClassD { Property1 = true };
            var specValidator = new SpecValidator<ClassD>();
            var spec = new ClassDCSpecification();
            var rule = new Rule<ClassD>(spec, "Property can't be false");
            specValidator.Add("Rule 1", rule);

            //Act
            var validationResult = specValidator.Validate(classD);

            //Assert
            Assert.True(validationResult.IsValid);
        }

        [Fact]
        public void Validate_With_Spec_Errors()
        {
            //Arrange
            var classD = new ClassD { Property1 = false };
            var specValidator = new SpecValidator<ClassD>();
            var spec = new ClassDCSpecification();
            var rule = new Rule<ClassD>(spec, "Property can't be false");
            specValidator.Add("Rule 1", rule);

            //Act
            var validationResult = specValidator.Validate(classD);

            //Assert
            Assert.False(validationResult.IsValid);
        }
    }

    public class ClassD
    {
        public bool Property1 { get; set; }
    }

    public class ClassDCSpecification : Specification<ClassD>
    {
        public override Expression<Func<ClassD, bool>> ToExpression()
        {
            return value => value.Property1 == true;
        }
    }
}