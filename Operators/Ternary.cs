using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Ternary
    {
        public static void Example()
        {
            byte g = 0;
            string gender = (g == 0) ? "Male" : "Female";
            Console.WriteLine(gender);

            int x2 = -56;

            int n3 = (x2 > 0) ? x2 : -x2;

            Console.WriteLine(n3);
        }

    }
}
