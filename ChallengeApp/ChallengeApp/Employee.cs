namespace ChallengeApp
{
    public class Employee
    {
        List<int> grades = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Score { get; private set; }
        public void AddGrade(int grade)
        {
            this.grades.Add(grade);
            this.Score += grade;
        }
    }
}
