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
            Console.WriteLine(mallarDuck.Display());
            Console.WriteLine(mallarDuck.Quack());
            Console.WriteLine(mallarDuck.Swim());
            Console.WriteLine(mallarDuck.Fly());
            Console.WriteLine("-------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            Console.WriteLine(redheadDuck.Display());
            Console.WriteLine(redheadDuck.Quack());
            Console.WriteLine(redheadDuck.Swim());
            Console.WriteLine(redheadDuck.Fly());
            Console.WriteLine("-------------------------");
            RubberDuck rubberDuck = new RubberDuck();
            Console.WriteLine(rubberDuck.Display());
            Console.WriteLine(rubberDuck.Quack());
            Console.WriteLine(rubberDuck.Swim());
            Console.WriteLine(rubberDuck.Fly());
            Console.ReadKey();
        }
    }
}
