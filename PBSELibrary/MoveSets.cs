using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class MoveSets
    {
        public int Level { get; set; }
        public string Move { get; set; }
        public string Identification
        {
            get
            {
                return $"{ Level }: { Move }";
            }
        }
        public string Generation
        {
            get
            {
                return $"{ Level },{ Move }";
            }
        }

        public MoveSets()
        {
            Level = 0;
            Move = null;
        }
    }
}
