using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xunit;
using xUnit_Example_Test.Parameters;

namespace xUnit_Example_Test.Theory
{
    public class CultureTestTheoryData : TheoryData<CultureTestParameter>
    {
        public CultureTestTheoryData()
        {
            Add(new CultureTestParameter
            {
                Culture = CultureInfo.CreateSpecificCulture("tr-TR"),
                Actual = new DateTime(2019, 08, 15),
                Expected = "15 Agustos 2019"
            });

            Add(new CultureTestParameter
            {
                Culture = CultureInfo.CreateSpecificCulture("us-US"),
                Actual = new DateTime(1990, 09, 19),
                Expected = "19 Eylul 1990"
            });
        }
    }
}
