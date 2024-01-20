//The concepts of OOP in C#
using System;
using System.Net;
namespace OOP_in_Csharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        private static int _counter = 0;

        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;

        }

        public Computer(string bn, string os)
        {
            _BIOSname = bn;
            _OS = os;
        }

        public Computer() 
        {
        }

        //--------------------------------

        public static int getCounter()
        {
            return _counter;
        }
        
        //--------------------------------
        //properties
        public string BiosName
        {
            get { return _BIOSname; }
            set { _BIOSname = value; }
        }
        public string IPAddress
        {
            get { return _ipadress; }
            set { _ipadress = value; }
        }
        static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }

        public void StartComputer()
        {
            IPAddress = "10.0." + getNum() + "." + getNum();
            _counter++;
        }





    }

  
    class Program
    {

        
        public static void Main(string[] args)
        {

            Computer[] net = new Computer[4];

            for (int i = 0; i < net.Length; i++)
            {
                net[i] = new Computer("comp" + i.ToString(), "Win10");
                net[i].StartComputer();
            }

            for (int i = 0; i < net.Length; i++)
            {
                Console.WriteLine("{0} {1}", net[i].BiosName, net[i].IPAddress);
            }

            //-----------------------------------------------------------------------
            net[1].BiosName = "server 1";

            Console.WriteLine(net[1].BiosName);
            
            Computer special = new Computer();

            //---------------------------------------------------------------------------------------
            special.BiosName = "Raspberry.py";
            special.IPAddress = "12.12.12.44";

            Console.WriteLine(special.BiosName + " " + special.IPAddress);

            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

        }
    }
}
