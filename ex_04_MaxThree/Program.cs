Console.Write("a = ");
string inputa = Console.ReadLine();
int a = int.Parse(inputa);
Console.Write("b = ");
string inputb = Console.ReadLine();
int b = int.Parse(inputb);
Console.Write("c = ");
string inputc = Console.ReadLine();
int c = int.Parse(inputc);
// int a = new Random().Next(0, 100);
// Console.WriteLine(a);
// int b = new Random().Next(0, 100);
// Console.WriteLine(b);
// int c = new Random().Next(0, 100);
// Console.WriteLine(c);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");