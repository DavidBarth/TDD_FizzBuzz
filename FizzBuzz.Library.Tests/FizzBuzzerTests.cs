using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {

        //Default case
        [Test] public void Buzzer_WhenDefault_ReturnsInput(
            [Values(1,2,4,7,8,11,13,14)] int input)
        {
            
            //Act
            string output = FizzBuzzer.GetValue(input);
            
            //Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDivisibleBy3_ReturnsFizz(
            [Values(3,6,9,12)] int input)
        {
      
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDivisibleBy5_ReturnsBuzz(
          [Values(5,10)] int input  )
        {
            
            
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDivisibleBy3and5(
            [Values(15)] int input)
        {
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
