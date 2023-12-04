namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        List<float> grades = new List<float>();
        public EmployeeInMemory()
            : base() { }
        public EmployeeInMemory(string name, string surname)
            : base(name, surname) { }
        public EmployeeInMemory(string name, string surname, char sex, int age)
            : base(name, surname, sex, age) { }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                switch (charResult)
                {
                    case 'a':
                    case 'A':
                        AddGrade(100f);
                        break;
                    case 'b':
                    case 'B':
                        AddGrade(80f);
                        break;
                    case 'c':
                    case 'C':
                        AddGrade(60f);
                        break;
                    case 'd':
                    case 'D':
                        AddGrade(40f);
                        break;
                    case 'e':
                    case 'E':
                        AddGrade(20f);
                        break;
                    default:
                        throw new Exception("unexpected letter");
                }
            }
            else
            {
                throw new Exception("string is not float!");
            }
        }
        public override void AddGrade(double grade)
        {
            float gradeValue = (float)grade;
            AddGrade(gradeValue);
        }
        public override void AddGrade(int grade)
        {
            float gradeValue = (float)grade;
            AddGrade(gradeValue);
        }

        public override void AddGrade(long grade)
        {
            float gradeValue = (float)grade;
            AddGrade(gradeValue);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}

