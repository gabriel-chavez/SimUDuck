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
        public abstract object Display();
        public object PerformFly()
        {
            return flyBehavior.Fly();
        }
        public object PerformQuack()
        {
            return quackBehavior.Quacking();
        }
        public string Swim()
        {
            return "All ducks float, even decoys!";
        }
    }
}
