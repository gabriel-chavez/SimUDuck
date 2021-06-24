using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override object Display()
        {
            return "I'm a real Redhead duck";
        }
    }
}
