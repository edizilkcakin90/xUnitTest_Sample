using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;
using xUnitExample;
using xUnit_Example_Test.Parameters;
using xUnit_Example_Test.Theory;

namespace xUnit_Example_Test
{
    public class DateTimeExtensionsFixture
    {
        public static IEnumerable<object[]> StaticParameter => new List<CultureTestParameter[]>
        {
            new CultureTestParameter[]
            {
                new CultureTestParameter
                {
                    Culture = CultureInfo.CreateSpecificCulture("gb-GB"),
                    Actual = new DateTime(1990,09,19),
                    Expected = "19 September 1990"
                }
            }
        };

        [Fact]
        public void ToDate_ShouldArgumentNullExpection_WhenCultureIsNull()
        {
            var result = Record.Exception(() => DateTime.Now.ToPrettyDate(null));
            Assert.NotNull(result);
            var exception = Assert.IsType<ArgumentNullException>(result);
            var actual = exception.ParamName;
            const string expected = "culture";
            Assert.Equal(expected, actual);
        }

        [Theory,InlineData(new object[] { "de-DE", "2019.08.15","15 August 2019"})]
        public void ToPrettyDate_ShouldAssertTrue_WhenCultureIsGerman(string cultureCode,string textDate, string expected)
        {
            var culture = CultureInfo.CreateSpecificCulture(cultureCode);
            var date = DateTime.ParseExact(textDate, "yyyy.MM.dd", culture);
            var actual = date.ToPrettyDate(culture);
            Assert.Equal(expected, actual);
        }

        [Theory,ClassData(typeof(CultureTestTheoryData))]
        public void ToPrettyDate_ShouldAssertsTrue_WhenCultureIsDefined(CultureTestParameter parameter)
        {
            var actual = parameter.Actual.ToPrettyDate(parameter.Culture);
            var expected = parameter.Expected;
            Assert.Equal(expected, actual);
        }

        [Theory,MemberData(nameof(StaticParameter))]
        public void ToPrettyDate_ShouldAssertTrue_WhenCultureIsBritish(CultureTestParameter parameter)
        {
            var actual = parameter.Actual.ToPrettyDate(parameter.Culture);
            var expected = parameter.Expected;
            Assert.Equal(expected, actual);
        }
    }
}
