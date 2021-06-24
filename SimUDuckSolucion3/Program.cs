using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Otra posible solucion implementando interfaces
            MallardDuck mallardDuck = new MallardDuck();
            Console.WriteLine(mallardDuck.Display());
            Console.WriteLine(mallardDuck.Quack());
            Console.WriteLine(mallardDuck.Swim());
            Console.WriteLine(mallardDuck.Fly());
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
            Console.WriteLine("-------------------------");
            DecoyDuck decoyDuck = new DecoyDuck();
            Console.WriteLine(decoyDuck.Display());            
            Console.ReadKey();
        }
    }
}
