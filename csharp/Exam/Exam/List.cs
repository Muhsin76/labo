using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXAM;

namespace EXAM
{
    class List
    {
        public static void Main(string[] args)
        {
            List<Student> ListStudents = new List<Student>();
            Student student1 = new Student("Javier", 2, 75);
            Student student2 = new Student("Muhsin", 3, 45);
            Student student3 = new Student("John", 3, 75);
            Student student4 = new Student("Hasan", 1, 35);

            Graduate student5 = new Graduate(true,"Alice", 4, 90);
            Graduate student6 = new Graduate(true, "Roman", 4, 90);


            ListStudents.Add(student1);
            ListStudents.Add(student2);
            ListStudents.Add(student3);
            ListStudents.Add(student4);
            ListStudents.Add(student5);
            ListStudents.Add(student6);

            Student.ShowStudents(ListStudents);


            Console.WriteLine("These are graduated:");
            student1.takeExam(75);
            student2.takeExam(45);
            student3.takeExam(75);
            student4.takeExam(35);
            student5.takeExam(90);
            student6.takeExam(90);



            Console.WriteLine("\nAverage grade for all students:");
            int totalGrade = 0;
            foreach (Student student in ListStudents)
            {
                totalGrade += student.studentGrade;
            }
            double averageGrade = totalGrade / (double)ListStudents.Count;
            Console.WriteLine(averageGrade);


        }
    }
}

