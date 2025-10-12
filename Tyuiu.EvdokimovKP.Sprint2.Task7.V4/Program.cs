using Tyuiu.EvdokimovKP.Sprint2.Task7.V4.Lib;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(" Введите значение X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" Введите значение Y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CheckDotInShadedArea(x, y));
Console.ReadKey();