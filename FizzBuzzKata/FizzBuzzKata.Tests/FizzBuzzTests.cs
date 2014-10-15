using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void NotFizzOrBuzz(int value)
        {
            // Arrange
            string answer = FizzBuzzKata.Answer(value);

            // Act
            bool result = answer.Equals(value + ""); 

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void JustFizz(int value)
        {
            // Arrange
            string answer = FizzBuzzKata.Answer(value); 

            // Act
            bool result = answer.Equals("Fizz"); 

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void JustBuzz(int value)
        {
            // Arrange
            string answer = FizzBuzzKata.Answer(value); 

            // Act
            bool result = answer.Equals("Buzz"); 

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(15)]
        public void FizzAndBuzz(int value)
        {
            // Arrange 
            string answer = FizzBuzzKata.Answer(value); 

            // Act
            bool result = answer.Equals("FizzBuzz"); 

            // Assert
            Assert.IsTrue(result);
        }
    }
}
