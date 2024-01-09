using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Start_shouldReturnALIstWithGivenRoundsLength()
        {
            const int input = 120;
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.start(input);
            Assert.Equal(120,result.Count());
        }

        [Fact]
        public void Start_ShouldReturnProperValueAtExpectedIndex_WhenNumberDividableTo3()
        {
            const int input = 120;
            const int index = 2;
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.start(input);
            Assert.Equal("Fizz", result[index]);
        }
        [Fact]
        public void Start_ShouldReturnProperValueAtExpectedIndex_WhenNumberDividableTo5()
        {
            const int input = 120;
            const int index = 4;
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.start(input);
            Assert.Equal("Buzz", result[index]);
        }
        [Fact]
        public void Start_ShouldReturnProperValueAtExpectedIndex_WhenNumberDividableTo15()
        {
            const int input = 120;
            const int index = 14;
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.start(input);
            Assert.Equal("FizzBuzz", result[index]);
        }

    }

    public class FizzBuzz
    {
        public List<string> start(int input)
        {
           var result = new List<string>();
           for (int i = 1; i <= input; i++)
           {
               var output = i % 3 == 0 ? "Fizz" : string.Empty;
               output += i % 5 == 0 ? "Buzz" : string.Empty;
               output += output == string.Empty ? i.ToString() : string.Empty;
               result.Add(output);

            }
           return result;
        }
    }
}



