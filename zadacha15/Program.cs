// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Input number: ");
int i = int.Parse(Console.ReadLine());

switch (i)
{
    case 1: Console.WriteLine ("Mon"); break;
    case 2: Console.WriteLine ("Tue"); break;
    case 3: Console.WriteLine ("Wed"); break;
    case 4: Console.WriteLine ("Thu"); break;
    case 5: Console.WriteLine ("Fri"); break;
    case 6: Console.WriteLine ("Sat"); break;
    case 7: Console.WriteLine ("Sun"); break;
    default: Console.WriteLine ("It's not a weak day"); break;
}

if (i >= 1 && i <= 5) 
 { 
     Console.Write(" Нет, это не выходной"); 
   } 
 
     else if (i >= 6 && i <= 7) 
        { 
          Console.Write(" Да, это выходной"); 
          } 
        else Console.Write(" Не существует такого дня недели");
