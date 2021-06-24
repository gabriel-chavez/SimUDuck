using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckSolucion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solucion con el patron strategy
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();
            mallardDuck.PerformFly();
            Console.WriteLine("-------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.Swim();
            redheadDuck.PerformFly();
            Console.WriteLine("-------------------------");
            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.Swim();
            rubberDuck.PerformFly();
            Console.WriteLine("-------------------------");
            DecoyDuck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.Swim();
            decoyDuck.PerformFly();
            Console.WriteLine("-------------------------");
            Duck model = new ModelDuck();
            model.PerformFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            Console.ReadKey();
        }
    }
}
