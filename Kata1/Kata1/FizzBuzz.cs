using System;

namespace Kata1
{
    public class FizzBuzz
    {
        public object convert(int number)
        {
            if(number % 3 == 0) { return "Fizz"; }
            if(number % 5 == 0) { return "Buzz"; }
            return number.ToString();
        }
    }
}
