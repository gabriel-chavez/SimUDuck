using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
       
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        public abstract void Display();
        public void PerformFly()
        {
             flyBehavior.Fly();
        }
        public void PerformQuack()
        {
             quackBehavior.Quacking();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
