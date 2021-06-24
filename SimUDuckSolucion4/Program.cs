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
            Console.WriteLine(mallardDuck.Display());
            Console.WriteLine(mallardDuck.PerformQuack());
            Console.WriteLine(mallardDuck.Swim());
            Console.WriteLine(mallardDuck.PerformFly());
            Console.WriteLine("-------------------------");
            RedheadDuck redheadDuck = new RedheadDuck();
            Console.WriteLine(redheadDuck.Display());
            Console.WriteLine(redheadDuck.PerformQuack());
            Console.WriteLine(redheadDuck.Swim());
            Console.WriteLine(redheadDuck.PerformFly());
            Console.WriteLine("-------------------------");
            RubberDuck rubberDuck = new RubberDuck();
            Console.WriteLine(rubberDuck.Display());
            Console.WriteLine(rubberDuck.PerformQuack());
            Console.WriteLine(rubberDuck.Swim());
            Console.WriteLine(rubberDuck.PerformFly());
            Console.WriteLine("-------------------------");
            DecoyDuck decoyDuck = new DecoyDuck();
            Console.WriteLine(decoyDuck.Display());
            Console.WriteLine(decoyDuck.PerformQuack());
            Console.WriteLine(decoyDuck.Swim());
            Console.WriteLine(decoyDuck.PerformFly());
            Console.WriteLine("-------------------------");
            Duck model = new ModelDuck();
            Console.WriteLine(model.PerformFly());
            model.setFlyBehavior(new FlyRocketPowered());
            Console.WriteLine(model.PerformFly());
            Console.ReadKey();
        }
    }
}
