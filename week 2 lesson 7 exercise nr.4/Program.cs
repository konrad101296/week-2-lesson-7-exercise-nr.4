Console.WriteLine("podaj rok: ");
int year = int.Parse(Console.ReadLine());

int result = year % 4;
int result2 = year % 100;
int result3 = year % 400;
if (result2 == 0 && result3 != 0)
{
    Console.WriteLine($"{year} is not a leap year");
}
else if (result == 0)
{
    Console.WriteLine($"{year} is a leap year");
}
else
{
    Console.WriteLine($"{year} is not a leap year");
}
