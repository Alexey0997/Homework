﻿// Задача 10: Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цыфру этого числа. 

Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number < 0) number = number * -1; // Перевод отрицательного числа в положительное.
int result = number/10%10;           // Функция поиска второй цифры трехзначного числа. 
Console.WriteLine($"Вторая цифра в заданном числе {result}.");