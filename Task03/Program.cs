// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)
int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[] GenerateArray (int Length, int MinRange, int MaxRange)
{
    int [] arr = new int [Length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random(). Next(MinRange, MaxRange);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
}
int length = Prompt("Enter a length of array ");
int minValue = Prompt("Enter a min range ");
int maxValue = Prompt("Enter a max range ");
int[] array = GenerateArray (length, minValue, maxValue);
PrintArray(array);

