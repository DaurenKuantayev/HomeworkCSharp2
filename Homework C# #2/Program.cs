// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int bufferNumb = number;

while (number > 1000)
    number = number / 10;
if (number < 100) 
    Console.WriteLine("В введеном числе нет третьей цифры");
else
{
    int thirdNumber = number % 10;
    Console.WriteLine($"Третье цифра чиcла {bufferNumb} - {thirdNumber}");
}