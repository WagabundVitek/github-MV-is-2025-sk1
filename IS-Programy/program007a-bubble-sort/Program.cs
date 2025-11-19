using System.Collections.Specialized;
using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("----------Generator pseudo-nahodných čísel----------");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("---------------------Bomboclatos--------------------");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte prvni cislo rady: ");
    //int prvni = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte pocet generovanych cisel (cele cislo)");
    Console.WriteLine();
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte pocet generovanych cisel znovu. ");
        Console.WriteLine();
    }

    Console.Write("Zadejte dolny mez rady cisel (cele cislo)");
    Console.WriteLine();
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte posledni cislo rady znovu. ");
        Console.WriteLine();
    }

    Console.Write("Zadejte horni mez rady cisel (cele cislo)");
    Console.WriteLine();
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound == 0)
    {
        Console.Write("Nezadali jste cele cislo nebo jste zadali cislo 0. Zadejte horni mez znovu. ");
        //vypis vstupnich hodnot
        Console.WriteLine();
        Console.WriteLine("########################################");
        Console.WriteLine("Zadane hodnoty");
        Console.WriteLine($"Pocet generovanych cisel: {n}");
        Console.WriteLine($"Dolni mez: {lowerBound}");
        Console.WriteLine($"Horni mez: {upperBound}");

    }
    int[] myRandnumbs = new int[n];
    Random myRandnumb = new Random();
    Console.WriteLine("########################################");
    Console.WriteLine("Pseudonahodna cisla");
    for (int i = 0; i < n; i++)
    {
        myRandnumbs[i] = myRandnumb.Next(lowerBound, upperBound + 1);
        Console.Write($"{myRandnumbs[i]} ");
    }

    Stopwatch myStopwatch = new Stopwatch();
    myStopwatch.Start();

    int compare = 0;
    int change = 0;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandnumbs[j] > myRandnumbs[j + 1])
            {
                int temp = myRandnumbs[j + 1];
                myRandnumbs[j + 1] = myRandnumbs[j];
                myRandnumbs[j] = temp;
                change++;
            }
        }
    }
    myStopwatch.Stop();
    Console.WriteLine();
    Console.WriteLine($"Seřazena čísla pomocí BubbleSort:");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{myRandnumbs[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine($"Cas řazení: {myStopwatch.ElapsedMilliseconds} ms");
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet prohození: {change}");



    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu a.");
    again = Console.ReadLine();
}
