// программа которая принимает на вход  координаты точек x y, причем х не равен нулю и y не равен нулю
//  и выдает номер четверти в этой плоскости в которой находтся эта точка

Console.Write("Input x: ");

int x = int.Parse(Console.ReadLine());

Console.Write("Input y: ");

int y = int.Parse(Console.ReadLine());

int qwarter = 0;

if (x > 0)
{
    if (y > 0)
    {
        qwarter =1;
    }
    else
    {
            qwarter = 4;
    }
}
 else
    {
        if (y > 0 )
        {
        qwarter = 2;
        }
    else
        {
         qwarter = 3;
        }

    }

Console.WriteLine($"(X {x}, Y {y}) is {qwarter} qwarter!");