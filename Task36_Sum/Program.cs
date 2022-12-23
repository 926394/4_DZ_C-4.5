// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] numbers = new int[4];
void Get1MassivNum(int[] num)
{
    for(int i =0; i < num.Length; i++)
    {
        num[i] = new Random().Next(-2, 5);
    }
}

void TheFinishNum(int[] coll)
{
    for(int index = 0; index < coll.Length; index ++)
    {
        Console.Write($"{coll[index]} ");
        
    } 
}

// TheFinishNum(numbers);
// Console.WriteLine();
Get1MassivNum(numbers);
TheFinishNum(numbers);
Console.WriteLine();


int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(i %2 !=0 || -i %2 !=0) count = count + numbers[i];
    
}
Console.Write($"Ответ: --> {count}   ");
Console.WriteLine();
Console.WriteLine();