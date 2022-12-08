// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int [] Array = new int[Length];
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(minRange, maxRange + 1);
        
    }
    return Array;
}

void PrintArray(int [] array)
{
     for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}

int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int secMaxValue(int [] array)
{
    int secmax = array[0];
    int max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
            
        }
    }
    for(int i = 1; i < array.Length; i++)
    {
        if(max == array[i])
        {
            continue;
        }
        if(secmax < array[i])
        {
            secmax = array[i];
        }
        
    }
    return secmax;
}

int length = Prompt("Enter a length of array");
int minValue = Prompt("Enter a min range of array");
int maxValue = Prompt("Enter a max range of array");

int []array = GenerateArray(length, minValue, maxValue);

PrintArray(array);
Console.WriteLine($"second maximum value is {secMaxValue(array)}");
    

