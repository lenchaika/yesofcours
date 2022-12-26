// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.Write("введите число : ");
int N = int.Parse(Console.ReadLine());
for(int I = 1; I<=N; I++)
{
if (I==N){Console.Write($"{Math.Pow(I, 3)}");}
else Console.Write($"{Math.Pow(I, 3)}, ");
}
