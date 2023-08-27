using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Comparison
    {
        public static void Example()
        {
            bool m = (2 > 1);//true
            bool n1 = (3 < 10);//true
            bool o = (2 == 2);//true
            bool p = (3 < 1);//false
            bool q = (4 != 10);//true
            bool r = (10 <= 10);//true

            int x1 = 2;
            int y1 = 3;
            bool r1 = (x1 > y1);

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", m, n1, o, p, q, r, r1);
        }
    }
}
