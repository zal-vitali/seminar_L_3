// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Для поиска расстояния между точками в пространстве 3D, введите их координаты:");
Console.Write("A(x): ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("A(y): ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("A(z): ");
int az = int.Parse(Console.ReadLine()!);

Console.WriteLine("");

Console.Write("B(x): ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("B(y): ");
int by = int.Parse(Console.ReadLine()!);
Console.Write("B(z): ");
int bz = int.Parse(Console.ReadLine()!);

double dx2 = Math.Pow(Convert.ToDouble(ax - bx), 2);
double dy2 = Math.Pow(Convert.ToDouble(ay - by), 2);
double dz2 = Math.Pow(Convert.ToDouble(az - bz), 2);

double result = Math.Round(Math.Sqrt(dx2 + dy2 + dz2), 2);

Console.WriteLine($"Расстояние между точками равно {result}");