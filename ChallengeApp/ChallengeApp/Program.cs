var name = "Marta";
char sex = 'k';
var age = 17;

if (sex == 'm' || sex == 'M')
{
    if (age < 18)
    {
        Console.WriteLine($"Niepełnoletni mężczyzna o imieniu {name}.");
    }
    else
    {
        Console.WriteLine($"{name}, mężczyzna lat {age}.");
    }
}
else if (sex == 'k' || sex == 'K')
{
    if (age < 18)
    {
        Console.WriteLine($"Niepełnoletnia kobieta o imieniu {name}.");
    }
    else
    {
        Console.WriteLine($"{name}, kobieta lat {age}.");
    }
}