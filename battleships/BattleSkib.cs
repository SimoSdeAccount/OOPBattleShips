using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class BattleSkib : Skib
    {
        public BattleSkib(string inRetning, int inStartX, int inStartY)
        {
            retning = inRetning;
            startX = inStartX;
            startY = inStartY;
            KoordGen(4);
        }
    }
}
