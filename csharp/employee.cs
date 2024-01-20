//name and random ages
using System;

  public class Employee
  {
    public string Employee_name;
    public int Ages;

    public Employee (string name, int a)
    {
      Employee_name = name;
      Ages = a;
    }
  }
///one comment
//new comment
  class Program
  {
    public static string name;
    static int getAge ()
    {
      Random random = new Random ();
      int age;
        age = random.Next (18,60);
        return age;
    }
    public static void Main ()
    {
    string name;
    Employee[] company = new Employee[4];

    for (int i = 0; i < company.Length; i++)
	{
	  Console.WriteLine("Enter employees");
	  name=Console.ReadLine();
	  company[i] = new Employee (name, getAge() );
	}

      for (int i = 0; i < company.Length; i++)
	{
	  Console.WriteLine ("{0} {1}", company[i].Employee_name, company[i].Ages);
	}

    }
  }




