using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mathematics.Test
{
    public class BasicMathTest : IClassFixture<BasicMathTestFixture>
    {
        [Fact]
        public void TestAddNum()
        {
            var math = new BasicMath();
            var result = math.MultNumbers(2, 3);
            Assert.True(result == 6);
     
        }
        [Fact]
        public void TestArea()
        {
            var area = new AdvMath();
            var r = area.CalcArea(4, 3);
            Assert.True(r == 12);
        }
        [Fact]
        public void TestAvg()
        {
            var avg = new AdvMath();
            var rrr = avg.CalcAvg(4, 5);
            Assert.True(rrr == 3);
        }
        [Fact]
        public void TestSqr()
        {
            var sqr = new AdvMath();
            var rr = sqr.Squared(4);
            Assert.True(rr == 16);
        }
        [Fact]
        public void TestPythag()
        {
            var pyt = new AdvMath();
            var results = pyt.CalcPythagorean(3, 4);
            Assert.True(results == 5);
        }
    }
}
