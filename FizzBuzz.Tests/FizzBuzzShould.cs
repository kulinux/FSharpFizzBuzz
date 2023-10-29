namespace FizzBuzz.Tests;

[TestClass]
public class FizzBuzzShould
{
    [TestMethod]
    public void ReturnsOneIfTheNumberIsOne()
    {
        FizzBuzzType res = FizzBuzz.FizzBuzz(1);

        Assert.AreEqual(FizzBuzzType.NewNumber(1), res);
    }

    [TestMethod]
    [DataRow(3)]
    [DataRow(6)]
    public void ReturnsFizzIfTheNumberIsMulipleOfThree(int input)
    {
        FizzBuzzType res = FizzBuzz.FizzBuzz(input);

        Assert.AreEqual(FizzBuzzType.NewString("Fizz"), res);
    }


    [TestMethod]
    public void ReturnsBuzzIfTheNumberIsFive()
    {
        FizzBuzzType res = FizzBuzz.FizzBuzz(5);

        Assert.AreEqual(FizzBuzzType.NewString("Buzz"), res);
    }
}