using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion2
{
    public class RubberDuck:Duck
    {
        public new string Display()
        {
            return "I am RubberDuck Duck";
        }
        //Nos dimos cuenta que los patos de goma no pueden volar
        public new string Fly()
        {
            return "-";
        }
        //Nos dimos cuenta que los patos de goma no hacen quack si no mas bien un chirrido
        public new string Quack()
        {
            return "Squeak";
        }

    }
}
