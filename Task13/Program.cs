﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n>=100 && n<1000)
Console.Write($"   -> {n%10}");
if (n>=1000 && n<10000)
Console.Write($"   -> {(n%100)/10}");
if (n>=10000 && n<100000)
Console.Write($"   -> {(n%1000)/100}");
if (n>=100000 && n<1000000)
Console.Write($"   -> {(n%10000)/1000}");
if (n<100)
Console.Write($"   -> третьей цифры нет");
