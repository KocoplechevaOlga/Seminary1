﻿// 1. принимает на вход трёхзначное число
// 2. выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
int lastDigit = number % 10;
Console.WriteLine($"Последняя цифра числа = {lastDigit}");
}
else Console.WriteLine("Вы ввели не трёхзначное число!");