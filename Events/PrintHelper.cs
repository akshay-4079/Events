using System;
namespace Events
{
    public class PrintHelper
    {
        public delegate void BeforePrint();
        public event BeforePrint beforePrintEvent;
        public void PrintNumber(int num)
        {
           
                beforePrintEvent();

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
           
                beforePrintEvent();
            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
         
                beforePrintEvent();
            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
         
                beforePrintEvent();
            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
           
                beforePrintEvent();
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

    }



}




