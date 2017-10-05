using StrategyPattern.Fly;
using StrategyPattern.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public void SetQuackBehaviour(IQuackable newQuack)
        {
            quackBehaviour = newQuack;
        }

        public void SetFlyBehaviour(IFlyable newFly)
        {
            flyBehaviour = newFly;
        }


        public DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }

        public virtual void Quack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public void Fly()
        {
            flyBehaviour.Fly();
        }

        public abstract void Display();
    }
}
