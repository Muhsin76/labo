using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    class Manager : Employee
    {
        public Manager(string department) : base ("Muhsin", 20, "Manager", 2000)
        {
            Department = department;
        }

        public string Department { get; set; }

        public override void getPromotion(double rise)
        {
            this.EmployeeSalary *= 10 + rise / 100;
        }
    }
}
