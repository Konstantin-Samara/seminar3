// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Write("Введите пятизначное число :  ");
int OriginNumber = Convert.ToInt32(Console.ReadLine());
int Number = Math.Abs(OriginNumber);
if (Number>9999 && Number<100000) {    
     if (Number/10000==Number%10 && Number/1000%10 == Number/10%10) 
     {Console.WriteLine($"число {OriginNumber} палиндром");}
     else {Console.WriteLine($"число {OriginNumber} не палиндром");}
    }       
else Console.WriteLine($"введенное число  {OriginNumber} не пятизначное");