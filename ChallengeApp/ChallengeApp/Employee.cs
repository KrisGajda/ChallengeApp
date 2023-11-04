using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Employee()
        {
            this.Name = "DefaultName";
            this.Surname = "DefaultSurname";
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
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

        public void AddGrade(char grade)
        {
            switch (grade)
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
                    throw new Exception("wrong letter");
            }
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
