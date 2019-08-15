using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace xUnit_Example_Test.Parameters
{
    public class CultureTestParameter
    {
        public CultureInfo Culture { get; set; }
        public DateTime Actual { get; set; }
        public string Expected { get; set; }
    }
}
