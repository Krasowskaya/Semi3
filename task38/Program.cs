//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void InputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,100);
}


// double Maximum(double[] array)
// {
//     double max = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//         max = array[i];
//     }
//     return max;
// }

// double Minimum(double[] array)
// {
//     double min = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min)
//         min = array[i];
//     }
//     return min;
// }

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");

double max = array[0];
double min = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i]>max)
    {
    max = array[i];
    }
    if(array[i]<min)
    {
    min = array[i];
    }
}
Console.WriteLine(max - min);

//Console.WriteLine(Maximum(array));
//Console.WriteLine(Minimum(array));
//Console.WriteLine($"{Maximum(array)} - {Minimum(array)}");



