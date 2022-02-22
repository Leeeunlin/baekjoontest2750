int txt = int.Parse(Console.ReadLine());

int[] fibo = new int[41];
fibo[0] = 0;
fibo[1] = 1;

for (int i = 2; i < 41; i++)
{
    Console.WriteLine( fibo[i] = fibo[i - 1] + fibo[i - 2]);
}

for (int i = 0; i < txt; i++)
{
    int N = int.Parse(Console.ReadLine());
    if (N == 0)
    {
        Console.WriteLine("1 0");
    }
    else
    {
        Console.WriteLine($"{fibo[N - 1]} {fibo[N]}");
    }
}