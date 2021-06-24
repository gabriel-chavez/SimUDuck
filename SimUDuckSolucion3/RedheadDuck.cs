using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion3
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public new string Display()
        {
            return "I am RedHead Duck";
        }

        public string Fly()
        {
            return "I am Flying";
        }

        public string Quack()
        {
            return "Quack";
        }
    }
}
