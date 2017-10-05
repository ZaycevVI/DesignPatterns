using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodSample.Food;

namespace TemplateMethod
{
    class Program
    {
        class A
        {
            virtual public void Print()
            {
                Console.WriteLine("Hello");
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("Bye");
            }
        }

        static void Main(string[] args)
        {
            A b = new B();
            b.Print();

            var hotDog = new HotDog();
            var hamburger = new Hamburger();

            Console.WriteLine("\nHotDog:");
            hotDog.Prepare();
            Console.WriteLine("\nHamburger:");
            hamburger.Prepare();

            Console.ReadLine();
        }
    }
}
