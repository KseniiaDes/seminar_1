﻿//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.Write($"Квадрат числа {number} равен {square}");

