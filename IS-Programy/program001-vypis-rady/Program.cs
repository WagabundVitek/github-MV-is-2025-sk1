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

    Console.WriteLine();
    Console.WriteLine("Pro opakovani stisknete klavesu a.");
    again = Console.ReadLine();
}