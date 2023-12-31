﻿//The concepts of OOP in C#
using System;
using System.Net;
using System.Threading.Channels;
using System.Collections.Generic;
using System.Collections;
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
        //Properties
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
            get { return _switchedOn; }
            set { _switchedOn = value; }
        }

        //---------------------------------------

        static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }


        public static void StartComputer(List<Computer> network, string ip, string compName)
        {
            for (int i = 0; i < network.Count; i++)
            {
                if (network[i]._BIOSname == compName)
                {
                    network[i].ON = true;
                    network[i].IPAddress = ip;
                }
            }
        }

        public static void ShutDownComp(List<Computer> network, string compName)
        {
            for (int i = 0; i < network.Count; i++)
            {
                if (network[i]._BIOSname == compName)
                {
                    network[i].ON = false;
                    network[i].IPAddress = "";
                }
            }
        }

        public static void ShowComp(List<Computer> network)
        {
            for (int i = 0; i < network.Count; i++)
            {
                Console.WriteLine("{0} {1}", network[i].BiosName, network[i].IPAddress);
            }
        }

        public static int getCompsOn(List<Computer> network)
        {
            int countON = 0;
            foreach (Computer c in network)
            {
                if (c.ON) countON++;
            }
            return countON;
        }

        public static List<string> getAdresses(List<string> ips, int N)
        {
            int count = 0;
            string piece = "";

            while (count < N)
            {
                piece = "10.0." + getNum() + "." + getNum();

                if (ips.Contains(piece) == false)
                {
                    ips.Add(piece);
                    count++;
                }
            }
            return ips;
        }

        public static void Ping(List<Computer> network, string ip)
        {
            string pingIP = ip;
            StreamWriter logIn = File.AppendText("logIn.txt");

            for (int i = 0; i < network.Count; i++)
            {
                if (pingIP == network[i].IPAddress)
                {
                    logIn.WriteLine("It is done");
                    Console.WriteLine("Ping done " + getNum()+"ms");
                    return;
                }
            }
            Console.WriteLine("It was not possible to ping this IP");
        }
 }


    class Program
    {
        public static void Main(string[] args)
        {
            List<Computer> net = new List<Computer>();
            const int allComps = 10;
            int onComps = 5;


            Console.WriteLine("\nAvailable IP addresses:");
            List<string> ipaddresses = new List<string>();
            ipaddresses = Computer.getAdresses(ipaddresses, allComps);

            Stack ipsa = new Stack();
            foreach (string e in ipaddresses)
            {
                ipsa.Push(e);
                //Console.WriteLine(e);        
            }

          
            Console.WriteLine("\nGenerating Computer instances");
            for (int i = 0; i < onComps; i++)
            {
                Computer comp = new Computer("comp" + i.ToString(), "Win10");
                net.Add(comp);
                Computer.StartComputer(net, (string)ipsa.Pop(), comp.BiosName);
            }


            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

            Console.WriteLine("\nTurning off computer");
            Computer.ShutDownComp(net, "comp1");
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network and " + Computer.getCompsOn(net) + " on");

            Console.WriteLine("\nTurning on computer");
            Computer.StartComputer(net, (string)ipsa.Pop(), "comp1");
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network and " + Computer.getCompsOn(net) + " on");




            Console.WriteLine("Write the IP you want to do the ping: ");
            string pingIP = Console.ReadLine();


            Computer.Ping(net, pingIP);








            /*
            foreach(string e in ipaddresses)
            {
                Console.WriteLine(e);
            }

            */

            /*
            for (int i = 0; i < numComps; i++)
            {
            Computer comp = new Computer ("comp" + i.ToString(), "Win10");
            net.Add (comp);
            comp.StartComputer();
            }
            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

            Computer.ShutDownComp(net, "comp3");

            Computer.ShowComp(net);
            Console.WriteLine("We have " + Computer.getCounter() + " computers in our network");

            /*

            
            for (int i = 0; i < net.Count; i++)
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

                        //------------------------------------------------------------------------------------------
                        */




        }
    }
}
