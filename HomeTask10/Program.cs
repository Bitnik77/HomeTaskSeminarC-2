/*Задача №10. Напишите программу, которая принимает на вход трёхзначное число и на выходе
показывает вторую цифру этого числа*/
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int a = number / 10;
int b = a % 10;
Console.WriteLine($"Второй цифрой трехзначного числа {number} является {b}");



/* Ниже не смотрите пожалуйста, хотел сделать цикл проверки правильности ввода числа, пока не получается,
знаний не хватает
Console.Clear();
Console.Write("Введите трехзначное число: ");
for (int number = int.Parse(Console.ReadLine()!); number / 1000 != 0 || number / 100 == 0;number1 = number)
{
    Console.WriteLine("Ошибка, введено не трехзначное число");
    Console.Write("Введите трехзначное число: ");
    int number1 = int.Parse(Console.ReadLine()!);
    number = number1;
}
int number = number1;
int a = number / 10;
int b = a % 10;
Console.WriteLine($"Второй цифрой трехзначного числа {number} является {b}");
*/

/*
int treeDigitsNumber;
// Объявляем переменную, которая будет хранить введенное пользователем значение

while (true) // Инициализируем бесконечный цикл, выходить будем по инструкции break
{
    Console.Write("Введите трехзначное число: "); // Выводим пользователю приглашение ко вводу
    int treeDigitsNumber = int.Parse(Console.ReadLine()!); // Считываем введенное значение пользователем и конвертируем в тип данных integer (целое число), присваем значение переменной treeDigitsNumber

    if (treeDigitsNumber / 1000 > 0 || treeDigitsNumber / 100 < 1) // Проверяем корректность введенных данных (является ли число трехзначным)
    {
        Console.WriteLine($"Число {treeDigitsNumber} не является трехзначным, повторите ввод"); // Блок "Истина" условия обрабатывает ошибку "введено не трехзначное число"
    }
    else
    {
        break; // Блок else прерывает цикл инструкцией break, так как пользователем введено корректное (трехзачное) число
    }
}

/*
Тут уже пишем код для решения задачи, число введенное пользователем присвоено переменной с именем treeDigitsNumber
*/