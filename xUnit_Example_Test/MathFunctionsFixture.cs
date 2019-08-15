using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using xUnit_Example_Test.Parameters;
using xUnit_Example_Test.Theory;

namespace xUnit_Example_Test
{
    public class MathFunctionsFixture
    {
        [Theory, ClassData(typeof(ExceptionTestTheoryData))]
        public void Divide_ShouldAssertsTrue_WhenCultureSecondValueIsZero(ExceptionTestParameter parameter)
        {
            var exceptionType = Assert.ThrowsAny<SystemException>(() => parameter.FirstValue / parameter.SecondValue);
            Assert.True(exceptionType.GetType().IsAssignableFrom(parameter.ExceptedException));
        }
    }
}
