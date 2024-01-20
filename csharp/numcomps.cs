//The concepts of OOP in C#
using System.Collections.Generic; //list
using System;
using System.Collections; //stack
namespace OOP_in_Csharp

{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        private bool _switchedOn;
        private static int _counter = 0;

        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
            _switchedOn = false;
            _counter++;

        }

        public Computer(string bn, string os)
        {
            _BIOSname = bn;
            _OS = os;
            _switchedOn = false;
            _counter++;
        }

        public Computer() 
        {
            _switchedOn = false;
            _counter++;
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
        
        public bool ON
        {
            get {return _switchedOn; }
            set {_switchedOn = value; }
        }
        
        static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }
        
        
        public static void StartComputer(List<Computer> network, string ip, string compName)
        {
            for (int i = 0; i< network.Count; i++)
            {
                if(network[i].BiosName == compName)
                {
                    network[i].ON = true;
                    network[i].IPAddress = ip;
                }
            }
        }
        
        
        public static List<string> getAdresses(List<string> ips, int N)
        {
            int count = 0;
            string piece = "";
            
            while(count < N)
            {
                piece = "10.0." + getNum() + "." + getNum();
                if(ips.Contains(piece) == false)
                {
                   ips.Add(piece);
                   count++;
                }
            }
            return ips;
        }
        
        
        public static void ShutDownComp(List<Computer> network, string compName)
        {
            for(int i=0; i <network.Count; i++)
            {
                if(network[i].BiosName == compName)
                {
                    network[i].ON = false;
                    string ipcovered = network[i].IPAddress;
                    network[i].IPAddress = "";
                    //ipcovered = network[i].IPAddress ;
                    //network.RemoveAt(i);
                    //Computer.setCounter()
                    //_counter--;
                }
            }
            //return ipcovered;
        }

        public static int getCompsOn(List<Computer> network)
        {
            int countON = 0;
            foreach(Computer c in network)
            {
                if(c.ON) countON++;
            }
            return countON;
        }

        public static void ShowComps(List<Computer> network)
        {
            for (int i = 0; i <network.Count; i++)
            {
                Console.WriteLine("{0} {1}", network[i].BiosName, network[i].IPAddress);
            }
        }



    }

  
    class Program
    {

        
        public static void Main(string[] args)
        {

            //Computer[] net = new Computer[4];
            List<Computer> net = new List <Computer>();
            const int allComps = 10;
            int onComps = 5;
            
            Console.WriteLine("\n avalaible IP adresses");
            List<string> ipadresses = new List<string>() ;
            ipadresses = Computer.getAdresses(ipadresses,allComps);
            
            /*foreach(string e in ipadresses)
            {
                Console.Writeline(e);
            }*/
            
            Stack ipsa = new Stack();
            foreach(string e in ipadresses)
            {
            ipsa.Push(e);    
            //Console.WriteLine(e);
            }
            
            Console.WriteLine("\nGenerating Computer instances");
            for (int i = 0; i < allComps; i++)
            {
                Computer comp = new Computer("comp" + i.ToString(), "Win10");
                net.Add(comp);
                Computer.StartComputer(net, ((string)ipsa.Pop()), comp.BiosName);
            }
            
            
            /*for (int i = 0; i < net.Count; i++)
            {
                Console.WriteLine("{0} {1}", net[i].BiosName, net[i].IPAddress);
            }*/
            
            Console.WriteLine("Switching off the computers");
            Computer.ShutDownComp(net,"comp4");
            Computer.ShowComps(net);
            Console.WriteLine("We have " + Computer.getCounter() + "computers in our network " + Computer.getCompsOn(net) + " are switched off");
            
            Console.WriteLine("Switching on the computers");
            Computer.StartComputer(net, (string)ipsa.Pop(), "comp1");
            Computer.ShowComps(net);

            Console.WriteLine("We have " + Computer.getCounter() + "computers in our network " + Computer.getCompsOn(net) + " are switched on");
            
            //-----------------------------------------------------------------------
            /*net[1].BiosName = "server 1";

            Console.WriteLine(net[1].BiosName);
            
            Computer special = new Computer();

            //---------------------------------------------------------------------------------------
            special.BiosName = "Raspberry.py";
            special.IPAddress = "12.12.12.44";

            Console.WriteLine(special.BiosName + " " + special.IPAddress);

            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");
            */
        }
    }
}

