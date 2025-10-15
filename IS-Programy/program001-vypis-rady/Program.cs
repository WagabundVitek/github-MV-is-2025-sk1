using System.Collections.Specialized;
using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("------------------------------------");
    Console.WriteLine("----------Vypis rady cisel----------");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("-------------Bomboclatos------------");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte prvni cislo rady: ");
    //int prvni = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte prvni cislo rady (cele cislo)");
    Console.WriteLine();
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte prvrni cislo rady znovu. ");
        Console.WriteLine();
    }

    Console.Write("Zadejte posledni cislo rady (cele cislo)");
    Console.WriteLine();
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte posledni cislo rady znovu. ");
        Console.WriteLine();
    }

    Console.Write("Zadejte diferenci (cele cislo)");
    Console.WriteLine();
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step == 0)
    {
        Console.Write("Nezadali jste cele cislo nebo jste zadali cislo 0. Zadejte diferenci znovu. ");
        Console.WriteLine();
    }

    //vypis vstupnich hodnot
    Console.WriteLine();
    Console.WriteLine("############################");
    Console.WriteLine("Zadaji jste tyto hodnoty:");
    Console.WriteLine($"Prvni cislo rady:{first}");
    Console.WriteLine($"Posledni cislo rady:{last}");
    Console.WriteLine($"Diference:{step}");
    Console.WriteLine($"###########################");
    Console.WriteLine("Prvni cislo: {0}, Posledni cislo: {1}, Diference: {2}", first, last, step);

    // výpis číselné řady
    int current = first;
    while (current <= last)
    {
        Console.WriteLine(current);
        current += step; // přičtení diference k aktuálnímu číslu
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu a.");
    again = Console.ReadLine();
}