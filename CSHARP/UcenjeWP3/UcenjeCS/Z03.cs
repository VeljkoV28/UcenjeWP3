using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi cijeli broj ");
            int Prvi = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj ");
            int Drugi = int.Parse(Console.ReadLine());
            Console.Write("Unesi treci cijeli broj ");
            int Treci = int.Parse(Console.ReadLine());

            if (Prvi < Drugi & Prvi < Treci) 
            {
                Console.WriteLine(Prvi);

            }
            if (Drugi < Prvi & Drugi < Treci)
            {
                Console.WriteLine(Drugi);
            }
            if (Treci < Drugi & Treci < Prvi)
            {
                Console.WriteLine(Treci);
            }
        }
    }
}
