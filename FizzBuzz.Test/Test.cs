using Xunit;

namespace FizzBuzz.Test
{
    public class Test
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Display_Number(int number)
        {
            var result = number.DisplayNumber();

            Assert.Equal(result, number.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Display_Fizz(int number)
        {
            var result = number.DisplayNumber();

            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Display_Buzz(int number)
        {
            var result = number.DisplayNumber();

            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void Display_FizzBuzz(int number)
        {
            var result = number.DisplayNumber();

            Assert.Equal("FizzBuzz", result);
        }
    }
}