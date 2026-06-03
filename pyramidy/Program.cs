int i;
int mezera = 0;

Console.WriteLine("-----Pyramidy---- -");
Console.Write("Zadejte počet hvězd pro obrazec: ");
int.TryParse(Console.ReadLine(), out int pocet);
Console.WriteLine("");

// vstup: 5
// verze 1 //
// *
// **
// ***
// ****
// ***** // - 5 //
for (i = 1; i <= pocet; i++)
{
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
Console.WriteLine();
await Task.Delay(500);

// verze 2 //
// ***** // - 5 //
// ****
// ***
// **
// *
for (i = pocet; i >= 1; i--)
{
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
Console.WriteLine();
await Task.Delay(1000);

// verze 3 //
//     *
//    **
//   ***
//  ****
// ***** // - 5 //
for (i = 1; i <= pocet; i++)
{
    mezera = pocet - i;
    Console.Write(new string(' ', mezera));
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
Console.WriteLine();
await Task.Delay(500);

// verze 4 //
// ***** // - 5 //
//  ****
//   ***
//    **
//     *
for (i = pocet; i >= 1; i--)
{
    mezera = pocet - i;
    Console.Write(new string(' ', mezera));
    Console.WriteLine(new string('*', i));
    await Task.Delay(250);
}
await Task.Delay(1000);
Console.WriteLine();

// verze 5 //
//   *
//  ***
// ***** // - 5 //
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

// verze 6 //
// ***** // - 5 //
//  ***
//   *
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