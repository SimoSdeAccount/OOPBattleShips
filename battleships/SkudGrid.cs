using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class SkudGrid : Grid
    {
        public SkudGrid(List<Koordinat> inGridKoords)
        {
            gridKoords = inGridKoords;
        }
        public void PrintGrid()
        {
            string yLetters = "ABCDEFGHIJ";
            bool hasFoundCoord = false;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (j == 0 && i == 0)
                    {
                        Console.Write("   ");
                    }

                    if (j == 0 && i != 0)
                    {
                        Console.Write(" " + yLetters[i - 1] + " ");
                    }

                    if (i == 0 && j != 0)
                    {
                        if (j < 10)
                        {
                            Console.Write(" " + j.ToString() + " ");
                        }
                        else
                        {
                            Console.Write(" " + j.ToString());
                        }
                    }
                    if (j != 0 && i != 0)
                    {
                        for (int k = 0; k < gridKoords.Count; k++)
                        {
                            if (gridKoords[k].GetSetX == j && gridKoords[k].GetSetY == i)
                            {
                                hasFoundCoord = true;
                                Console.Write(" X ");
                            }
                        }
                        if (hasFoundCoord == true)
                        {
                            hasFoundCoord = false;
                            continue;
                        }
                        else
                        {
                            Console.Write(" 0 ");
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
