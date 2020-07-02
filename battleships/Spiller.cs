using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    class Spiller
    {
        public Spiller(List<Skib> inSkibe, string inNavn) 
        {
            objId++;
            id = objId;
            skibe = inSkibe;
            skibeRamt = 0;
            navn = inNavn;
            skudGrid = new SkudGrid(new List<Koordinat>());
            skud = new List<Koordinat>();
            modstanderMissedSkud = new List<Koordinat>();
            GenSkibGrid();
        }
        private static int objId = 0;
        private int id;
        private string navn;
        private List<Skib> skibe;
        private int skibeRamt;
        private SkibGrid skibGrid;
        private SkudGrid skudGrid; 
        private List<Koordinat> skud;
        private List<Koordinat> modstanderMissedSkud;

        public int GetSetId
        {
            get { return id; }
            set { id = value; }
        }
        public string GetSetNavn
        {
            get { return navn; }
            set { navn = value; }
        }
        public List<Skib> GetSetSkibe
        {
            get { return skibe; }
            set { skibe = value; }
        }
        public int GetSetSkibeRamt
        {
            get { return skibeRamt; }
            set { skibeRamt = value; }
        }
        public List<Koordinat> GetSetSkud
        {
            get { return skud; }
            set { skud = value; }
        }
        public SkibGrid GetSetSkibGrid
        {
            get { return skibGrid; }
            set { skibGrid = value; }
        }
        public SkudGrid GetSetSkudGrid
        {
            get { return skudGrid; }
            set { skudGrid = value; }
        }
        public List<Koordinat> GetSetModstanderMissedSkud
        {
            get { return modstanderMissedSkud; }
            set { modstanderMissedSkud = value; }
        }
        public void GenSkibGrid()
        {
            List<Koordinat> alleSkibKoords = new List<Koordinat>();
            for (int i = 0; i < skibe.Count; i++)
            {
                for (int j = 0; j < skibe[i].GetSetKoordinater.Count; j++)
                {
                    alleSkibKoords.Add(skibe[i].GetSetKoordinater[j]);
                }
            }
            skibGrid = new SkibGrid(alleSkibKoords, modstanderMissedSkud);
        }
    }
}