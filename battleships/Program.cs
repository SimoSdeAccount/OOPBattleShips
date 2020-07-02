using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Program
    {
        static void Main(string[] args)
        {
            bool spilIgang = true;
            string spilValg = string.Empty;
            while(spilIgang)
            {
                Validering valider = new Validering();
                spilValg = valider.TekstInputValidering(new string[] { "s", "S", "q", "Q" }, "Tast s for at starte nyt spil, tast q for at afslutte spil");
                if(spilValg == "s" || spilValg == "S")
                {
                    spilValg = string.Empty;
                    Opret opret = new Opret();
                    opret.OpretSpil();
                }
                else
                {
                    spilIgang = false;
                }
            }
            Console.WriteLine("Du har afsluttet programmet, kør programmet igen for at starte nyt spil");
            Console.ReadLine();
        }
    }
}
