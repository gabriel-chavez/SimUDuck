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
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.Fly();
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
            Console.WriteLine("-------------------------");
            DecoyDuck decoyDuck = new DecoyDuck();
            decoyDuck.Display();            
            Console.ReadKey();
        }
    }
}
