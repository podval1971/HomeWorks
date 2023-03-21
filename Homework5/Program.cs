// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] FillArrayRandom(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(100, 1000);
//     }
//     return arr;
// }

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayRandom(size);

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
// Console.WriteLine($"Количество четных элементов: {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArrayRandom(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // создаем объект класса (переменную типа Random)
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayRandom(size);

int sum = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    sum = sum + array[i];
}

Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

// Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.

