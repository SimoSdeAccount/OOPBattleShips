using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Opret
    {
        public Opret()
        {
            retning = string.Empty;
            startX = 0;
            startY = 0;
        }
        private string retning;
        private int startX;
        private int startY;
        public void OpretSpil()
        {
            Spil nytSpil = new Spil(OpretSpillere());
            nytSpil.StartSpil();
        }
        private List<Spiller> OpretSpillere()
        {
            List<Spiller> spillere = new List<Spiller>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Du opretter nu spiller nr " + (i + 1).ToString());
                Console.WriteLine("Indtast navn:");
                string navn = Console.ReadLine();
                List<Skib> spillerSkibe = OpretSkibe();
                spillere.Add(new Spiller(spillerSkibe, navn));
            }
            return spillere;
        }
        private List<Skib> OpretSkibe()
        {
            List<Skib> Skibe = new List<Skib>();
            skibsDataInput("CarrierSkib", Skibe);
            Skibe.Add(new CarrierSkib(retning, startX, startY));
          /*  skibsDataInput("BattleSkib", Skibe);
            Skibe.Add(new BattleSkib(retning, startX, startY));
            skibsDataInput("DestroyerSkib", Skibe);
            Skibe.Add(new DestroyerSkib(retning, startX, startY));
            skibsDataInput("SubmarineSkib", Skibe);
            Skibe.Add(new SubmarineSkib(retning, startX, startY));
            skibsDataInput("PatrolSkib", Skibe);
            Skibe.Add(new PatrolSkib(retning, startX, startY));*/
            return Skibe;
        }
        private void skibsDataInput(string skibType, List<Skib> skibe) 
        {
            Validering inputVali = new Validering();
            bool valideringIgang = true;
            while(valideringIgang)
            {
                retning = inputVali.TekstInputValidering(new string[] { "v", "h" }, "Opret " + skibType + ", tast retning: v og vertikal eller h for horizontal");
                startX = inputVali.IntInputValidering(1, 10,  "Indtast x koordinat (koordinat længst til venstre for horizontal)");
                startY = inputVali.IntInputValidering(1, 10, "Indtast øverste y koordinat (koordinat øverst ved vertikal)");
                valideringIgang = inputVali.OpretSkibValidering(skibType, skibe, retning, startX, startY);
            }
        }
    }
}
