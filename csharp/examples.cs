using System;
class Program
{
    static string getNum ()
    {
      Random random = new Random ();
      int num;
        num = random.Next (1, 100);
        return num.ToString ();
    }
    static void Main()
    {
        /*double total = 0;
        Random random = new Random ();
        int[] ages = new int[5];
        
        for(int i = 0; i < ages.Length ; i++)
        {
        ages[i] = random.Next(1,100);
        total +=ages[i];
        Console.WriteLine(ages[i] + " ");
        }
        
        Console.Write("\nthe avarage" + total/5);*/
         
         string ipadress = "10.0." + getNum() + "." + getNum();
         Console.WriteLine(ipadress);
         
         
         
        
        /*int age = 21;
        float memory;
        memory = 20.5f;
        double storage = 30.5111;
        
        Console.WriteLine(memory/age);
        Console.WriteLine(storage/age);*/
        
        
    }
}

