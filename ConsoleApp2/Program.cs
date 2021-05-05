using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate void DelegateSample();
    class Test
    {
        public void printA()
        {
            Console.WriteLine("A 메서드 출력");
        }
        public void printB()
        {
            Console.WriteLine("B 메서드 출력");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test();
            //a.printA();
            //a.printB();

            DelegateSample ds = a.printA;
            ds += a.printB;
            ds();
            ds -= a.printB;
            ds();
        }
    }
}
