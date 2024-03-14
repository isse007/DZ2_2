// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

void FindKoordinates (int x, int y)
{
    if (x>0 && y>0)
    {
    Console.Write ($"Координата расположена в I плоскости (X;Y)");
    }
    if (x<0 && y>0)
    {
    Console.Write ($"Координата расположена в II плоскости (-X; Y)");
    }
    if (x<0 && y<0)
    {
    Console.Write ($"Координата расположена в III плоскости (-X;-Y)");
    }
    if (x>0 && y<0)
    {
    Console.Write ($"Координата расположена в IV плоскости (X;-Y)");
    }
}
System.Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32 (Console.ReadLine());
FindKoordinates(x,y);
