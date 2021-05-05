using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);
        static void Plus(int x, int y) { Console.WriteLine(x + y); }
        static void Minus(int x, int y) { Console.WriteLine(x - y); }
        static void Multiple(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }

        //static int Plus(int x, int y) { return x + y; }
        //static int Minus(int x, int y) { return x - y; }

        static void Main(string[] args)
        {
            CalcDelegate cd = new CalcDelegate(Plus);
            cd(20, 10);
            Console.WriteLine();

            cd += Minus;
            cd += Multiple;
            cd += Divide;
            cd(20, 10);
            Console.WriteLine();

            cd -= Divide;
            cd(20, 10);

            //CalcDelegate del1 = new CalcDelegate(Plus);
            //int result = del1(20, 10);  //Plus(20, 10);
            //Console.WriteLine("result = " + result);

            //CalcDelegate del2 = new CalcDelegate(Minus);
            //result = del2(20, 10);  //Minus(20, 10);
            //Console.WriteLine("result = " + result);
        }
    }
}
