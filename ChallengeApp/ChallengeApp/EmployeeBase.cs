using System.Xml.Linq;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }
        public EmployeeBase(string name, string surname)
            : this(name, surname, '-', 0) { }
        public EmployeeBase()
            : this("NoName", "NoSurname", '-', 0) { }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private char sex;
        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value == 'K' || value == 'M' || value == '-')
                    sex = value;
                else
                {
                    throw new Exception("Podaj płeć \"K\" (kobieta) lub \"M\" (mężczyzna) lub \"-\"");
                }
            }
        }
        public int Age { get; protected set; }
        public float Score { get; protected set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(long grade);
        public abstract Statistics GetStatistics();
    }
}
