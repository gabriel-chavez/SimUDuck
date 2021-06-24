using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }

        public override object Display()
        {
            return "I'm a real Decoy duck";
        }
    }
}
