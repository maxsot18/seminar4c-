// Задача 1: Напишите цикл, который 
// принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B. Реализовать через функции.

int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int A = Prompt("Enter number A");
int B = Prompt("Enter number B ");

int Degreeofb(int num)
{
   
   
   int deg = A;
   for(int i = 1; i < B; i++)
   {
    deg = deg * A;
   }
   return deg;
}




int degryofB = Degreeofb (A);
Console.Write(degryofB); 