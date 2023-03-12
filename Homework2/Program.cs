//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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

