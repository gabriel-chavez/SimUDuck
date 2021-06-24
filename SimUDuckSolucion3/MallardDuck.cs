using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion3
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public new void Display()
        {
            Console.WriteLine("I am Mallard Duck");
        }
        public void Fly()
        {
            Console.WriteLine("I am Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
