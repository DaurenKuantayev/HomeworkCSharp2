// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
  if (numberA == 6 || numberA == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (numberA < 1 || numberA > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
