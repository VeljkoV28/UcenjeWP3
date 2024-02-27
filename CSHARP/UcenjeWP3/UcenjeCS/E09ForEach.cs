using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForEach
    {
        public static void Izvedi()
        {

            //string grad = "Osijek";

            //for(int i = 0; i < grad.Length; i++)
            //{
            //    Console.WriteLine(grad[i]);
            //}


            //foreach(var c in grad)
            //{
            //    Console.WriteLine(c);
            //}

            //for(int i=grad.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(grad[i]);
            //}

            int[] niz = new int[] { 21, 564, 84, 71, 12 };
            foreach(var c in niz)
            {
                Console.WriteLine(c);
            }

        }
    }
}
