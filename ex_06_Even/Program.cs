int number = new Random().Next(-100, 100);
Console.WriteLine(number);
// Console.Write("number = ");
// string numberN = Console.ReadLine();
// int number = int.Parse(numberN);
if (number % 2 == 0)
{
    Console.WriteLine("yes");
}
else 
{
    Console.WriteLine("no");
}