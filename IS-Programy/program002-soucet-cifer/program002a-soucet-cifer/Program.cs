using System.Collections.Specialized;
using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("------------------------------------");
    Console.WriteLine("------------Ciferny soucin----------");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("-------------Bomboclatos------------");
    Console.WriteLine();

   
    Console.Write("Zadejte cele cislo pro cifery soucet/soucin:");
    Console.WriteLine();
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte prvrni cislo rady znovu. ");
        Console.WriteLine();
    }
    int suma = 0;
    int numberbackup = number;
    int digit;
    if (number < 0)
    {
        number = -number; // odstraní znaménko mínus, pokud je číslo záporné   
    }
    while (number >= 10)
    {
        digit = number % 10; // zbytek po dělení určí poslední cifru
        number = (number - digit) / 10;
        Console.WriteLine("Digit: {0}", digit);
        suma += digit; // přičte cifru k součtu 

    }
    Console.WriteLine("Zbytek: {0}", number);
    // Nesmíme zapomenout přičíst poslední číslici do sumy

    suma += number; 
    Console.WriteLine("Soucet cifer cisla {0} je {1}", numberbackup, suma);



    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu a.");
    again = Console.ReadLine();
}