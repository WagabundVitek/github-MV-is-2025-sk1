int x = 1;
int soucet = 0;
int soucin = 1;
while (x == 1)
{
    Console.WriteLine("Zadejte cislo:");
    string? cislo = Console.ReadLine();
    if (cislo == null)
{
    Console.WriteLine("Nebyl zadán žádný vstup!");
    continue;
}
    else if (int.TryParse(cislo, out int vstup))
    {
        for (int i = 0; i < cislo.Length; i++)
        {
            int cislice = cislo[i] - '0';
            Console.WriteLine($"Pozice {i + 1}: {cislice}");
            soucet += cislice;
            soucin *= cislice;
        }
        Console.WriteLine($"Soucet cifer je: {soucet}");
        Console.WriteLine($"Soucin cifer je: {soucin}");
            soucet = 0;
            soucin = 1;
        Console.WriteLine("Chcete pokracovat? (ano/ne)");
        string? pokracovat = Console.ReadLine();

        if (pokracovat == null || pokracovat.ToLower() != "ano")
        {
            break;
        }
        else
        {
            Console.Clear();
            continue;
        }
    }

    else
    {
        Console.Clear();
        Console.WriteLine("To neni cislo! Zkuste to znovu.");
        continue;
    }
         }