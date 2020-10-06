using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            if (str.Contains(" "))
                return true;
            else
                return false;
        }
    }
}
