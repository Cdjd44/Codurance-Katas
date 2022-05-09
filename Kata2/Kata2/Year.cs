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
            if(year % 4 == 0) { return true; }
            return false;
        }
    }
}