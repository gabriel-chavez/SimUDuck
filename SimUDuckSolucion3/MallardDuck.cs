using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion3
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public new string Display()
        {
            return "I am Mallard Duck";
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
