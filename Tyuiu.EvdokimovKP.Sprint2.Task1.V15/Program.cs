using Tyuiu.EvdokimovKP.Sprint2.Task1.V15.Lib;

DataService ds = new DataService();

//Написать программу из операций сравнений (==, !=, <, >, <=, >=,
//последовательность можно чередовать, но использовать один раз в выражении) и логических операций
//  (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений,
//которая вернет логическую последовательность(массив): (True, False, False, False, False, True),
//при a = 415, b = 616, c = 134, d = 127

int a = 415;
int b = 616;
int c = 134;
int d = 127;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);
Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);
Console.WriteLine("********************************************************************");
Console.WriteLine("Решение:                                                            ");
Console.WriteLine("********************************************************************");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();
