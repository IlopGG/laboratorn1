using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FunctionCalculatorTests
{
    [TestMethod]
    public void TestFunctionCalculation()
    {
        // arrange 
        double x = 0;
        double expectedY = 10;

        // act
        double actualY = FunctionCalculator.Calculate(x);

        // assert
        Assert.AreEqual(expectedY, actualY);
    }
}
 