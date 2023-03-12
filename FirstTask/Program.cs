//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
Console.Write("Введите пятизначное число: ");
//int numbA = new Random().Next(10000, 100000); это я хотела чтобы не ручной ввод был, а рандомное число
int numbA = int.Parse(Console.ReadLine())!;
int x0 = numbA / 10000;
int x1 = numbA / 1000 % 10;
int x3 = numbA % 100 / 10;
int x4 = numbA % 10;
void Palindrome(int numbA)
{
  Console.WriteLine(numbA);
  if(x0 == x4 && x1 == x3)
    Console.WriteLine("Это палиндром");
  else
    Console.WriteLine("Это не палиндром");
}
Palindrome(numbA);
