﻿// удаление второй цифры в трехзначном числе
// 123 > 13
// 1.
//100 <= n <=999
// число вводит юзер
// как выводить результат 
// 2.
// 2.1.Метод который -ввод числа
// 2.2 Метод который -проверка числа на валидность
// 2.3. Метод который -отковырять вторую цифру !
// 2.4 Метод который -распечатать результат
// 2.5. Метод который -декаратор для вывода
// 3.
// ___
// abc = a*100 + b*10+ c*
// 456 = 4*100+5*10+6
// ac = a*10 +c
// деление целочисленное 14 div  5 =2  int / int = int
//          обычное      14 / 5 =2.8    double/int = double   double/double = double
//          деление с остатком 14 mod 5 =4  int % int = int
// abc = value
// a = value div 100
// b = value (value div 10) mod 10 
// c = value mod 10

// Метод который отковырять вторую цифру

int GetNumber(int value)
{
    int a = value / 100;
    int b = (value / 10) % 10; 
    int c = value % 10;

    return a * 10 + c;
}
    System.Console.WriteLine(GetNumber(176));



// 2.1.Метод который -ввод числа
int GetNumberFromUser()
{
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}
// 2.2 Метод который -проверка числа на валидность
// 2.3. Метод который -отковырять вторую цифру !
// 2.4 Метод который -распечатать результат
// 2.5. Метод который -декаратор для вывода