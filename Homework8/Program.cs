// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] FillMatrixRandom(int row, int column)
{
    int[,] arr = new int[row,column];
    Random rnd = new Random(); // создаем объект класса (переменную типа Random)
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

// void RowStream(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int k = 0; k < arr.GetLength(1)-1; k++)
//         {
//             int max = arr[i,k];
//             for (int j = k+1; j < arr.GetLength(1); j++)
//             {
//                 if(arr[i,j] > max)
//                 {
//                     max = arr[i,j];
//                     arr[i,j] = arr[i,k];
//                     arr[i,k] = max;
//                 }
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixRandom(row,column);
// PrintMatrix(matrix);
// RowStream(matrix);
// Console.WriteLine();
// PrintMatrix(matrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void SumMinRow(int[,] arr)
{
    int k = 1;
    int[] array = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        array[i] = sum;
        Console.Write($"{array[i]} ");
    }
    int temp = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < temp)
        {
          k = i+1;
          temp = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов у {k} строки");
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixRandom(row,column);
PrintMatrix(matrix);
SumMinRow(matrix);
