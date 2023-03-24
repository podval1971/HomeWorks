// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write("Введите следующий элемент массива: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(size);
// Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");

// int num = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//         num++;
// }
// Console.WriteLine($"Количество положительных элементов массива: {num}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2)
    {
     Console.WriteLine("Прямые параллельны");
     return;
    }

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({Math.Round(x, 2)};{Math.Round(y, 2)})");