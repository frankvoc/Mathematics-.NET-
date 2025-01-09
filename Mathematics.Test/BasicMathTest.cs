using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mathematics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNum()
        {
            var math = new BasicMath();
            var result = math.AddNumbers(2, 3);
            Assert.True(result == 5);
        }
    }
}
