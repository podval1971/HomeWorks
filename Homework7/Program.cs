// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] FillMatrixRandom(int row, int column)
{
    double[,] arr = new double[row,column];
    Random rnd = new Random(); // создаем объект класса (переменную типа Random)
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(0, 10) + Math.Round(rnd.NextDouble(), 2);
        }
    }
    return arr;
}

void PrintMatrix(double[,] array)
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

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillMatrixRandom(row,column);
PrintMatrix(matrix);

// 