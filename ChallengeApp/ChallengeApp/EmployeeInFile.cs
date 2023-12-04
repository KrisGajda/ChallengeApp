namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private const string fileName = "grades.txt";
        public EmployeeInFile()
            : base() { }
        public EmployeeInFile(string name, string surname)
            : base(name, surname) { }
        public EmployeeInFile(string name, string surname, char sex, int age)
            : base(name, surname, sex, age) { }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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
                throw new Exception("text is not a number!");
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
            var gradesFromFile = this.ReadGradesFromFile();
            foreach (var grade in gradesFromFile)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        grades.Add(float.Parse(line));
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
    }
}
