using System;

namespace SampleApp
{
    public delegate string MyDel(string str);

    class EventProgram
    {
        public int count = 0;
        event MyDel MyEvent;

        public EventProgram()
        {
           
            this.MyEvent += new MyDel(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            count++;
            return username;
        }

        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Welcome User");
            Console.WriteLine(result);
            result = obj1.MyEvent("Event Has Fired ");
            Console.WriteLine(result);
            result = obj1.MyEvent("Event Has Fired Again ");
            Console.WriteLine(result);
            Console.WriteLine($"Event has Fired {obj1.count} Times");
        }

    }
}