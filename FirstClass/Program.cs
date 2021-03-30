using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog a = new Dog(); //객체생성 = 객체선언 = 객체만들기
            //Pudle pd = new Pudle();
            //pd.PudleInfo();
            //a.Bark();
            //pd.Bark();

            //Zerg zerg = new Zerg();
            //zerg.Attack(10);
            //zerg.Attack(10, 20);
            //zerg.Attack(10, 20, 30);
            //zerg.Attack('A');

            //SmartPhone sl = new SmartPhone();
            ACompany apple = new ACompany();
            apple.Camera();
            apple.CallPhone();
            apple.Network();
            BCompany samsung = new BCompany();
            samsung.Camera();
            samsung.CallPhone();
            samsung.Network();
            CCompany nokia = new CCompany();
            nokia.Camera();
            nokia.CallPhone();
            nokia.Network();
        }
    }
    //public class Dog
    //{
    //    protected int eyes, nose, mouth, ears; //멤버변수 = 속성 = 필드
    //    protected string kinds;
    //    virtual public void Bark() {
    //        Console.WriteLine("멍멍");
    //    } //멤버함수 = 메서드
    //}
    //public class Pudle : Dog
    //{
    //    override public void Bark()
    //    {
    //        Console.WriteLine("왈왈");
    //    }
    //    public Pudle() //Pudle 생성자 함수
    //    {
    //        base.eyes = 2;
    //        base.nose = 1;
    //        base.mouth = 1;
    //        base.ears = 2;
    //        base.kinds = "푸들";
    //    }
    //    public void PudleInfo() //Pudle 멤버함수
    //    {
    //        Console.WriteLine("눈 : {0}", base.eyes);
    //        Console.WriteLine("코 : {0}", base.nose);
    //        Console.WriteLine("입 : {0}", base.mouth);
    //        Console.WriteLine("귀 : {0}", base.ears);
    //        Console.WriteLine("종류 : {0}", base.kinds);
    //    }

    //}

    //public class Zerg
    //{

    //    public void Attack(int zerggling) //다형성, 오버로딩
    //    {
    //        Console.WriteLine("저글링 {0}마리", zerggling);
    //    }
    //    public void Attack(int zerggling, int hydra)
    //    {
    //        Console.WriteLine("저글링 {0}마리, 히드라 {1}마리", zerggling, hydra);
    //    }
    //    public void Attack(int zerggling, int hydra, int lurker)
    //    {
    //        Console.WriteLine("저글링 {0}마리, 히드라 {1}마리, 럴커 {2}마리", zerggling, hydra, lurker);
    //    }
    //    public void Attack(char zerggling)
    //    {
    //        Console.WriteLine("저글링 {0}등급", zerggling);
    //    }
    //}

    abstract class SmartPhone
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
    class CCompany : SmartPhone
    {
        public override void Camera()
        {
            Console.WriteLine("C회사 카메라 기능");
        }
        public override void CallPhone()
        {
            Console.WriteLine("C회사 전화걸기 기능");
        }
        public override void Network()
        {
            Console.WriteLine("C회사 네트워크 기능");
        }
    }
}
