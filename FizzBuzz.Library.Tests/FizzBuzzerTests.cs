using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {

        //Default case
        [Test] public void Buzzer_WhenDefault_ReturnsInput(
            [Values(1,2,4)] int input)
        {
            
            //Act
            string output = FizzBuzzer.GetValue(input);
            
            //Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz(
            [Values(3,6)] int input)
        {
      
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_When5_ReturnsBuzz()
        {
            //Arrange
            int input = 5;

            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Buzz", output);
        }
    }
}
