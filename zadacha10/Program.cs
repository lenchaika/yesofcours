// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


    Console.Write("Введите трёхзначное число: ");

    if (int.TryParse(Console.ReadLine(), out int n))
    {
        if (n >= 100 && n < 1000)
        {
            int x = (n / 10) % 10;
            Console.Write($"Вторая цифра вашего числа {x}");
        }
        else{
            System.Console.WriteLine("Вы ввели не трехзначное число");
        }
    }

        else
        {
            System.Console.WriteLine("Вы ввели не число");
        }
        

   