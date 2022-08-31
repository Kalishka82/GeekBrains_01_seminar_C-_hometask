Console.Write("Input any integer number: ");
string number = Console.ReadLine();
int N = int.Parse(number);
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}