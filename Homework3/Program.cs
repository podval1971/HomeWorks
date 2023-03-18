// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void FillArray(int[] collectoin) //ввод массива произвольной длинны
{
    int length = collectoin.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите следующий знак числа: ");
        collectoin[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
} 

void PrintArray(int[] col) //вывод массива произвольной длинны
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

void Palindrom(int[] collectoin)
{
    int count = collectoin.Length;
    int index = 0;
    while (index < count/2)
    {
        if(collectoin[index] != collectoin[count - index - 1]) 
        {
           Console.WriteLine("Число НЕ является палиндромом");
           return;
        }
        index++;
    }
    Console.WriteLine("Число является палиндромом");
}

Console.Write("Введите количество знаков в числе: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Palindrom(array);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(res, 2);
}

Console.Write("Input first X coordinat: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first Y coordinat: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first Z coordinat: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second X coordinat: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second Y coordinat: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second Z coordinat: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance = {distance}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=number; i++)
    Console.Write($"{Math.Pow(i, 3)} ");