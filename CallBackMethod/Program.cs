using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackMethod
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);
        static void Callback(int x, int y, CalcDelegate dele)
        {
            dele(x, y);
        }
        static void Plus(int x, int y) { Console.WriteLine(x + y); }
        static void Minus(int x, int y) { Console.WriteLine(x - y); }
        static void Multiple(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }
        static void Main(string[] args)
        {
            //Plus(20, 10);
            //Minus(20, 10);
            //Multiple(20, 10);
            //Divide(20, 10);

            CalcDelegate p = Plus;
            CalcDelegate m = Minus;
            CalcDelegate mul = Multiple;
            CalcDelegate d = Divide;

            Callback(20, 10, p);
            Callback(20, 10, m);
            Callback(20, 10, mul);
            Callback(20, 10, d);
        }
    }
}
