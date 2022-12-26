// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("введите точку координат х для точки А: ");
int xA = int.Parse(Console.ReadLine());

Console.Write("введите точку координат y для точки А: ");
int yA = int.Parse(Console.ReadLine());

Console.Write("введите точку координат х для точки B: ");
int xB = int.Parse(Console.ReadLine());

Console.Write("введите точку координат y для точки B: ");
int yB = int.Parse(Console.ReadLine());

Console.Write("введите точку координат z для точки A: ");
int zA = int.Parse(Console.ReadLine());

Console.Write("введите точку координат z для точки B: ");
int zB = int.Parse(Console.ReadLine());
double distance = 0;

distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));

Console.WriteLine(Math.Round(distance, 2));
