/*Задача №13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что
третьей цифры нет. (Цифры считать справа налево)*/
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number / 100 == 0)
    Console.WriteLine($"Третьей цифры справа налево у числа {number} нет");
else
{
    int a = number % 1000;
    int b = a / 100;
    Console.WriteLine($"Третьей цифрой справа налево у числа {number} является {b}");
}