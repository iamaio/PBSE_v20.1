using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_Encounters
    {
        public int MapNumber { get; set; }
        public int MapID { get; set; }
        public string MapName { get; set; }
        public EncounterSets[] Encounters { get; set; }

        public string Identification
        {
            get
            {
                if (MapID == 0)
                {
                    return $"{ MapNumber}: { MapName } ";
                }
                return $"{ MapNumber }_{ MapID }: { MapName} ";
            }
        }
        public int SortingNumber
        {
            get
            {
                return 100 * MapNumber + MapID;
            }
        }
        public PBS_Encounters()
        {
            MapNumber = 0;
            MapID = 0;
            MapName = null;
            Encounters = new EncounterSets[0];
        }
    }
}
