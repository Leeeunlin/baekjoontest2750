Console.WriteLine("변환할 문자열을 입력하세요");
char txt = Convert.ToChar(Console.ReadLine());
int ascii = Convert.ToInt32(txt);
Console.WriteLine("문자열" + txt + "를 ascii로 변환한 값은" + ascii +" 입니다.");