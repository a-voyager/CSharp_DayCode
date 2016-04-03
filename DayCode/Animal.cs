using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayCode
{
    public class Animal
    {
        private int age;

        internal Animal() { }

        internal Animal(int age) {
            this.age = age;
        }

        public int Age {
            get {
                return age;
            }
            set
            {
                age = Age;
            }
        }

        public virtual void say() {
            Console.WriteLine("Animal say");
        }

    }

    public class Dog : Animal
    {
        public Dog(){

        }

        public Dog(int a) : base(a) { }

        public override void say()
        {
            Console.WriteLine("Dog say");
        }

    }
    public class Cat : Animal
    {

    }
}
