using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        public static void Izvedi()
        {
            //    Console.Write("Cijeli broj ");
            //    int Broj = int.Parse(Console.ReadLine());
            //    int Zbroj = 0;

            //    for(int i = 1; i <= Broj; i++)
            //    {
            //        Zbroj += i;
            //    }
            //Console.WriteLine(Zbroj);




            //int i, najmanji=int.MaxValue;
            //for (; ; )
            //{
            //    Console.Write("Cijeli broj ");
            //    i=int.Parse(Console.ReadLine());
            //    if(i== -1) 
            //    {
            //        break;
            //    }
            //    if (i < najmanji)
            //    {
            //        najmanji = i;
            //    }


            //}
            //Console.WriteLine(najmanji);


            Console.WriteLine("Unesi Broj: ");
            int b = int.Parse(Console.ReadLine());

            bool prim = true;

            for (int i=2; i < b; i++)
            {

                if( b%1==0)
                {
                    prim = false;
                    break;
                }

            }
            Console.WriteLine(b+ " " + (prim ? " JE " : " NIJE ") + "prim broj");




        }
        


    }
}
