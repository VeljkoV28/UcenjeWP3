using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSWITCH
    {
        public static void Izvedi()
        {
            int i = 2;

            if (i == 0)
            {
                Console.WriteLine("DOBAR");
            }
            else if (i == 1)
            {
                Console.WriteLine("LOS");
            }
            else if (i == 2)
            {
                Console.WriteLine("ZAO");
            }

            switch (i)
            {
                case 0:
                    Console.WriteLine("DOBAR");
                    break;
                case 1:
                    Console.WriteLine("LOS");
                    break;
                case 2:
                    Console.WriteLine("ZAO");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;

            }
            Console.Write("Unesi ime grada ");
            string grad = Console.ReadLine();

            switch (grad)
            {
                case "Osijek":
                case "Vukovar":
                    Console.WriteLine("Slavonija");
                    break;
                case "Split":
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
            }
        }
    }
}
