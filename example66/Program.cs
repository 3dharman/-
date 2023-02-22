// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите значение числа M: ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение числа N: ");
int N = Convert.ToInt32(Console.ReadLine()); 

int SumNaturalElements(int M, int N)
{
    if (M == N) return N;     
    return N += SumNaturalElements(M, N - 1);
}

Console.Write($"M = {M}; N = {N} -> {SumNaturalElements(M, N)}");