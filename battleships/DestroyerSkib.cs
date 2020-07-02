using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class DestroyerSkib : Skib
    {
        public DestroyerSkib(string inRetning, int inStartX, int inStartY)
        {
            retning = inRetning;
            startX = inStartX;
            startY = inStartY;
            KoordGen(3);
        }
    }
}
