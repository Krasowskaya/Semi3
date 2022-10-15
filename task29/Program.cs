// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.WriteLine("Введите элементы массива: ");
string a = Convert.ToString(Console.ReadLine());
int[] array = new int[8];

for(int i = 0; i < 8; i++)
{
    //Console.WriteLine("Введите элемент массива:");
    array[i]= Convert.ToInt32(a[i].ToString());
    Console.Write(array[i] + " ");

}
