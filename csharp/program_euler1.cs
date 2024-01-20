//Euler1
//Muhsin K. 2023-10-24

using System;
class Calculations
{
  static void Main ()
  {
    int result = 0;


    for (int m3 = 3; m3 < 1000; m3 += 3)
      {
	result += m3;
      }
 for(int m5 = 5 ; m5 < 1000 ; m5 +=5)
    {
       if(m5%3 != 0 )
       {
        result +=m5;
       }
    }      



    Console.WriteLine ("The total sum is " + result);
  }

}

