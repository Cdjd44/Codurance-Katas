using System;

namespace Kata2
{
    public class Year
    {
        public Year()
        {
        }

        public bool IsLeap(int year)
        {
            if(year % 100 == 0 && year % 400 > 0) { return false; }
            if(year % 400 == 0) { return true; }
            if(year % 4 == 0) { return true; }
            return false;
        }
    }
}