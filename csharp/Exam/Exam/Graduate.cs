using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace EXAM
{
    class Graduate : Student
    {
        protected bool _isGraduate;

        public Graduate(bool isGraduate, string name, int yearOfStudy, int studentGrade) : base(name, yearOfStudy, studentGrade) 
        {
            this.isGraduate = isGraduate;
        }

        public virtual void takeExam(int grade)
        {   
            studentGrade = grade;
            if (yearOfStudy == 4)
            {   
                if ( grade > 50 )
                { 
                    isGraduate = true;
                    Console.WriteLine("{0} {1} is graduated", name,studentGrade);
                }   

                else 
                {
                    isGraduate = false;
                    Console.WriteLine("{0} {1} {2} You have to study again", name, yearOfStudy, studentGrade);
                }

            }

        }



        public bool isGraduate
        {
            get { return _isGraduate; }
            set { _isGraduate = value; }
        }

    }
}


