// Задача 2: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.
int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Enter a number");

int Sum(int Number)
{
    
    
    int sumofdig = 0;
    while(num % 10 > 0)
    {
        sumofdig = sumofdig + num %10;
        num = num / 10;
        
        
    }
    return sumofdig;
    
}

int sum = Sum(num);
Console.WriteLine($"Sum of digit = {sum}");
