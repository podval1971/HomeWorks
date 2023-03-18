// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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