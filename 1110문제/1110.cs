string orgnum = Console.ReadLine();

int count = 0;
int addNum; // 10, 1의자리 계산값


if (10 > int.Parse(orgnum)) // 10보다 작으면 0을 붙임
{
    orgnum = orgnum + 0;
}
string originalNum = orgnum;

while (true)
{
    count++;
    int a = int.Parse(orgnum) / 10; // 10자리
    int b = int.Parse(orgnum) % 10; // 1자리
    addNum = a + b;
    Console.WriteLine(a + "+" + b + "=" + addNum);
    Console.WriteLine(count + " 회 반복");
    orgnum = b.ToString() + (addNum % 10).ToString();


    if (int.Parse(orgnum) == int.Parse(originalNum))
    {
        Console.WriteLine(count + " 회로 반복 종료");
        break;
    }
}
