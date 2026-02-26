using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Tests
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(10.0, BmiClassification.Underweight)]
        [InlineData(15.0, BmiClassification.Underweight)]
        [InlineData(8.0, BmiClassification.Underweight)]
        [InlineData(19, BmiClassification.Normal)]
        [InlineData(21, BmiClassification.Normal)]
        [InlineData(24, BmiClassification.Normal)]
        [InlineData(24.8, BmiClassification.Normal)]
        [InlineData(25.8, BmiClassification.Overweight)]
        [InlineData(28.8, BmiClassification.Overweight)]
        [InlineData(30.8, BmiClassification.Obesity)]
        [InlineData(32.8, BmiClassification.Obesity)]
        [InlineData(34.9, BmiClassification.Obesity)]
        [InlineData(35.9, BmiClassification.ExtremeObesity)]
        public void DetermineBmi_ForGivenBmi_ReturnCorrectClassification(double bmi, BmiClassification classification)
        {
            //arrange
            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            //act
            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            //assert
            Assert.Equal(classification, result);
        }
    }
}
