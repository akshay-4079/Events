using System;

namespace EventsHard
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Number1 myNumber = new Number1(100000);
            myNumber.PrintMoney();
            myNumber.PrintNumber();
            myNumber.PrintDecimal();
            myNumber.PrintHexidecimal();
            myNumber.PrintTemperature();
        }
    }
}
