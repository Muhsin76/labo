using System;
using System.Collections.Generic;
namespace ClassEmployee
{
    class Program
    {
        public static void Main()
        {
            //string name;
            //double salary;
            double totalSalary = 0;
            double maxSalary = 0;
            Employee[] company = new Employee[4];
            company[0] = new Employee("Bob", 30, "Manager", 2000);
            company[1] = new Employee("John", 25, "Specialist", 1500);
            company[2] = new Employee("Adam", 32, "IT Accountant", 1000);
            company[3] = new Employee("Liz", 35, "IT Accountant", 1000);


            Console.WriteLine("Name   Age   Salary");
            for (int i = 0; i < company.Length; i++)
            {
                totalSalary += company[i].EmployeeSalary;

                if (maxSalary < company[i].EmployeeSalary)
                {
                    maxSalary = company[i].EmployeeSalary;
                }

                Console.WriteLine("{0} {1} {2} {3}", company[i].EmployeeName, company[i].Position, company[i].EmployeeAges, company[i].EmployeeSalary);
            }

            double averageSalary = totalSalary / company.Length;
            Console.WriteLine("Average Salary: " + averageSalary);

            Console.WriteLine("Max Salary is:" + maxSalary);

            double promotionPercentage = 10;
            //  Console.WriteLine("{0} Salary after promotion is: {1} ", company[0].EmployeeName, company[0].getPromotion(promotionPercentage));

            /*
            Console.WriteLine("Enter the promotion percentage:");
        
            Console.WriteLine("We have "+Employee.getCounter());
        }

        static int getAge()
        {
            Random random = new Random();
            return random.Next(18, 60);
        }*/

            Manager manager = new Manager("sells");
            Console.WriteLine("\n");

            Console.WriteLine(manager.EmployeeName + "" + manager.EmployeeSalary);
            manager.getPromotion(20);

            Console.WriteLine(manager.EmployeeSalary);
        }
    }
}


