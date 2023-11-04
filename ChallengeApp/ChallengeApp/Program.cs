using ChallengeApp;

Console.WriteLine("Witaj w programie do oceny pracowników!");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

Employee employee1 = new Employee();
//List<Employee> employees = new List<Employee>(){};

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika lub zakończ (q): ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee1.AddGrade(input);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics1 = employee1.GetStatistics();
Console.WriteLine($"Statistics of: {employee1.Name} {employee1.Surname}");
Console.WriteLine($"Min. grade: {statistics1.Min}");
Console.WriteLine($"Max. grade: {statistics1.Max}");
Console.WriteLine($"Average grade: {statistics1.Average:N2}");
Console.WriteLine($"Final grade: {statistics1.AverageLetter}");