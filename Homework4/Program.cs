// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

double sum = 1;
for(int i=1; i<=degree; i++)
    sum = sum * number;
    
Console.WriteLine($"Число {number} в степени {degree} равно {sum}");

