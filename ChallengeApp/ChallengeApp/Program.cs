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

var statistics1 = employee1.GetStatisticsWithForEach();
Console.WriteLine($"Statistics of: {employee1.Name} {employee1.Surname}1");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

var statistics2 = employee1.GetStatisticsWithFor();
Console.WriteLine($"Statistics of: {employee1.Name} {employee1.Surname}2");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee1.GetStatisticsWithDoWhile();
Console.WriteLine($"Statistics of: {employee1.Name} {employee1.Surname}3");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

var statistics4 = employee1.GetStatisticsWithWhile();
Console.WriteLine($"Statistics of: {employee1.Name} {employee1.Surname}4");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4 .Max}");