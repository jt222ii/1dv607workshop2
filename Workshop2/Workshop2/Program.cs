using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Model;

namespace Workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Byter branch");
            Console.WriteLine("dasads");
            Console.WriteLine("hahahahahaahha");
            Console.WriteLine("hej ja e adam");
            Console.WriteLine("hej ja e adam igennnn");
            Boat boat = new Boat(123);
            Console.WriteLine(boat.Length+ "innan ändring pål");
            boat.Length = 80085;
            Console.WriteLine(boat.Length + "efter ändring pelle");
=======
            Controller.User u = new Controller.User();

            u.StartApplication();
>>>>>>> Adam
        }
    }
}
