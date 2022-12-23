// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int e = 0;
if (n >= 100)
{
    while (n > 999)
    {
        n = n / 10;
    }
    Console.WriteLine($"третья цифра фашего числа: {e = n % 10}");

}
else Console.WriteLine($"третьей цифры нет");