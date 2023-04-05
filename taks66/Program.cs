// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SumNumber(int m, int n)
{
    if(m == n)
        return m;
    return m += SumNumber(m + 1,n);
    
}
Console.Clear();
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());
int resalt = SumNumber(numberM,numberN);
Console.WriteLine(resalt);