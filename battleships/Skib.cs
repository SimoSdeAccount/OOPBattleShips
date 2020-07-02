using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Skib
    {
        public Skib()
        {
            List<Koordinat> koordinaterInst = new List<Koordinat>();
            koordinater = koordinaterInst;
        }
        private int id;
        private List<Koordinat> koordinater;
        protected string retning;
        protected int startX;
        protected int startY;
        public int GetSetId
        {
            get { return id; }
            set { id = value; }
        }
        public List<Koordinat> GetSetKoordinater
        {
            get { return koordinater; }
            set { koordinater = value; }
        }
        public void KoordGen(int loopCount)
        {
            if (retning == "v")
            {
                for (int i = 0; i < loopCount; i++)
                {
                    koordinater.Add(new Koordinat(startX, startY + i));
                }
            }
            else
            {
                for (int i = 0; i < loopCount; i++)
                {
                    koordinater.Add(new Koordinat(startX + i, startY));
                }
            }
        }
    }
}
