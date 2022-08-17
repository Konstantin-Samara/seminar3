// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату т.А по оси Х : ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату т.А по оси Y : ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату т.А по оси Z : ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату т.B по оси Х : ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату т.B по оси Y : ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату т.B по оси Z : ");
int bz = Convert.ToInt32(Console.ReadLine());
double Track = Math.Sqrt(Math.Pow((bx-ax),2)+Math.Pow((by-ay),2)+Math.Pow((bz-az),2));
Console.WriteLine($"Расстояние -  {Track:f2}");
