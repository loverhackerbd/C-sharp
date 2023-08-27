using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
     class Assignment
    {
        public static void Example()
        {
            int n = 0;
            n += 3;// n=n+3;n=0+3;n=3
            Console.WriteLine(n);
            n -= 1;// n=n-1;n=3-1;n=2
            Console.WriteLine(n);
            n *= 3;// n=n*3;n=2*3;n=6
            Console.WriteLine(n);
            n /= 2;// n=n/2;n=6/2;n=3
            Console.WriteLine(n);
            n %= 2;// n=n%2;n=3%2;n=1
            Console.WriteLine(n);
        }

    }
}
