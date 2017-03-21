using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {

        [Test]
        public void Buzzer_When1_Returns1()
        {
            //Arrange
            int input = 1;
            
            //Act
            string output = FizzBuzzer.GetValue(input);
            
            //Assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void Buzzer_When2_Returns2()
        {
            //Arrange
            int input = 2;

            //Act
            string output = FizzBuzzer.GetValue(input);
            
            //Assert
            Assert.AreEqual("2", output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            //Arrange
            int input = 3;

            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);
        }
    }
}
