using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Logical
    {
        public static void Example()
        {
            bool a1 = !(true && (3 > 10));

            Console.WriteLine(a1);
        }
    }
}
