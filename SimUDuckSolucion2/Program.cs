using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion2
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Nuevo requerimiento metodo volar
            MallardDuck mallarDuck = new MallardDuck();
            mallarDuck.Display();
            mallarDuck.Quack();
            mallarDuck.Swim();
            mallarDuck.Fly();
            Console.WriteLine("-------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Quack();
            redheadDuck.Swim();
            redheadDuck.Fly();
            Console.WriteLine("-------------------------");
            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Fly();
            Console.ReadKey();
        }
    }
}
