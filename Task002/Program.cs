﻿Console.WriteLine("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int souare = numberB * numberB;

if (numberA == souare)
{
 Console.WriteLine($"Число a = {numberA} явлется квадратом {souare} числа b = {numberB} ");   
}
else 
{
    Console.WriteLine($"Число a {numberA} НЕ явлется квадратом числа b = {numberB} ");   
}
