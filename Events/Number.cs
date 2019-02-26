using System;
namespace Events

{
   public class Number
    {
        private PrintHelper _printHelper;

        public Number(int val)
        {
            _value = val;
            _printHelper = new PrintHelper();
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
          
        }
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }
        void printHelper1_beforePrintEvent1(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message); ;
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

        public void PrintDecimal()
        {
            _printHelper.PrintDecimal(_value);
        }
        public void PrintTemperature()
        {
            _printHelper.PrintTemperature(_value);
        }
        public void PrintHexadecimal()
        {
            _printHelper.PrintHexadecimal(_value);
        }

       

    }

}
