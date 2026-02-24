using System.Drawing;
int mezera = 0;
int i;

Console.WriteLine("-----Pyramidy---- -");
Console.WriteLine("Zadejte počet hvězd pro obrazec:");
int.TryParse(Console.ReadLine(), out int pocet);
Console.WriteLine("");

for (i = 1; i <= pocet; i++)
{
    Console.WriteLine(new string('*', i));
    await Task.Delay(500);
}
Console.WriteLine();
await Task.Delay(1500);
for (i = pocet; i >= 1; i--)
{
    Console.WriteLine(new string('*', i));
    await Task.Delay(500);
}



for (i = 1; i <= pocet; i++)
{
    for (int j = 0; j < mezera; j++)
    {
        Console.Write(" ");
    }
    Console.Write(new string('*', i));
    await Task.Delay(500);
    mezera = pocet - 1;
}
Console.WriteLine();
await Task.Delay(1500);
for (i = pocet; i >= 1; i--)
{
    Console.Write(new string('*', i));
    await Task.Delay(500);
}