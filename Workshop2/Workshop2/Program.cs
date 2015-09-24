using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Controller;
using Workshop2.Model;

namespace Workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new Controller.User();

            u.StartApplication();
        }
    }
}
