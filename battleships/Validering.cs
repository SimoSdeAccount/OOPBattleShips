using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Validering
    {
        public string TekstInputValidering(string[] muligeInput, string menuValgTekst)
        {
            string input = string.Empty;
            bool ulovligtValg = true;
            while(ulovligtValg)
            {
                Console.WriteLine(menuValgTekst);
                input = Console.ReadLine();
                for (int i = 0; i < muligeInput.Length; i++)
                {
                    if(input == muligeInput[i])
                    {
                        ulovligtValg = false;
                    }
                }
            }
            return input;
        }
        public int IntInputValidering(int nedreGrændse, int øvreGrændse, string menuValgTekst)
        {
            bool ulovligtInput = true;
            int input = 0;
            while(ulovligtInput)
            {
                Console.WriteLine(menuValgTekst);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if(input >= nedreGrændse && input <= øvreGrændse)
                    {
                        ulovligtInput = false;
                    }
                }
                catch
                {
                    continue;
                }
            }
            return input;
        }
        public bool OpretSkibValidering(string skibType, List<Skib> skibe, string retning, int startX, int startY)
        {
            for (int i = 0; i < skibe.Count; i++)
            {
                Console.WriteLine("skib " + (i + 1).ToString());
                for (int j = 0; j < skibe[i].GetSetKoordinater.Count; j++)
                {
                    Console.WriteLine("X: " + skibe[i].GetSetKoordinater[j].GetSetX.ToString() + "Y: " + skibe[i].GetSetKoordinater[j].GetSetY.ToString());
                }
            }
            return ValiderSkib(genFelterValidering(skibType), skibe, retning, startX, startY);
        }
        public bool SkudValidering(List<Koordinat> skudKoordinater, int skudX, int skudY)
        {
            for (int i = 0; i < skudKoordinater.Count; i++)
            {
                if(skudKoordinater[i].GetSetX == skudX && skudKoordinater[i].GetSetY == skudY)
                {
                    return true;
                }
            }
            return false;
        }
        private bool ValiderSkib(int genFelter, List<Skib> skibe, string retning, int startX, int startY)
        {
            if(retning == "v")
            {
                for (int i = 0; i < genFelter; i++)
                {
                    if((startY + i) > 10)
                    {
                        Console.WriteLine("Du har et y koordinat der er større end 10 og derfor går ud over grid");
                        return true;
                    }
                    else
                    {
                        Koordinat tempKoord = new Koordinat(startX, startY + i);
                        for (int j = 0; j < skibe.Count; j++)
                        {
                            for (int k = 0; k < skibe[j].GetSetKoordinater.Count; k++)
                            {
                                if(tempKoord.GetSetX == skibe[j].GetSetKoordinater[k].GetSetX && tempKoord.GetSetY == skibe[j].GetSetKoordinater[k].GetSetY)
                                {
                                    Console.WriteLine("Dit skibs har koordinat der overlapper med et andet skib. Vælg andet udgangspunkt eller retning");
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if ((startX + i) > 10)
                    {
                        Console.WriteLine("Du har et y koordinat der er større end 10 og derfor går ud over grid");
                        return true;
                    }
                    else
                    {
                        Koordinat tempKoord = new Koordinat(startX + i, startY);
                        for (int j = 0; j < skibe.Count; j++)
                        {
                            for (int k = 0; k < skibe[j].GetSetKoordinater.Count; k++)
                            {
                                if (tempKoord.GetSetX == skibe[j].GetSetKoordinater[k].GetSetX && tempKoord.GetSetY == skibe[j].GetSetKoordinater[k].GetSetY)
                                {
                                    Console.WriteLine("Dit skib har koordinat der overlapper med et andet skib. Vælg andet udgangspunkt eller retning");
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
        private int genFelterValidering(string skibType)
        {
            int genFelter = 0;
            switch(skibType)
            {
                case "CarrierSkib": genFelter = 5; break;
                case "BattleSkib": genFelter = 4; break;
                case "DestroyerSkib": genFelter = 3; break;
                case "SubmarineSkib": genFelter = 3;  break;
                case "PatrolSkib": genFelter = 2;  break;
            }
            return genFelter;
        }
    }
}
