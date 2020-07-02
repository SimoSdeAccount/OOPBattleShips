using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Grid
    {
        protected List<Koordinat> gridKoords;

        public List<Koordinat> GetSetGridKoords
        {
            get { return gridKoords; }
            set { gridKoords = value; }
        }
    }
}