using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();


            string myLastName;
            Console.Write("Type your last name");
            myLastName = Console.ReadLine();

            Console.WriteLine("hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
