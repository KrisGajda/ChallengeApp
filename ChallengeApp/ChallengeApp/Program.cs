using ChallengeApp;

Employee employee1 = new Employee("Jan", "Kowalski");
Employee employee2 = new Employee("Adam", "Mickiewicz");
Employee employee3 = new Employee("Andrzej", "Nowak");
List<Employee> employees = new List<Employee>(){
    employee1,
};

employee1.AddGrade(1.2);
employee1.AddGrade('2');
employee1.AddGrade(300);
employee1.AddGrade(2);
employee1.AddGrade(9.8f);

var statistics1 = employee1.GetStatistics();

Console.WriteLine($"Statistics of: {employee1.Name} {employee1.Surname}");
Console.WriteLine($"Average: {statistics1.Average:2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

