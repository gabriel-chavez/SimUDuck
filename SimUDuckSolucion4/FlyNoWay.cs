using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    class FlyNoWay : IFlyBehavior
    {
        public object Fly()
        {
            return "I can't fly";
        }
    }
}
