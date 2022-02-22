List<int> xlist = new List<int>();
List<int> ylist = new List<int>();
int xreturn = 0;
int yreturn = 0;
for (int i = 0; i < 3; i++)
{
    string[] arr = Console.ReadLine().Split();
    xlist.Add(int.Parse(arr[0]));
    ylist.Add(int.Parse(arr[1]));
}

for (int i=0; i<3; i++) // x점 찾기
{
    int xpoint = 0;
    for (int j = 0; j < 3; j++)
    {
        if (xlist[i] == xlist[j])
        {
            xpoint++;
        }
        
    }
    if (xpoint == 1)
    {
        xreturn = xlist[i];
        break;
    }
}

for (int i = 0; i < 3; i++) // y점 찾기
{
    int ypoint = 0;
    for (int j = 0; j < 3; j++)
    {
        if (ylist[i] == ylist[j])
        {
            ypoint++;
        }

    }
    if (ypoint == 1)
    {
        yreturn = ylist[i];
        break;
    }
}

Console.WriteLine(xreturn +" "+ yreturn);