using System;

namespace Interface2
{

    public interface ICamera
    {
        void Picture();
        void Video();
    }
    public interface ICallPhone
    {
        void Call();
    }
    public interface INetwork
    {
        void Wifi();
    }

    public class SmartPhone : ICamera, ICallPhone, INetwork
    {
        public void Call()
        {
            Console.WriteLine("전화 건다");
        }

        public void Picture()
        {
            Console.WriteLine("사진 찍는다");
        }

        public void Video()
        {
            Console.WriteLine("동영상 찍는다");
        }

        public void Wifi()
        {
            Console.WriteLine("와이파이 연결한다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone sp = new SmartPhone();
            sp.Picture();
            sp.Video();
            sp.Call();
            sp.Wifi();
        }
    }
}
