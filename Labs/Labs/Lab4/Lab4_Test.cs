using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Labs.Lab4
{
    public class Lab4_Test
    {
        [Fact]
        public void Test_Equal()
        {
            var a = 1;
            var b = 1;
            var c = 2;

            //// Equal

            //// Not Equal
        }

        [Fact]
        public void Test_Same()
        {
            var a = new TestData { Data = 1 };
            var b = new TestData { Data = 1 };
            var c = a;

            //// Same


            //// NotSame
        }

        [Fact]
        public void Test_Exception()
        {
            var a = 1;
            var b = 0;

            //// Assert Exception

            //// Record
        }
    }
}
