namespace ChallengeApp
{
    public class Employee : Person
    {
        List<float> grades = new List<float>();
        public Employee(string name, string surname, char sex, int age)
            : base(name, surname)
        {
            this.Sex = sex;
            this.Age = age;
        }
        public Employee(string name, string surname)
            : this(name, surname, '-', 0){}
        public Employee()
            : this("NoName", "NoSurname", '-', 0){}
        private char sex;
        public char Sex 
        {
            get
            {
                return sex;
            }
            set
            {
                if (value == 'K' || value == 'M')
                    sex = value;
                else if (value =='-')
                    sex = value;
                else
                {
                    throw new Exception("Podaj płeć \"K\" (kobieta) lub \"M\" (mężczyzna) lub \"-\"");
                }
            }
        }
        public int Age { get; private set; }
        public float Score { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                this.Score += grade;
            }
            else
            {
                throw new Exception($"invalid grade value: {grade}. Value not added.");
            }
        }

        public void AddGrade(string grade)

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
                        AddGrade(100);
                        break;
                    case 'b':
                    case 'B':
                        AddGrade(80);
                        break;
                    case 'c':
                    case 'C':
                        AddGrade(60);
                        break;
                    case 'd':
                    case 'D':
                        AddGrade(40);
                        break;
                    case 'e':
                    case 'E':
                        AddGrade(20);
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

        public void AddGrade(double grade)
        {
            float gradeValue = (float)grade;
            AddGrade(gradeValue);
        }

        public void AddGrade(int grade)
        {
            float gradeValue = (float)grade;
            AddGrade(gradeValue);
        }

        public void AddGrade(long grade)
        {
            float gradeValue = (float)grade;
            AddGrade(gradeValue);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
