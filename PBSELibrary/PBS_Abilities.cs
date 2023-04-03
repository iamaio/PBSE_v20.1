using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_Abilities
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string[] Flags { get; set; }
        public string Description { get; set; }
        
        public PBS_Abilities()
        {
            ID = null;
            Name = null;
            Flags = new string[0];
            Description = null;
        }
    }
}
