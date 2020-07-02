using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Spil
    {
        public Spil(List<Spiller> inSpillere)
        {
            spillere = inSpillere;
        }
        List<Spiller> spillere;
        public void StartSpil()
        {
            bool spilIgang = true;
            int spillerNummer = 0;
            while(spilIgang)
            {
                Validering inputVali = new Validering();
                int skibeRamt = 0;
                int xSkud = 0;
                int ySkud = 0;
                bool skudValideringIgang = true;
                Console.WriteLine("Det er nu spiller " + (spillerNummer + 1).ToString());
                spillere[spillerNummer].GetSetSkudGrid.PrintGrid();
                spillere[spillerNummer].GetSetSkibGrid.PrintGrid();
                Console.WriteLine("indtast skud koordinat og skyd");
                while(skudValideringIgang)
                {
                    xSkud = inputVali.IntInputValidering(1, 10, "Indtast X koordinat mellem 1 og 10");
                    ySkud = inputVali.IntInputValidering(1, 10, "Indtast y koordinat mellem 1 og 10");
                    skudValideringIgang = inputVali.SkudValidering(spillere[spillerNummer].GetSetSkud, xSkud, ySkud);
                }
                if(spillerNummer == 0)
                {
                    skibeRamt = Skyd(0, 1, xSkud, ySkud);
                }
                else
                {
                    skibeRamt = Skyd(1, 0, xSkud, ySkud);
                }
                if(skibeRamt != 5)
                {
                    Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte");
                    Console.ReadLine();
                    spillerNummer++;
                    if(spillerNummer == 2)
                    {
                        spillerNummer = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Tillykke du har sunket alle modstanderen skibe, du vandt.");
                    spilIgang = false;
                }

            }
        }
        private int Skyd(int spillerNummer, int modSpillerNummer, int xSkud, int ySkud)
        {
            bool skibRamt = false;
            spillere[spillerNummer].GetSetSkud.Add(new Koordinat(xSkud, ySkud, true));
            spillere[spillerNummer].GetSetSkudGrid.GetSetGridKoords.Add(new Koordinat(xSkud, ySkud, true));
            for (int i = 0; i < spillere[modSpillerNummer].GetSetSkibe.Count; i++)
            {
                for (int j = 0; j < spillere[modSpillerNummer].GetSetSkibe[i].GetSetKoordinater.Count; j++)
                {
                    if (xSkud == spillere[modSpillerNummer].GetSetSkibe[i].GetSetKoordinater[j].GetSetX && ySkud == spillere[modSpillerNummer].GetSetSkibe[i].GetSetKoordinater[j].GetSetY)
                    {
                        skibRamt = true;
                        spillere[modSpillerNummer].GetSetSkibeRamt += 1;
                        spillere[modSpillerNummer].GetSetSkibe[i].GetSetKoordinater[j].GetSetRamtStatus = true;
                        spillere[modSpillerNummer].GenSkibGrid();
                    }
                }
            }
            if(skibRamt == false)
            {
                spillere[modSpillerNummer].GetSetModstanderMissedSkud.Add(new Koordinat(xSkud, ySkud, true));
                spillere[modSpillerNummer].GenSkibGrid();
            }
            return spillere[modSpillerNummer].GetSetSkibeRamt;
        }
    }
}
