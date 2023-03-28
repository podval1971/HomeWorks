// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] FillMatrixRandom(int row, int column)
// {
//     int[,] arr = new int[row,column];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = rnd.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

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
// int[,] FillMatrixRandom(int row, int column)
// {
//     int[,] arr = new int[row,column];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = rnd.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void SumMinRow(int[,] arr)
// {
//     int k = 1;
//     int[] array = new int[arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum += arr[i,j];
//         }
//         array[i] = sum;
//         Console.Write($"{array[i]} ");
//     }
//     int temp = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < temp)
//         {
//           k = i+1;
//           temp = array[i];
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Наименьшая сумма элементов у {k} строки");
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixRandom(row,column);
// PrintMatrix(matrix);
// SumMinRow(matrix);

// Задача 60. Сформируйте трёхмерный массив. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] FillTreeDimRandom(int x, int y, int z)
// {
//     int[,,] arr = new int[x,y,z];
//     Random rnd = new Random(); // создаем объект класса (переменную типа Random)
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                arr[i,j,k] = rnd.Next(0, 10);
//             }
//         }
//     }
//     return arr;
// }

// void PrintTreeDim(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]}({i},{j},{k})  ");
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите глубину трехмерного массива: ");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] matrix = FillTreeDimRandom(x,y,z);
// PrintTreeDim(matrix);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// int[,] FillMatrixSpiral(int row, int column)
// {
//     int[,] arr = new int[row,column];
//     int index = 1;
//     for (int j = 0; j < arr.GetLength(1); j++) // заполняем периметр, движемся вправо
//     {
//         arr[0,j] = index;
//         index++;
//     }
//     for (int i = 1; i < arr.GetLength(0); i++) // движемся вниз
//     {
//         arr[i,arr.GetLength(1)-1] = index;
//         index++;
//     }
//     for (int j = arr.GetLength(1)-2; j >= 0; j--) // движемся влево
//     {
//         arr[arr.GetLength(0)-1,j] = index;
//         index++;
//     }
//     for (int i = arr.GetLength(0)-2; i > 0; i--) // движемся вверх
//     {
//         arr[i,0] = index;
//         index++;
//     }

//     int x = 1; // заполняем серединку, координаты первой ячейки
//     int y = 1;
//     while (index < row * column)
//     {
//         while (arr[x,y+1] == 0) // движемся вправо
//         {
//             arr[x,y] = index;
//             index++;
//             y++;
//         }
//         while (arr[x+1,y] == 0) // движемся вниз
//         {
//             arr[x,y] = index;
//             index++;
//             x++;
//         }
//         while (arr[x,y-1] == 0) // движемся влево
//         {
//             arr[x,y] = index;
//             index++;
//             y--;
//         }
//         while (arr[x-1,y] == 0) // движемся вверх
//         {
//             arr[x,y] = index;
//             index++;
//             x--;
//         }
//     }
    
//     for (int i = 0; i < arr.GetLength(0); i++) // заполняем самый центр
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(arr[i,j] == 0) arr[i,j] = index;
//         }
//     }

//     return arr;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrixSpiral(row,column);
// PrintMatrix(matrix);

// Задача 59: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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

int[,] DeleteRowColumn(int[,] arr)
{
    int[,] arrNew = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int min = arr[0,0];
    int xmin = 0;
    int ymin = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if (arr[i,j] < min)
           {
                min = arr[i,j];
                xmin = i;
                ymin = j;
           }
        }
    }
    Console.WriteLine($"Минимальный элемент {arr[xmin,ymin]} [{xmin},{ymin}]");

    for (int i = 0; i < xmin; i++)  // 1 четверть
    {
        for (int j = 0; j < ymin; j++)
        {
            arrNew[i,j] = arr[i,j];
        }
    }
    for (int i = xmin; i < arr.GetLength(0)-1; i++)  // 2 четверть
    {
        for (int j = 0; j < ymin; j++)
        {
            arrNew[i,j] = arr[i+1,j];
        }
    }
    for (int i = 0; i < xmin; i++)  // 3 четверть
    {
        for (int j = ymin; j < arr.GetLength(1)-1; j++)
        {
            arrNew[i,j] = arr[i,j+1];
        }
    }
    for (int i = xmin; i < arr.GetLength(0)-1; i++)  // 4 четверть
    {
        for (int j = ymin; j < arr.GetLength(1)-1; j++)
        {
            arrNew[i,j] = arr[i+1,j+1];
        }
    }
    return arrNew;
}

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixRandom(row,column);
PrintMatrix(matrix);
int[,] matrixNew = DeleteRowColumn(matrix);
Console.WriteLine();
PrintMatrix(matrixNew);