Console.Write("Input any integer number: ");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i = i + 2)
{
    Console.Write($"{i}, ");
}