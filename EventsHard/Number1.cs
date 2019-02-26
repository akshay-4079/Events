using System;
namespace EventsHard
{
    public class Number1
    {
        private PrintHelper1 _printHelper;

        public Number1(int val)
        {
            _value = val;

            _printHelper = new PrintHelper1();

            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }
 
        void printHelper_beforePrintEvent(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message);
        }

        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
        public void PrintTemperature()
        {
            _printHelper.PrintTemperature(_value);
        }
        public void PrintHexidecimal()
        {
            _printHelper.PrintHexadecimal(_value);
        }
        public void PrintDecimal()
        {
            _printHelper.PrintDecimal(_value);
        }
       
    }
}
