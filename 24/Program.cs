// 24.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 

Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0) System.Console.WriteLine("Четверть 1");
if (x>0 && y>0) System.Console.WriteLine("Четверть 2");
if (x<0 && y<0) System.Console.WriteLine("Четверть 3");
if (x>0 && y<0) System.Console.WriteLine("Четверть 4");
