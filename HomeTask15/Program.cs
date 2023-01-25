/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
проверяет, является ли этот день выходным */
Console.Clear();
Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine()!);
if (number == 6 || number == 7) Console.WriteLine("Этот день выходной");
else Console.WriteLine("Этот день не выходной");