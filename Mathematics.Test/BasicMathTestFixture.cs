using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Test
{
    internal class BasicMathTestFixture : IDisposable
    {
        private BasicMath _testObject;
        public BasicMath TestObject { get => _testObject; }
        public BasicMathTestFixture()
        {
            _testObject = new BasicMath();
        }
        public void Dispose() 
        {

        }
    }
}
