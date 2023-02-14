// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int n = int.Parse(Console.ReadLine());
if (n==6||n==7)
Console.Write($"   -> YES");
if (n<6)
Console.Write($"   -> NO");
