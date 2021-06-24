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
            mallarDuck.Display();
            mallarDuck.Quack();
            mallarDuck.Swim();
            Console.WriteLine("-------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Quack();
            redheadDuck.Swim();           
            Console.ReadKey();
        }
    }
}
