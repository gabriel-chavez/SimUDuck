using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion3
{
    class RubberDuck : Duck, IQuackable
    {
        public new void Display()
        {
            Console.WriteLine("I am Rubber Duck");
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
