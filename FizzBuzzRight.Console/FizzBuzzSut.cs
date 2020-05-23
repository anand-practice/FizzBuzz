public class FizzBuzzSut
{
    public string PrintFizzBuzz(int i)
    {
        if (i % 3 == 0 && i % 5 == 0)
            return "FizzBuzz ";
        else if (i % 3 == 0)
            return "Fizz ";
        else if (i % 5 == 0)
            return "Buzz ";
        else
            return i.ToString() + " ";

    }

    public string PrintFizzBuzzLuck(int i)
    {
        if (i.ToString().Contains("3"))
            return "Luck ";
        else if (i % 3 == 0 && i % 5 == 0)
            return "FizzBuzz ";
        else if (i % 3 == 0)
            return "Fizz ";
        else if (i % 5 == 0)
            return "Buzz ";
        else
            return i.ToString() + " ";
    }

    public string PrintFizzBuzzLuckWithCount(int i, ref int countLuck, ref int countFizz, ref int countBuzz, ref int countFizzBuzz)
    {
        if (i.ToString().Contains("3"))
        {
            countLuck++;
            return "Luck ";
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            countFizzBuzz++;
            return "FizzBuzz ";
        }
        else if (i % 3 == 0)
        {
            countFizz++;
            return "Fizz ";
        }
        else if (i % 5 == 0)
        {
            countBuzz++;
            return "Buzz ";
        }
        else
            return i.ToString() + " ";

    }

    
}
