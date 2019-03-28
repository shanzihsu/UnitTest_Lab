# Lab1 建立測試專案

1.打開 Visual Studio

2.進到 /Lab1/Lab.cs

撰寫入以下程式碼

``` C# 
    [Fact]
    public void Test_1_Add_1_Should_Equal_2()
    {
        //// Arrange
        expected = 2;

        var calculator = new Calculator();

        //// Act
        var actual = calculator.Add(1, 1);

        //// Assert
        Assert.Equal(actual, expected);
    }
```