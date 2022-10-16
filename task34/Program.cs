// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();


void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,999);
}

int Even(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}

Console.WriteLine("Введите кол-во элементов массиvа: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join( ", ", array) + "]");
Console.WriteLine(Even(array));


