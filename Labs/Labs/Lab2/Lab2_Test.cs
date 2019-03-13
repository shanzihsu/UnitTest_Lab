using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Labs.Lab2
{
    public class Lab2_Test
    {
        public void Test_1_Add_1_Should_2()
        {
            //// Arrange
            var expected = 2;

            var calculator = new Calculator();

            //// Act
            int actual = calculator.Add(1, 1);

            //// Assert
            Assert.Equal(actual, expected);
        }
    }
}
