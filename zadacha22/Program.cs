// программа которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.Write("введите число : ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count <= N)
{
   // Concole.WriteLine(Math.Pow(count, 2));
    Console.WriteLine($"{Math.Pow(count, 2)}");
    count++;
}

//Console.Write("введите число : ");
//int N = int.Parse(Console.ReadLine());
//for(int I = 1; I<=N; I++)
//{
// if (I==N){Console.Write($"{Math.Pow(I, 2)}");}
// else Console.Write($"{Math.Pow(I, 2)}, ");
//}