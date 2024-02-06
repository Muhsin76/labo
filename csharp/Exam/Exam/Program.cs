namespace EXAM
{
    interface IStudent
    {
        void takeExam(int grade);
    }

    public class Student : IStudent
    {

        public Student(string name, int yearOfStudy, int studentGrade, bool passedExam)
        {
            this.name = name;
            this.yearOfStudy = yearOfStudy;
            this.studentGrade = studentGrade;
            this.passedExam = passedExam;
        }

        public Student(string name, int yearOfStudy, int studentGrade)
        {
            _name = name;
            _yearOfStudy = yearOfStudy;
            _studentGrade = studentGrade;
        }

        protected string _name;
        protected int _yearOfStudy;
        protected int _studentGrade;
        protected bool _passedExam;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int yearOfStudy
        {
            get { return _yearOfStudy; }
            set { _yearOfStudy = value; }
        }

        public int studentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }

        public bool  passedExam
        {
            get { return _passedExam; }
            set { _passedExam = value; }
        }

        public virtual void takeExam(int grade)
        {
            grade = _studentGrade;
            if (grade > 50 )
            {
                passedExam = true;
            }
            else
            {
                passedExam = false;
            }
        }

        public static void ShowStudents(List<Student> ListStudents)
        {
            foreach (Student student in ListStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.name, student.yearOfStudy, student.studentGrade);

            }
        }

    }
}


