// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numbers = new double[10];
void Get1MassivNum(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 15);
    }
}

void TheFinishNum(double[] coll)
{
    for (int index = 0; index < coll.Length; index++)
    {
        Console.Write($"{coll[index]} ");

    }
}


Get1MassivNum(numbers);
Console.WriteLine();
TheFinishNum(numbers);
Console.WriteLine();

void MinMaxNumSum(double[] numbers)
{
    int indexmix = 0;
    int indexmax = 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] <= numbers[indexmix])  indexmix = i;

        if (numbers[i] >= numbers[indexmax]) indexmax = i;
        
    }
    Console.Write($"Ответ: --> {numbers[indexmix]}  {numbers[indexmax]} ");
    

    double sum = 0;
    
    if (indexmix < indexmax)
        {
            sum = numbers[indexmax] - numbers[indexmix];
            // Console.Write($"Ответ: mas --> {sum}");
        }
    if (indexmix > indexmax)
        {
            sum = numbers[indexmax] - numbers[indexmix];
            // Console.Write($"Ответ: fa --> {sum} ");
        }    

    Console.Write($"Ответ sum: --> {sum} ");
}

MinMaxNumSum(numbers);
Console.WriteLine();
