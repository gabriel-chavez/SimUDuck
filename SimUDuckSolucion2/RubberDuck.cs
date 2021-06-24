using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion2
{
    public class RubberDuck:Duck
    {
        public new void Display()
        {
            Console.WriteLine("I am RubberDuck Duck");
        }
        //Nos dimos cuenta que los patos de goma no pueden volar
        public new void Fly()
        {
            Console.WriteLine("");
        }
        //Nos dimos cuenta que los patos de goma no hacen quack si no mas bien un chirrido
        public new void Quack()
        {
            Console.WriteLine("Squeak");
        }

    }
}
