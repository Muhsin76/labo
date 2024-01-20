//The concepts of OOP in C#
using System;
namespace OOP_in_Csharp
{
  public class Computer
  {
    public string _BIOSname;
    public string _ipadress;
    public string _OS;
    private static int _counter = 0;

    public Computer (string bn, string ip, string os)
    {
      _BIOSname = bn;
      _ipadress = ip;
      _OS = os;
      _counter++;
    }
    
    public Computer ()
    {
        _counter++;
    }
    
    public string BIOSname
    {
        get {return _BIOSname; }
        set {_BIOSname = value; } 
    }
    
    public string Ipadress
    {
        get{return _ipadress; }
        set{ _ipadress = value; }
    }
    
     
    public static int getCounter()
    {
        return _counter;
    }
 
  }
///one comment
//new comment
  class Program
  {

    static string getNum ()
    {
      Random random = new Random ();
      int num;
        num = random.Next (1, 255);
        return num.ToString ();
    }
    public static void Main (string[]args)
    {

      Computer[]net = new Computer[4];

      for (int i = 0; i < net.Length; i++)
	{
	  net[i] =
	    new Computer ("comp" + i.ToString (),
			  "10.0." + getNum () + "." + getNum (), "Win10");
	}

      for (int i = 0; i < net.Length; i++)
	{
	  Console.WriteLine ("{0} {1}", net[i].BIOSname, net[i].Ipadress);
	}
    
    net[1].BIOSname = "server";
    net[1].Ipadress = "10.0." + getNum() + "." + getNum();
    Console.WriteLine(net[1].BIOSname);
    
    Computer special = new Computer();
    
    special.BIOSname = "Raspberry PI";
    special.Ipadress = "12.12.12.44";
    Console.WriteLine(special.BIOSname+" "+special.Ipadress);
    Console.WriteLine("We have "+Computer.getCounter());
    }
  }
}

