// программа которая принимает на вход координаты двух точек и находи расстояние между ними в 2d простр.

Console.Write("введите точку координат х для точки А: ");
int xA = int.Parse(Console.ReadLine());

Console.Write("введите точку координат y для точки А: ");
int yA = int.Parse(Console.ReadLine());

Console.Write("введите точку координат х для точки B: ");
int xB = int.Parse(Console.ReadLine());

Console.Write("введите точку координат y для точки B: ");
int yB = int.Parse(Console.ReadLine());
double distance = 0;

// кв корень из ((xb - xa)2 + (yb - ya)2)

distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));

Console.WriteLine(Math.Round(distance, 3));