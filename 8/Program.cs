﻿// 8. Вывести на экран числа от -N до N
Console.Clear();
System.Console.Write("Введите число:   ");
string writeNumber = Console.ReadLine();
int endNumber = Convert.ToInt32(writeNumber);
int Number = endNumber * (-1);
System.Console.Write($"{Number} ");

while (Number < endNumber)
{
    Number++;
    System.Console.Write($"{Number} ");
}
System.Console.WriteLine(); System.Console.WriteLine();