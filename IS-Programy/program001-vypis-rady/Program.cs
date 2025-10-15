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
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte prvrni cislo rady znovu. ");
    }

    Console.Write("Zadejte posledni cislo rady (cele cislo)");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte posledni cislo rady znovu. ");
    }

    Console.Write("Zadejte diferenci (cele cislo)");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte diferenci znovu. ");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu a.");
    again = Console.ReadLine();
}