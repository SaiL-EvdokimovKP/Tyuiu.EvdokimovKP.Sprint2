using Tyuiu.EvdokimovKP.Sprint2.Task2.V15.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
int x;
Console.WriteLine("Введите значение X");
x = Convert.ToInt32(Console.ReadLine());

int y;
Console.WriteLine("Введите значение Y");
y = Convert.ToInt32(Console.ReadLine());
if (ds.CheckDotInShadedArea(x, y))
    Console.WriteLine("Точка закрашена");
else
    Console.WriteLine("Точка НЕ закрашена");



