﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;


while(n >= 1)
{
    {
    int m = n % 10;
    sum = sum + m;
    }
n = n / 10;
}
Console.WriteLine(sum);