using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion3
{
    class RubberDuck : Duck, IQuackable
    {
        public new string Display()
        {
            return "I am Rubber Duck";
        }
        public string Quack()
        {
            return "Quack";
        }
    }
}
