// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// void PrintNumber(int N)
// {
//     if(N == 0) return;
//     Console.Write($"{N} ");
//     PrintNumber(N-1);
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintNumber(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// int SumRec(int m, int n)
// {
//     if(n < m) return 0;
//     else return n + SumRec(m,n - 1);
// }

// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumRec(M,N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AkkermanFunc(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunc(M,N));
