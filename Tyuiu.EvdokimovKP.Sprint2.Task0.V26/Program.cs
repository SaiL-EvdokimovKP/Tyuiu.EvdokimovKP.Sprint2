using Tyuiu.EvdokimovKP.Sprint2.Task0.V26.Lib;

DataService ds = new DataService();

int x = 1045;
int y = 975;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);
Console.WriteLine("********************************************************************");
Console.WriteLine("Переменные:                                                         ");
Console.WriteLine("********************************************************************");
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine("********************************************************************");
Console.WriteLine("Решение:                                                            ");
Console.WriteLine("********************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();
