// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// double sum = 1;
// for(int i=1; i<=degree; i++)
//     sum = sum * number;
    
// Console.WriteLine($"Число {number} в степени {degree} равно {sum}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int DigitsSum(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num%10;
//         num = num/10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма цифр числа {number} равна {DigitsSum(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите следующий элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(" ", array)}]");