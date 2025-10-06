using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=,
//последовательность можно чередовать, но использовать один раз в выражении) и логических операций
//  (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических выражений,
//которая вернет логическую последовательность(массив): (True, False, False, False, False, True),
//при a = 415, b = 616, c = 134, d = 127

namespace Tyuiu.EvdokimovKP.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a != b | c == d;
            res[1] = a > b & c < d;
            res[2] = a == b || c == d;
            res[3] = a >= b && c <= d;
            res[4] = !res[0];
            res[5] = a > b ^ c > d;
            return res;
        }
    }
}
