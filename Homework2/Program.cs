//Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    int second = (num / 10) % 10;
    return second;
}

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000) 
    Console.WriteLine($"The second digit in the number is {SecondDigit(number)}");
else
    Console.WriteLine("A number is NOT three-digit");
*/

//Task 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100) 
    Console.WriteLine("A number has NO Third digit");
else
    Console.WriteLine($"The third in the number is {ThirdDigit(number)}");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string WeekDay(int day)
{
    if(day == 6 || day == 7)
        return "This is a Weekend!";
    else
        return "This is a working day";
}

Console.Write("Enter the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 8)
    Console.WriteLine(WeekDay(number));
else
    Console.WriteLine("There are only seven days in a week, enter a value from 1 to 7");