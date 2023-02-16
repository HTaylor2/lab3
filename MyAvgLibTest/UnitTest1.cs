//harold taylor CPS 3330_01
using Xunit;
using MyAvgLib;
namespace MyAvgLibTest;

public class UnitTest1
{
    [Fact]
    public void TestAvg10and20()
    {
        double a = 10;
        double b = 20;
        double expected = 15;

        double actual = Avg.MyAvg(a,b);

        Assert.Equal(expected, actual); 
    }

    [Fact]
    public void TestAvg90and20()
    {
        double a = 90;
        double b = 20;
        double expected = 55;

        double actual = Avg.MyAvg(a,b);

        Assert.Equal(expected, actual); 
    } 
}