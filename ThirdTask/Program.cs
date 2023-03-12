//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void Method(int N)
{
    int i = 1;
    while(N>=i)
    {
        Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
int MyN = int.Parse(Console.ReadLine()!);
Method(MyN);