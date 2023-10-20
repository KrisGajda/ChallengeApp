using ChallengeApp;

Employee user1 = new Employee("Jan", "Kowalski", 36);
Employee user2 = new Employee("Adam", "Mickiewicz", 59);
Employee user3 = new Employee("Andrzej", "Nowak", 23);
List<Employee> employees = new List<Employee>(){
    user1,
    user2,
    user3
};

user1.AddGrade(1);
user1.AddGrade(2);
user1.AddGrade(3);
user1.AddGrade(2);
user1.AddGrade(5);

user2.AddGrade(2);
user2.AddGrade(8);
user2.AddGrade(2);
user2.AddGrade(8);
user2.AddGrade(10);

user3.AddGrade(3);
user3.AddGrade(7);
user3.AddGrade(7);
user3.AddGrade(9);
user3.AddGrade(3);

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (Employee employee in employees)
{
    if (employee.Score > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Score;
    }
}
Console.WriteLine("The best employee is: ");
Console.Write(employeeWithMaxResult.Name);
Console.Write($" {employeeWithMaxResult.Surname}: ");
Console.Write($"{employeeWithMaxResult.Score} pts");