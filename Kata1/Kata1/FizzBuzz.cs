using System;

namespace Kata1
{
    public class FizzBuzz
    {
        public object convert(int number)
        {
            if(number % 3 == 0) { return "Fizz"; }
            return number.ToString();
        }
    }
}
