using Tyuiu.EvdokimovKP.Sprint2.Task3.V16.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
double x;
Console.WriteLine("Введите значение X");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("********************************************************************");
Console.WriteLine("y = " + ds.Calculate(x));
Console.WriteLine();

