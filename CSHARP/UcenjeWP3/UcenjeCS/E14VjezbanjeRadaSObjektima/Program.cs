using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS.E14VjezbanjeRadaSObjektima
{
    internal class Program
    {
        /// <summary>

        /// </summary>
        /// 

        private List<Osoba> Osobe;

        public Program()
        {

            Osobe = new List<Osoba>();
            TestPodaci();
            PozdravnaPoruka();
            Izbornik();

        }

        private void TestPodaci()
        {
           Osobe.Add(new() { Ime="Ana", Prezime = "Kat", Dob = 12 });
           Osobe.Add(new() { Ime = "Marko", Prezime = "Matic", Dob = 27 });

        }

        private void Izbornik()
        {
            Console.WriteLine("1. Pregled osoba");
            Console.WriteLine("2. Unos nove osobe");
            Console.WriteLine("3. Promjena osobe");
            Console.WriteLine("4. Brisanje osobe");
            Console.WriteLine("5. Izlaz iz programa");
            OdaberiOpciju();
        
        
        }

        private void OdaberiOpciju()
        {
           switch(Pomocno.UcitajCijeliBroj("Odaberi opciju: "))
            {
                case 1:
                    PrikaziOsobe(true);
                    Izbornik();
                    break;
                case 2:
                    UnosNoveOsobe();
                    Izbornik();
                    break;
                case 3:
                    PromjenaOsobe();
                    Izbornik();
                    break;
                case 4:
                    IzbrisiOsobu();
                    Izbornik();
                    break;
                case 5:
                    Console.WriteLine("Program je fertig, schön Tag noch");
                    break;
                default:
                    Console.WriteLine("Nije dobra opcija");
                    Console.WriteLine("-----------------");
                    Izbornik();
                    break;
            }
        }

        private void IzbrisiOsobu()
        {
            Console.WriteLine("-- Brisanje osobe --");
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe", 1, Osobe.Count);
            Osobe.RemoveAt(izbor - 1);
           

        }

        private void PromjenaOsobe()
        {
            Console.WriteLine("Promjena osobe");
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe (0 - odustani)", 0, Osobe.Count);
            if(izbor == 0)
            {
                return;
            }
            var o = Osobe[izbor - 1];
            o.Ime = Pomocno.UcitajString("Ucitaj ime ");
            o.Prezime = Pomocno.UcitajString("Ucitaj prezime");
            o.Dob = Pomocno.UcitajCijeliBroj("Ucitaj dob");
            
        }

        private void UnosNoveOsobe()
        {
            Console.WriteLine("Unos nove osobe");
            Console.WriteLine("---------------");
            Osobe.Add(new()
            {
               
                Ime = Pomocno.UcitajString("Unesi ime osobe"),
                Prezime = Pomocno.UcitajString("Unesi prezime osobe"),
                Dob = Pomocno.UcitajCijeliBroj("Unesi dob osobe: "),
                          
            });
        }

        private void PrikaziOsobe(bool Prikazi_Naslov = false)
        {
            if (Prikazi_Naslov)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("-- Osobe u sustavu --");
                Console.WriteLine("---------------------");
            }
            if (Osobe.Count == 0)
            {
                Console.WriteLine("----Nema osoba---");
                return;
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("-- Osobe u sustavu --");
            Console.WriteLine("---------------------");
            int i = 1;
            foreach (var o in Osobe)
            {
                Console.WriteLine(i++ + ". " + o);
            }

            
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("Osobe program V1");
            Console.WriteLine("****************");

        }
    }
}
