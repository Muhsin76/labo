using System;

public class Employee
{
    private string Employee_name;
    private int Ages;
    private double Employee_salary;
    public static int Employee_counter;
    private string position;
    
    public Employee(string name, int a, double salary)
    {
        Employee_name = name;
        Ages = a;
        Employee_salary = salary;
        Employee_counter++;
    }
    
     public Employee(string name, string ps)
    {
        Employee_name = name;
        Position = ps;
       
    }
    
    public Employee()
    {
        Employee_counter++;
    }
    
    public double getPromotion(double rise)
    {
        Employee_salary *= (1 + rise / 100);
        return Employee_salary;
    }
    
     public string EmployeeName
    {
        get{return Employee_name;}
        set {Employee_name = value; }
    }
    
    public int EmployeeAges
    {
        get{return Ages;}
        set{Ages = value;}
    }
    
    public string Position{
        get{ return position; }
        set{ position = value; }        
    }
    
    public double EmployeeSalary
    {
        get{return Employee_salary;}
        set {Employee_salary = value; }
    }
    
    public static int getCounter()
    {
        return Employee_counter;
    }
    
    public void Hire(double Salary)
    {
        Employee_salary = Salary;
        Employee_counter++;
    }
}
    

class Program
{
    public static void Main()
    {
        string name;
        double salary;
        double totalSalary = 0; 
        double maxSalary = 0;
        Employee[] company = new Employee[4];

        for (int i = 0; i < company.Length; i++)
        {
            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter employee salary:");
            salary = Convert.ToDouble(Console.ReadLine());
            
            totalSalary += salary; 
            company[i] = new Employee(name);
            company[i].Hire(salary);
            
            if (maxSalary < company[i].EmployeeSalary)
            {
                maxSalary = company[i].EmployeeSalary;
            }
        }

        Console.WriteLine("Name Age Salary");
        for (int i = 0; i < company.Length; i++)
        {
            Console.WriteLine("{0} {1} {2}", company[i].EmployeeName, company[i].EmployeeAges, company[i].EmployeeSalary);
        }

        double averageSalary = totalSalary / company.Length; 
        Console.WriteLine("Average Salary: " + averageSalary);
        Console.WriteLine("Max Salary is:" + maxSalary);
        
        Console.WriteLine("Enter the promotion percentage:");
        double promotionPercentage = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Salary after promotion is: " + company[0].getPromotion(promotionPercentage));
        
        Console.WriteLine("We have "+Employee.getCounter());
    }

    static int getAge()
    {
        Random random = new Random();
        return random.Next(18, 60);
    }
}








