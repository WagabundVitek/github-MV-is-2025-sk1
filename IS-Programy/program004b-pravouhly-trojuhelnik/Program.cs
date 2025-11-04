// Vypíše úvodní zprávu programu
Console.WriteLine("Program pro vykreslení pravoúhlého trojúhelníku");

int height = 0;
bool isValidInput = false;


while (!isValidInput)
{
    Console.Write("Zadejte výšku trojúhelníku: "); // Požádá uživatele o zadání výšky trojúhelníku
    string? input = Console.ReadLine();

    // Kontrola prázdného vstupu
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Neplatný vstup! Zadejte prosím číslo.");
        continue;
    }


    if (int.TryParse(input, out height)) // Pokusí se převést vstup na číslo
    {
        if (height > 0)
        {
            isValidInput = true;
        }
        else
        {
            Console.WriteLine("Výška musí být větší než 0!");
        }
    }
    else
    {
        Console.WriteLine("Neplatný vstup! Zadejte prosím celé číslo.");
    }
}

Console.Clear();
Console.WriteLine($"Pravoúhlý trojúhelník s výškou: {height}"); 
Console.Write("┌"); // Vypíše levý horní roh
Console.WriteLine("┐");// Vykreslí horní vodorovnou čáru ┌┐

for (int i = 0; i < height - 2; i++)
{
    Console.Write("│"); // Levá svislá čára

    for (int j = 0; j < i; j++) // Mezery před šikmou čárou (obsah)
    {
        Console.Write(" ");
    }
    
    // Šikmá čára
    Console.Write("\\");
    
    Console.WriteLine();
}


Console.Write("└"); // Vykreslení levého spodního rohu
for (int i = 0; i < height - 2; i++) // Vykreslí spodní čáru
{
    Console.Write("─"); // Spodní čáta
}
Console.WriteLine("┘"); // Vykreslí pravý spodní roh
