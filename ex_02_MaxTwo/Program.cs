Console.Write("a = ");
string inputa = Console.ReadLine();
int a = int.Parse(inputa);
Console.Write("b = ");
string inputb = Console.ReadLine();
int b = int.Parse(inputb);
if (a > b)
{
    Console.Write($"min = {b} ");
    Console.WriteLine($"max = {a}");
}
else if (b > a)
{
    Console.Write($"min = {a} ");
    Console.WriteLine($"max = {b}");
}