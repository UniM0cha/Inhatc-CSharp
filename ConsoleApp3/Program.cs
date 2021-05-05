using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        delegate void DelegateType(string msg);
        class Test1
        {
            public event DelegateType EventHandler;
            public void Func(string Message)
            {
                EventHandler(Message);
            }
        }
        class Test2
        {
            public void printA(string Message)
            {
                Console.WriteLine(Message);
            }
            public void printB(string Message)
            {
                Console.WriteLine(Message);
            }
        }
        static void Main(string[] args)
        {
            Test1 a = new Test1();
            Test2 b = new Test2();
            a.EventHandler += new DelegateType(b.printA);
            a.EventHandler += new DelegateType(b.printB);
            a.Func("Hello");
            a.EventHandler -= b.printB;
            a.Func("Hi");
        }
    }
}
