int i;
int mezera = 0;

Console.WriteLine("-----Pyramidy---- -");
Console.Write("Zadejte počet hvězd pro obrazec: ");
int.TryParse(Console.ReadLine(), out int pocet);
Console.WriteLine("");

for (i = 1; i <= pocet; i++)
{
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
Console.WriteLine();
await Task.Delay(500);
for (i = pocet; i >= 1; i--)
{
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
Console.WriteLine();
await Task.Delay(1000);


for (i = 1; i <= pocet; i++)
{
    mezera = pocet - i;
    Console.Write(new string(' ', mezera));
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
Console.WriteLine();
await Task.Delay(500);

for (i = pocet; i >= 1; i--)
{
    mezera = pocet - i;
    Console.Write(new string(' ', mezera));
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
await Task.Delay(1000);
Console.WriteLine();



mezera = mezera / 2;
for (i = 1; i <= pocet; i = i+2)
{
    
    Console.Write(new string(' ', mezera));
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
    mezera--;
}
Console.WriteLine();
await Task.Delay(500);

if (pocet % 2 == 0)
{
    pocet = pocet - 1;
}
for (i = pocet; i >= 1; i= i-2)
{
    mezera++;
    Console.Write(new string(' ', mezera));
    Console.WriteLine(new string('*', i));
    
    await Task.Delay(250);
}