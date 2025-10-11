using Tyuiu.EvdokimovKP.Sprint2.Task4.V15.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");

double x;
Console.WriteLine("Введите значение для X");
x = Convert.ToDouble(Console.ReadLine());  

double y;
Console.WriteLine("Введите значение для Y");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Z = " + ds.Calculate(x, y));