using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class EncounterSets
    {
        public string EncounterMethod { get; set; }
        public int Density { get; set; }
        public Encounters[] EncounterPokemons { get; set; }

        public EncounterSets()
        {
            EncounterMethod = null;
            Density = 0;
            EncounterPokemons = new Encounters[0];
        }
        public string Identification
        {
            get
            {
                return $"{ EncounterMethod }({ Density})";
            }
        }
    }
}
