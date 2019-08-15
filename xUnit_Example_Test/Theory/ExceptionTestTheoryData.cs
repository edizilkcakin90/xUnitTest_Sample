using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using xUnit_Example_Test.Parameters;

namespace xUnit_Example_Test.Theory
{
    public class ExceptionTestTheoryData : TheoryData<ExceptionTestParameter>
    {
        public ExceptionTestTheoryData()
        {
            Add(new ExceptionTestParameter
            {
                FirstValue = 15,
                SecondValue = 0,
                ExceptedException = typeof(DivideByZeroException)
            });
        }
    }
}
