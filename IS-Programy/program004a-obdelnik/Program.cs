Console.WriteLine("Program pro vykreslení obdélníku");

Console.Write("Zadejte šířku obdélníku: ");
int width = int.Parse(Console.ReadLine());

Console.Write("Zadejte výšku obdélníku: ");
int height = int.Parse(Console.ReadLine());

Console.Write("┌"); //  Vypíše levý horní roh

for (int i = 0; i < width; i++)
{
    
    Console.Write("─");
}
Console.WriteLine("┐"); //  Vypíše pravý horní roh

for (int i = 0; i < height; i++)
{
    Console.Write("│"); // výška levá
    for (int j = 0; j < width; j++) //  vyplní střed mezerami podle zadané šířky
    {
        Console.Write(" ");
    }
    Console.WriteLine("│"); // Zakončí řádek svislou čarou
}

Console.Write("└"); //  levý dolní roh
for (int i = 0; i < width; i++)// Opakuje vodorovné čáry podle zadané šířky
{
    Console.Write("─");
}
Console.WriteLine("┘"); // pravý dolní roh
