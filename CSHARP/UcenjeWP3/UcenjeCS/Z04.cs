using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z04
    {
        public static void Izvedi()

        {
            Console.Write("Prvi broj ");
            int Prvi = int.Parse(Console.ReadLine());
            Console.Write("Drugi broj ");
            int Drugi = int.Parse(Console.ReadLine());
            Console.ReadLine();

            for (int i = Prvi; i <= Drugi; i++ )
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }


    }
}
