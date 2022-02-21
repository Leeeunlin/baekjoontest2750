string txt = Console.ReadLine();
int i = int.Parse(txt);

int count = 0;
int sum = 0;

while (i > sum) // 대각선 계산
{
    count++;
    sum += count;
}

int arr = i - (sum - count); // 줄 계산

if (count % 2 == 1) // 홀수일때
{
    Console.Write($"{count - arr + 1}/{arr}");
}
else // 짝수일때
{
    Console.Write($"{arr}/{count - arr + 1}");
}