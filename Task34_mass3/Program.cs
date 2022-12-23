// Оформляем всё в методы!
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int minVaiue, int maxVaiue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVaiue, maxVaiue + 1);
        // Console.Write($"{res[i]} ");

    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    // int i = 4;
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArray(7, 100, 1000); // -это заданый массив 

PrintArray(array);
Console.WriteLine();
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++; 
    } 
}
Console.Write($"Ответ в массиве: --> {count}  четных чисел(а) ");