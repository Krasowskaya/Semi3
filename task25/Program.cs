// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( b >= 0);
     int m = Convert.ToInt32(Math.Pow(a,b));
Console.WriteLine(m);