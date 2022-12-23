// удаление второй цифры в трехзначном числе
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
// -214: Abs(-214) = 214 --> 24
//
//

// Метод который отковырять вторую цифру

int GetNumber(int value)
{
    int a = value / 100;
    int b = (value / 10) % 10; 
    int c = value % 10;

    return a * 10 + c;
}
    

// 2.1.Метод который -ввод числа

int GetNumberFromUser()
{
    Console.Write("Введите число от 100 до 999: ");
    int temp = int.Parse(Console.ReadLine()!);
    return temp;
}
// 2.2 Метод который -проверка числа на валидность
bool IsValid(int number)
 
{
    return number >= 100 && number <= 999;
    //if (number >= 100)
    //{
     //   if (number <= 999); (можно так или как выше)
     //   {
     //       return true;
       // }

   // }
   // return false; 
}
// 2.3. Метод который -отковырять вторую цифру !
// 2.4 Метод который -распечатать результат

string GetText(int input, int output)
{
    return input + " --> " + output;
}
// 2.5. Метод который -декаратор для вывода

string Decorator(string text)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    return text;
}

int value = GetNumberFromUser();
if (IsValid(value))
{
    int result = GetNumber(value);
    System.Console.WriteLine(Decorator(GetText(value, result)));
}
else
{
    System.Console.WriteLine("число кривое");
}