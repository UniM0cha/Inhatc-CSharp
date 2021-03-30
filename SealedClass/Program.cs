using System;

namespace SealedClass
{
    class FolderPhone
    {
        public virtual void Network() //가상 메서드
        {
            Console.WriteLine("위피");
        }

    }
    class ThreeGPhone : FolderPhone
    {
        public sealed override void Network()
        {
            Console.WriteLine("와이브로");
        }
    }
    class SmartPhone : ThreeGPhone
    {
        public new void Network()
        {
            Console.WriteLine("와이파이");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FolderPhone fp = new FolderPhone();
            ThreeGPhone tg = new ThreeGPhone();
            SmartPhone sp = new SmartPhone();
            fp.Network();
            tg.Network();
            sp.Network();
        }
    }
}
