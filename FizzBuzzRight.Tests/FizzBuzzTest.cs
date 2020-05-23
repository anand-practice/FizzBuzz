using NUnit.Framework;

public class FizzBuzzTest
{
    FizzBuzzSut _sut;

    [SetUp]
    public void Initialize()
    {
        _sut = new FizzBuzzSut();
    }

    [Test]
    public void print_fizz_for_multiples_of_three()
    {
        Assert.IsTrue(_sut.PrintFizzBuzz(3).Contains("Fizz"));
    }

    [Test]
    public void print_buzz_for_multiples_of_five()
    {
        Assert.IsTrue(_sut.PrintFizzBuzz(5).Contains("Buzz"));
    }

    [Test]
    public void print_fizzbuzz_for_multiples_on_both_three_and_five()
    {
        Assert.IsTrue(_sut.PrintFizzBuzz(15).Contains("FizzBuzz"));
    }

    [Test]
    public void print_luck_if_contains_3()
    {
        Assert.IsTrue(_sut.PrintFizzBuzzLuck(3).Contains("Luck"));
    }

    [Test]
    public void print_luck_with_count()
    {

        int countLuck = 0;
        int countFizz = 0;
        int countBuzz = 0;
        int countFizzBuzz = 0;
        string str = string.Empty;

        for (int i = 1; i <= 20; i++)
            _sut.PrintFizzBuzzLuckWithCount(i, ref countLuck, ref countFizz, ref countBuzz, ref countFizzBuzz);

        Assert.AreEqual(2, countLuck);
    }


}