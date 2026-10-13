using Exercise4;
using System.Globalization;
// OBS: Programmet använder amerikanska regioninställningar för att hantera
// decimaler med punkt (.) och visa valuta i dollar ($), oavsett datorns inställningar.

Console.WriteLine("Hello, World!");

void Part1_Main()
{
    var lines = 5;
    var persons = new List<PersonV1>();
    for (int i = 0; i < lines; i++)
    {
        var cmdArgs = Console.ReadLine().Split();
        var person = new PersonV1(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
        persons.Add(person);
    }
    persons.OrderBy(p => p.FirstName)
    .ThenBy(p => p.Age)
    .ToList()
    .ForEach(p => Console.WriteLine(p.ToString()));
}

// Behåller den ursprungliga strukturen i Main.
// Lägger till try-catch för valideringsfel och en-US för enhetligt tal- och valutaformat.
void Part2_Main()
{
    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US"); // se OBS högst upp i filen
    Console.WriteLine("Enter number of persons:");
    var lines = int.Parse(Console.ReadLine());
    var persons = new List<PersonV2>();
    for (int i = 0; i < lines; i++)
    {
        var cmdArgs = Console.ReadLine().Split();
        try
        {
            var person = new PersonV2(
                    cmdArgs[0], cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3])
                    );
            persons.Add(person);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    var bonus = decimal.Parse(Console.ReadLine());
    persons.ForEach(p => p.IncreaseSalary(bonus));
    persons.ForEach(p => Console.WriteLine(p.ToString()));

}

Part2_Main();