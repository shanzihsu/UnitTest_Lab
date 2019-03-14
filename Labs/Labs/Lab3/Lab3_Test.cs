using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Labs.Lab3
{
    public class Lab3_Test
    {
        public void Test_4_Devide_2_Should_Equal_2()
        {
            //// Arrange
            var first = 4d;
            var second = 2d;
            var expected = 2d;
            var calculator = new Calculator();

            //// Act
            var actual = calculator.Devide(first, second);

            //// Assert
            Assert.Equal(actual, expected);
        }
    }
}
