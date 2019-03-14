using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Labs.Lab5
{
    public class Test_Lab5
    {
        [Fact]
        public void Test_Equal()
        {
            var a = 1;
            var b = 2;
            var c = 1;

            //// Equal
        }

        [Fact]
        public void Test_Date()
        {
            var actual = new DateTime(2019, 1, 1);

            //// Same Date
        }

        [Fact]
        public void Test_List()
        {
            var a = new List<int> { 1, 2, 3 };
            var b = new List<int> { 1, 2, 3 };

            //// Comare List
        }

        [Fact]
        public void Test_Object_Equal()
        {
            var a = new TestData
            {
                Id = 1,
                Data = new TestChildData
                {
                    Data = 2
                }
            };

            var b = new TestData
            {
                Id = 1,
                Data = new TestChildData
                {
                    Data = 2
                }
            };

            //// Compare Object
        }
    }
}
