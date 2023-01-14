// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//* A (3,6,8); B (2,1,-7), -> 15.84
//* A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

string str;
int x1, y1, z1 , x2, y2, z2;

Console.Clear();
Console.WriteLine("Введите координаты точки A вплоскости x: ");
str = Console.ReadLine();
x1 = Convert.ToInt32(str);

System.Console.WriteLine("Введите координаты точки A вплоскости y: ");
str = Console.ReadLine();
y1 = Convert.ToInt32(str);

System.Console.WriteLine("Введите координаты точки A вплоскости z: ");
str = Console.ReadLine();
z1 = Convert.ToInt32(str);

System.Console.WriteLine("Введите координаты точки B вплоскости x: ");
str = Console.ReadLine();
x2 = Convert.ToInt32(str);

System.Console.WriteLine("Введите координаты точки B в плоскости y: ");
str = Console.ReadLine();
y2 = Convert.ToInt32(str);

System.Console.WriteLine("Введите координаты точки B вплоскости z: ");
str = Console.ReadLine();
z2 = Convert.ToInt32(str);

Console.Clear();

double distance = Getdistans(x1, x2, y1, y2, z1, z2);
System.Console.WriteLine(distance);

double Getdistans(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
}
