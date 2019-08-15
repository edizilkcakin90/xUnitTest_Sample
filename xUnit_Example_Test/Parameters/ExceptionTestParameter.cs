using System;
using System.Collections.Generic;
using System.Text;

namespace xUnit_Example_Test.Parameters
{
    public class ExceptionTestParameter
    {
        public int? FirstValue { get; set; }
        public int? SecondValue { get; set; }
        public Type ExceptedException { get; set; }
    }
}
