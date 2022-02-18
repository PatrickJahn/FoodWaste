using Xunit;

namespace FoodWaste.tests
{

public class TestClass{

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void MyFirstTheory(int value){
        Assert.True(Program.IsOdd(value));
    }

    [Fact]
    public void PassingAddTest()
    {
        Assert.Equal(4, Program.Add(2,2));
    }


     [Fact]
    public void FailingAddTest()
    {
        Assert.NotEqual(5, Program.Add(2,2));
    }



    }
}