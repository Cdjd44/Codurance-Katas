using System;

namespace Kata2
{
    public class Year
    {
        private readonly int _year;
        public Year(int year)
        {
            _year = year;
        }

        public bool IsLeap()
        {
            //If DivideBy(100) is True then do DivideBy(400), else do DivideBy(4)
            return DivideBy(100) ? DivideBy(400) : DivideBy(4);
        }

        public bool DivideBy(int value)
        {
            return _year % value == 0;
        }
    }
}