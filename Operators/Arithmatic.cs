using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
     class Arithmatic
    {
        public static void Example()
        {
            //--- Calculator --------


            //----Input process--------
            Console.WriteLine("Enter a number:");
            String line = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            String line2 = Console.ReadLine();

            //--- Menu for prompt to choose function-----
            Console.WriteLine("Choose your option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            String option = Console.ReadLine();

            //--Input data converted into number
            float a;
            float.TryParse(line, out a);

            float b;
            float.TryParse(line2, out b);

            //---Output----
            if (option == "1")
            {
                Console.WriteLine($"Result={a + b}");

            }
            else if (option == "2")
            {
                Console.WriteLine($"Result={a - b}");
            }
            else if (option == "3")
            {
                Console.WriteLine($"Result={a * b}");
            }
            else if (option == "4")
            {
                Console.WriteLine($"Result={a / b}");
            }
            else
            {
                Console.WriteLine($"Math Error");
            }
        }
    }
}
