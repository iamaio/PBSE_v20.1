using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class Encounters
    {
        public int EncounterChance { get; set; }
        public string EncounterSpecies { get; set; }
        public int EncounterForm { get; set; }
        public int EncounterMinLevel { get; set; }
        public int EncounterMaxLevel { get; set; }

        public Encounters()
        {
            EncounterChance = 100;
            EncounterSpecies = "CHARMANDER";
            EncounterForm = 0;
            EncounterMinLevel = 1;
            EncounterMaxLevel = 1;
        }
        public string Identification
        {
            get
            {
                if (EncounterForm > 0)
                {
                    return $"({EncounterChance}){ EncounterSpecies }_{EncounterForm}: { EncounterMinLevel } - { EncounterMaxLevel }";
                }
                return $"({EncounterChance}){ EncounterSpecies }: { EncounterMinLevel } - { EncounterMaxLevel }";
            }
        }
    }
}
