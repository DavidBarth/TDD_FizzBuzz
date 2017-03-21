namespace FizzBuzz.Library
{
    //Class representing the FizzBuzzer object that is under test
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }

            return input.ToString();
         }
     }
}
