// 4.По заданному с клавиатуры номеру дня недели вывести его название

int a = 0;
Console.WriteLine("Введите номер дня недели");
a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
    System.Console.WriteLine("Выбраный день - Понедельник");

if (a == 2)
     System.Console.WriteLine("Выбраный день - Вторник");

if (a == 3)
    System.Console.WriteLine("Выбраный день - Среда");

if (a == 4) 
    System.Console.WriteLine("Выбраный день - Четверг");

if (a == 5)
    System.Console.WriteLine("Выбраный день - Пятница");

if (a == 6)
    System.Console.WriteLine("Выбраный день - Суббота");

if (a == 7)
    System.Console.WriteLine("Выбраный день - Воскресенье");

if (a >= 8)
    System.Console.WriteLine("Неверное число, дней недели 7), вводите от 1 до 7");

if (a <= 0)
    System.Console.WriteLine("Неверное число, дней недели 7), вводите от 1 до 7");




