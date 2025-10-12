using Tyuiu.EvdokimovKP.Sprint2.Task5.V10.Lib;

DataService ds =  new DataService();

Console.Write("Введите Год: ");
int year = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите Месяц: ");
int month = Convert.ToInt32(Console.ReadLine());



Console.Write("Введите День: ");
int day = Convert.ToInt32(Console.ReadLine());

string res = ds.FindDateOfPreviousDay(year, month, day);
Console.WriteLine($"Вы ввели: {day}.{month}.{year}");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine($" Вчерашняя дата: {res}");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");