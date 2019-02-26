using System;
namespace EventsHard
{
    public class PrintHelper1
    {
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrintEvent;
        public void PrintNumber(int num)
        {
         
                beforePrintEvent.Invoke("PrintNumber");

            Console.WriteLine("Number: {0,-12:N0}", num);

        }

        public void PrintDecimal(int dec)
        {
   
                beforePrintEvent("PrintDecimal");

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
     
                beforePrintEvent("PrintMoney");

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
   
                beforePrintEvent("PrintTemerature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
         
                beforePrintEvent("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
