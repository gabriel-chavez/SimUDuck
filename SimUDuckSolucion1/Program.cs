using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplicacion de simulación existente muestra al pato, emite un sonido y nada.
            MallardDuck mallarDuck = new MallardDuck();                        
            Console.WriteLine(mallarDuck.Display());
            Console.WriteLine(mallarDuck.Quack());
            Console.WriteLine(mallarDuck.Swim());
            Console.WriteLine("-------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            Console.WriteLine(redheadDuck.Display());
            Console.WriteLine(redheadDuck.Quack());
            Console.WriteLine(redheadDuck.Swim());           
            Console.ReadKey();
        }
    }
}
