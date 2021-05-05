using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void DelegateSample(string msg);
    class Test
    {
        public void print(string m)
        {
            Console.WriteLine(m);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test();
            a.print("Hello World");

            DelegateSample ds = new DelegateSample(a.print);
            ds("Hello World printed by Delegate1");

            // DelegateSample ds2 = new DelegateSample(a.print);
            DelegateSample ds2 = a.print;
            ds2("Hello World printed by Delegate2");
        }
    }
}
