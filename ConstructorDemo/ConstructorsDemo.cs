using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    public class ConstructorsDemo
    {
        static int y;
        int x;
        static ConstructorsDemo()
        {
            Console.WriteLine("Static constructor is called.");
        }
        public ConstructorsDemo(int x)
        {
            this.x = x;
            Console.WriteLine("Non-Static constructor is called.");

        }
        static void Main()
        {
            ConstructorsDemo cd1 = new ConstructorsDemo(10);
            ConstructorsDemo cd2 = new ConstructorsDemo(20);
            ConstructorsDemo cd3 = new ConstructorsDemo(30);

            Console.WriteLine(y);
            Console.WriteLine(cd1.x + " " + cd2.x + " " + cd3.x);
        }
    }
}
