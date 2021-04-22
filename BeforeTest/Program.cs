using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Puddle p = new Puddle();
            p.Bark(1, 2);
            p.Bark(1.1, 2.2);
            p.Bark('a', 'b');
        }
    }

    class Dog
    {
        private int eyes, nose, mouth, ears;
        public virtual void Bark() { }
        public void Bark(int a, int b) { }
        public void Bark(char a, char b) { }
    }

    class Puddle : Dog
    {
        public override void Bark() { }
        public void Bark(int a) { }
        //public void Bark(int a, int b) { }
        public void Bark(double a, double b) { }
    }

    abstract class SmartPhone
    {
        public void Camera() { }
        public abstract void CallPhone();
        public abstract void NetWork();
    }

    public interface IUnit
    {
        void Attack();
        void Move();
    }


}
