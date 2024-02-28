Console.WriteLine("podaj rok: ");
int rok = int.Parse(Console.ReadLine());

int wynik = rok % 4;

if (wynik == 0)
{
    Console.WriteLine($"{rok} jest rokiem przestepnym");
}
else
{
    Console.WriteLine($"{rok} nie jest rokiem przestepnym");
}