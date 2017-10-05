using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new SimpleQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubber duck");
        }
    }
}
