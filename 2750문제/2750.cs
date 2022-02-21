Console.WriteLine("몇개의 수를 입력 하시겠습니까?");
int count = int.Parse(Console.ReadLine());
int[] arr = new int[count];

for (int i = 0; i < count; i++)
{
    Console.WriteLine("수를 입력 하세요.");
    arr[i] = int.Parse(Console.ReadLine());
}
Array.Sort(arr);
int[] arr2 = arr.Distinct().ToArray(); // 중복제거
for (int j = 0; j < arr2.Length; j++)
{
    Console.WriteLine(arr2[j]);
}