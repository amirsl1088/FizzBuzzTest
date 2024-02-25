namespace ClassLibrary1
{
    public class FizzBuzz
    {
        public string FizzOrBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            if (num % 5 == 0)
            {
                return "Buzz";
            }
            throw new NumberLeftoverIsNotZeroOnThreeOrFive();
        }
    }
}