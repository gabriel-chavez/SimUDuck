using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    public class FlyWithWings : IFlyBehavior
    {
        public object Fly()
        {
            return "I'm flying!!";
        }
    }
}
