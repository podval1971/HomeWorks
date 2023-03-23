// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
Console.WriteLine($"Исходный массив: [{string.Join(" ", array)}]");

int num = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        num++;
}
Console.WriteLine($"Количество положительных элементов массива: {num}");

// 