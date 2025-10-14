int x = 1;
while (x == 1)
{
    Console.WriteLine("Zadejte cislo:");
    string cislo = Console.ReadLine();
    if (int.TryParse(cislo, out int vstup))
    {
        for (int i = 0; i < cislo.Length; i++)
        {
            int cislice = cislo[i] - '0';
            Console.WriteLine($"Pozice {i + 1}: {cislice}");
        }
    }

    else
    {
        Console.WriteLine("To neni cislo! Pro opakovani stiskněte enter.");
        Console.ReadLine();
    }
         }