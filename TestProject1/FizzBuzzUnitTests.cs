using ClassLibrary1;
using FluentAssertions;

namespace TestProject1
{
    public class FizzBuzzUnitTests
    {
        [Fact]
        public void Division_divid_number_on_three_when_leftover_is_zero_properly()
        {
            var num = 6;
            var fizzbuzz = new FizzBuzz();
            var expected = "Fizz";

            var actual = fizzbuzz.FizzOrBuzz(num);

            actual.Should().Be(expected);
        }
        [Fact]
        public void Division_divid_number_on_Five_when_leftover_is_zero_properly()
        {
            var num = 10;
            var fizzbuzz = new FizzBuzz();
            var expected = "Buzz";

            var actual = fizzbuzz.FizzOrBuzz(num);

            actual.Should().Be(expected);
        }
        [Fact]
        public void Division_divid_number_on_three_and_five_when_leftover_is_zero_properly()
        {
            var num = 15;
            var fizzBuzz = new FizzBuzz();
            var expected = "FizzBuzz";

            var actual = fizzBuzz.FizzOrBuzz(num);

            actual.Should().Be(expected);
        }
        [Fact]
        public void Division_throws_exception_when_number_leftover_is_not_zero_on_three_or_five()
        {
            var num = 8;
            var fizzbuzz = new FizzBuzz();

            var actual =() => fizzbuzz.FizzOrBuzz(num);

            actual.Should().ThrowExactly<NumberLeftoverIsNotZeroOnThreeOrFive>();
        }

    }
}