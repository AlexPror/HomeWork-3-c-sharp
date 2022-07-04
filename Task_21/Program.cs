/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки А: ");
Console.Write("Xa: "); 
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: "); 
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Za: "); 
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
Console.Write("Xb: "); 
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: "); 
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: "); 
int zb = Convert.ToInt32(Console.ReadLine());

double Length (int x1, int y1, int x2, int y2, int z1, int z2)
{
    int X = x2 - x1;
    int Y = y2 - y1;
    int Z = z2 - z1;
    double result = Math.Sqrt(X*X + Y*Y + Z*Z);
    return Math.Round(result,2);
}
double length = Length (xb, xa, yb, ya, zb, za);
Console.WriteLine(length); 



