using System.Text;

namespace FizzBuzz
{
    public static class Logic
    {
        public static string DisplayNumber(this int number)
        {
            var result = new StringBuilder();

            if (number % 3 == 0)
                result.Append("Fizz");

            if (number % 5 == 0)
                result.Append("Buzz");

            return result.Length > 0 ? result.ToString() : number.ToString();
        }
    }
}
