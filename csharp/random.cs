//name and random ages
using System;

  public class Students
  {
    public string studentNames;
    public string studentAges;

    public Students (string sn, string sa)
    {
      studentNames = sn;
      studentAges = sa;
    }
  }
///one comment
//new comment
  class Class
  {

    static string getNum ()
    {
      Random random = new Random ();
      int num;
        num = random.Next (18,22);
        return num.ToString ();
    }
    public static void Main ()
    {

    Students[] group = new Students[4];
    string[] studentNames = {"Javier", "Muhsin", "Sinem", "Kadir"};

    for (int i = 0; i < group.Length; i++)
	{
	  group[i] = new Students (studentNames[i], getNum() );
	}

      for (int i = 0; i < group.Length; i++)
	{
	  Console.WriteLine ("{0} {1}", group[i].studentNames, group[i].studentAges);
	}

    }
  }




