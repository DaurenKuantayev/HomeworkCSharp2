// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
  if (numberA == 6 || numberA == 7) 
  {
  Console.WriteLine($"{numberA} -> да");
  }
  else if (numberA < 1 || numberA > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine($"{numberA} -> нет");
  