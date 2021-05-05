using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvent
{
    class Program
    {
        public delegate void ButtonEvent();
        public static event ButtonEvent evtClick;
        public static void onClick()
        {
            evtClick();
        }
        public static void MyHandler()
        {
            Console.WriteLine("버튼 클릭 처리기 수행");
        }
        public static void MyHandler2()
        {
            Console.WriteLine("버튼2 클릭 처리기 수행");
        }
        static void Main(string[] args)
        {
            evtClick += new ButtonEvent(MyHandler);
            evtClick += new ButtonEvent(MyHandler2);

            onClick();
        }
    }
}
