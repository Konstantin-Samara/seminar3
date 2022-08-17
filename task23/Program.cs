// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N : ");
int Number = Convert.ToInt32(Console.ReadLine());
int Count = 1;
while (Count <= Number) {Console.WriteLine(Math.Pow(Count,3));
Count = Count+1;}
