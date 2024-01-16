using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
        public class Employee
        {
            private string Employee_name;
            private int Ages;
            private double Employee_salary;
            public static int Employee_counter;
            private string position;

            public Employee(string name, int a, string position, double salary)
            {
                Employee_name = name;
                Ages = a;
                Position = position;
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

            public string EmployeeName
            {
                get { return Employee_name; }
                set { Employee_name = value; }
            }

            public virtual void getPromotion(double rise)
            {
                Employee_salary *= (1 + rise / 100);
            }

            public int EmployeeAges
            {
                get { return Ages; }
                set { Ages = value; }
            }

            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public double EmployeeSalary
            {
                get { return Employee_salary; }
                set { Employee_salary = value; }
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

    }

