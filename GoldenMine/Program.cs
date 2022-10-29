// See https://aka.ms/new-console-template for more information


int location = int.Parse(Console.ReadLine());
double extraction = 0.0;

for (int i = 0; i < location; i++)
{
    double avrExtraction = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    double sumExtraction = 0;
    for (int j = 0; j < days; j++)
    {
        extraction = double.Parse(Console.ReadLine());
        sumExtraction += extraction;
    }

    double avr = sumExtraction / days;
    if (avr >= avrExtraction)
    {
        Console.WriteLine($"Good job! Average gold per day: {avr:f2}.");
    }
    else
    {
        Console.WriteLine($"You need {avrExtraction - avr:f2} gold.");
    }
}