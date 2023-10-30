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

        Assert.AreEqual(FizzBuzzType.Fizz, res);
    }


    [TestMethod]
    [DataRow(5)]
    [DataRow(10)]
    public void ReturnsBuzzIfTheNumberIsMultipleOfFive(int input)
    {
        FizzBuzzType res = FizzBuzz.FizzBuzz(input);

        Assert.AreEqual(FizzBuzzType.Buzz, res);
    }

    [TestMethod]
    public void ReturnsFizzBuzzIfTheNumberIsMultipleOfThreeAndFive()
    {
        FizzBuzzType res = FizzBuzz.FizzBuzz(15);

        Assert.AreEqual(FizzBuzzType.FizzBuzz, res);
    }
}