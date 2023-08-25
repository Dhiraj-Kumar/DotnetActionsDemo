using CalculatorApp;
namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void CheckSum()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(30, calc.Sum(10, 20));
    }
}