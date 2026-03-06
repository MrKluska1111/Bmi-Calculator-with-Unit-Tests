using Exercises._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualBasic;

namespace Exercise.Solution.Tests
{
    public class ValidatorTests2
    {
        public static IEnumerable<object[]> GetRangesList()
        {
            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 1), new DateTime(2020, 1, 15)),
                    new DateRange(new DateTime(2020, 2, 1), new DateTime(2020, 2, 15)),

                },
            };

            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 15), new DateTime(2020, 1, 25))

                }
            };

            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 8), new DateTime(2020, 1, 25))
                }
            };

            yield return new object[]
            {
                new List<DateRange>()
                {
                    new DateRange(new DateTime(2020, 1, 12), new DateTime(2020, 1, 14))
                }
            };
        }

        [Theory]
        //[InlineData(0)]
        //[InlineData(1)]
        //[InlineData(2)]
        //[InlineData(3)]
        [MemberData(nameof(GetRangesList))]
        public void ValidateOverlapping_ForOverlappingDateRanges_ReturnsFalse(List<DateRange> ranges)
        {
            //arrange

            DateRange input = new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20));
            Validator validator = new Validator();

            //act
            bool result = validator.ValidateOverlapping(ranges, input);

            //assert
            result.Should().BeFalse();
        }

        [Theory]
        [ClassData(typeof(ValidatorTestData))]
        public void ValidateOverlapping_ForOverlappingDateRanges_ReturnsFalse2(List<DateRange> ranges)
        {
            //arrange

            DateRange input = new DateRange(new DateTime(2020, 1, 10), new DateTime(2020, 1, 20));
            Validator validator = new Validator();

            //act
            bool result = validator.ValidateOverlapping(ranges, input);

            //assert
            result.Should().BeFalse();
        }
    }
}

