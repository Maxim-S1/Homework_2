// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// 

string resoult = number.ToString();
int [] array = new int[resoult.Length];
int i = 0;


Console.WriteLine($"Третья цифра числа: {resoult[2]}");



