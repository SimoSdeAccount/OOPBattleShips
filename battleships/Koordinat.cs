using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Koordinat
    {
        public Koordinat(int inX, int inY, bool inRamtStatus)
        {
            x = inX;
            y = inY;
            ramtStatus = inRamtStatus;
        }
        public Koordinat(int inX, int inY)
        {
            x = inX;
            y = inY;
            ramtStatus = false;
        }
        private int x;
        private int y;
        private bool ramtStatus;

        public int GetSetX
        {
            get { return x; }
            set { x = value; }        
        }

        public int GetSetY
        {
            get { return y; }
            set { y = value; }
        }
        public bool GetSetRamtStatus
        {
            get { return ramtStatus; }
            set { ramtStatus = value; }
        }
    }
}
