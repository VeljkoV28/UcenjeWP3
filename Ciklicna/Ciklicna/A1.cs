using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklicna
{
    internal class A1
    {
        public static void Izvedi()
        {
            Console.Write("Broj redova: ");
            int Redovi = int.Parse(Console.ReadLine());
            Console.WriteLine("Broj stupaca: ");
            int Stupci = int.Parse(Console.ReadLine());

            int[,] Cmatrica = NapraviMatricu(Redovi, Stupci);
            for (int i = 0; i < Redovi; i++)
            {
                for (int j = 0; j < Stupci; j++)
                {
                    Console.Write($"{Cmatrica[i, j],3} ");
                }
                Console.WriteLine();

            }


        }

        private static int[,] NapraviMatricu(int Redovi, int Stupci)
        {



            int[,] matrica = new int[Redovi, Stupci];
            int a = 1;

            int gore = 0, dolje = Redovi - 1, lijevo = 0, desno = Stupci - 1;

            while (gore <= dolje && lijevo <= desno)
            {
                for (int i = desno; i >= lijevo; i--)
                {
                    matrica[dolje, i] = a--;
                }
                dolje--;

                for (int i = dolje; i >= gore; i--)
                {
                    matrica[i, lijevo] = a--;
                }
                lijevo--;

                if (gore <= dolje)
                {
                    for (int i = lijevo; i <= desno; i++)
                    {
                        matrica[gore, i] = a++;
                    }
                    gore++;
                }

                if (lijevo <= desno)
                {
                    for (int i = dolje; i >= gore; i++)
                    {
                            int v = a++;
                        matrica[i, desno] = v;
                    }
                    desno++;
                }
            }

            return matrica;

        }
    }
}
    
   


    



