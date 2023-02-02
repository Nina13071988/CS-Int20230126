// 14.С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
{
int a, b, ost;
 
try
{
Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
 
ost = a % b;
 
if (ost == 0)
{
Console.WriteLine("Число a кратное числу b");
Console.ReadLine();
return;
}
 
Console.WriteLine("Число a не кратное числу b");
}
catch (FormatException)
{
Console.WriteLine("Введено не число");
}
catch (DivideByZeroException)
{
Console.WriteLine("На ноль делить нельзя");
}
 
Console.ReadLine();
return;
}

