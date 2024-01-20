//The concepts of OOP in C#
using System;
namespace OOP_in_Csharp
{
  public class Computer
  {
    public string _BIOSname;
    public string _ipadress;
    public string _OS;

    public Computer (string bn, string ip, string os)
    {
      _BIOSname = bn;
      _ipadress = ip;
      _OS = os;
    }
    
    public string getBIOSname()
    {
        return _BIOSname;
    }
    
    public string getIpadress()
    {
        return _ipadress;
    }
    
     public void setBIOSname(string bn)
    {
        _BIOSname = bn;
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
	  Console.WriteLine ("{0} {1}", net[i].getBIOSname(), net[i].getIpadress());
	}
    
    net[1].setBIOSname("server");
    Console.WriteLine(net[1].getIpadress());
    
    }
  }
}
