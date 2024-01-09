
using Xunit;

namespace EvenOrOdd
{
    public class EvalutorTest
    {
        [Fact]
        public void evaluate_should_return_Even()
        {
            const int input = 6;
            var e = new Evalutor();
            var actual = e.evaluate(input);
            Assert.Equal("fjewjf",actual);
        }
    }
}
