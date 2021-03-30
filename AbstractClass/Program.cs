using System;

namespace AbstractClass
{

    abstract class SmartPhone //추상클래스
    {
        public abstract void Camera(); //추상메서드
        public abstract void CallPhone();
        public abstract void Network();
    }

    class ACompany : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("A회사 카메라 기능");
        }
        public override void CallPhone()
        {
            Console.WriteLine("A회사 전화걸기 기능");
        }
        public override void Network()
        {
            Console.WriteLine("A회사 네트워크 기능");
        }
    }

    class BCompany : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("B회사 카메라 기능");
        }
        public override void CallPhone()
        {
            Console.WriteLine("B회사 전화걸기 기능");
        }
        public override void Network()
        {
            Console.WriteLine("B회사 네트워크 기능");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone com = new ACompany();
            com.Camera();
            com.CallPhone();
            com.Network();

            com = new BCompany();
            com.Camera();
            com.CallPhone();
            com.Network();
        }
    }
}
