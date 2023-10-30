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
                Console.WriteLine($"Invalid grade value: {grade}. Value not added.");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("String is not float!");
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
            string stringGrade = Char.ToString(grade);
            AddGrade(stringGrade);
        }

        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;
            for (var i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;
            var i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            } while (i < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;       
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;
            var i = 0;
            while (i < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

    }
}
