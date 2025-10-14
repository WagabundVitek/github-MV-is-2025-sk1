// See https://aka.ms/new-console-template for more information

bool x = 1
while (x = 1){
    Console.WriteLine("Zadejte cislo:");
string cislo = Console.ReadLine();

if (double.TryParse(cislo, out double cislo))
{

    Console.WriteLine()
}
else
{
    Console.WriteLine("To neni cislo! Pro opakovani stiskněte enter.");
    Console.ReadLine();
}
}