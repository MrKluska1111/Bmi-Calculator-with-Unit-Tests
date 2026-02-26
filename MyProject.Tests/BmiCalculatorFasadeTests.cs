using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace MyProject.Tests
{
    public class BmiCalculatorFasadeTests
    {
        private const string OVERWEIGHT_SUMMARY = "You are a bit overweight";

        [Fact]
        public void GetResult_ForValidInputs_ReturnsCorrectResult()
        {
            //arrange
            BmiCalculatorFacade bmiCalculatorFasade = new BmiCalculatorFacade(UnitSystem.Metric);

            //act 
            double weight = 90;
            double height = 190;

            BmiResult result = bmiCalculatorFasade.GetResult(weight, height);

            //assert
            //Assert.Equal(24.93, result.Bmi);
            //Assert.Equal(BmiClassification.Overweight, result.BmiClassification);
            //Assert.Equal(OVERWEIGHT_SUMMARY, result.Summary);

            result.Bmi.Should().Be(24.93);
            result.BmiClassification.Should().Be(BmiClassification.Overweight);
            result.Summary.Should().Be(OVERWEIGHT_SUMMARY);
        }
    }
}
