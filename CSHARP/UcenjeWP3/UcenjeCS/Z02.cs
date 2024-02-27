using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02
    {
        public static void Izvedi()
        {

            Console.Write("Prvi broj ");
            int Prvi = int.Parse(Console.ReadLine());
            Console.Write("Drugi broj ");
            int Drugi = int.Parse(Console.ReadLine());
            Console.ReadLine();

          
            if (Prvi > Drugi)
            {
                Console.WriteLine(Prvi);


            }
            if (Drugi > Prvi)
            {
                Console.WriteLine(Drugi);
            }

        }


    }
}
