// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)
{
    Console.Write("В веденном числе нет третьей цифры");
}    
if (number > 99 & number <1000)
{
    int A = number % 10;
    Console.Write($"Третья цифра числа: {A}");
}
if (number > 999 & number <10000)
{
    int A = (number % 100 - number % 10) / 10;
    Console.Write($"Третья цифра числа: {A}");
}
if (number > 9999 & number <100000)
{
    int A = (number % 1000 - number % 100) / 100;
    Console.Write($"Третья цифра числа: {A}");
}
if (number > 99999 & number <1000000)
{
    int A = (number % 10000 - number % 1000) / 1000;
    Console.Write($"Третья цифра числа: {A}");
}
if (number > 999999 & number <10000000)
{
    int A = (number % 100000 - number % 10000) / 10000;
    Console.Write($"Третья цифра числа: {A}");
}