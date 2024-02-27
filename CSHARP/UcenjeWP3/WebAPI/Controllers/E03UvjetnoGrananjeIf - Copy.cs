using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03/")]
    public class E03UvjetnoGranjanje : ControllerBase
    {
        //[HttpGet]
        //[Route("Zad1")]
        
        //public int Zad1(int a, int b)
        //{



        //    return (a + b)%2==0 ? a*b : a+b;

        //}



        [HttpGet]
        [Route("zad2")]

        public string Zad2(int ocjena)
        {
          if (ocjena == 1) 
            {
                return ("Nedovoljan");
            }
          if (ocjena == 2)
            {
                return ("Dovoljan");
            }
          if (ocjena == 3)
            {
                return ("Dobar");
            }
          if (ocjena == 4) 
            {
                return ("Vrlo Dobar");
            }
          if (ocjena == 5)
            {
                return ("Odlican");
            }
            return "Nije ocjena";
        }

            
        



    }









}
