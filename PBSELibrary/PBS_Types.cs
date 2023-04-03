using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_Types
    {
        public string ID { get; set; }
        public int IconPosition { get; set; }
        public string Name { get; set; }
        public string IsSpecialType { get; set; }
        public string IsPseudoType { get; set; }
        public string[] Weaknesses { get; set; }
        public string[] Resistances { get; set; }
        public string[] Immunities { get; set; }

        public PBS_Types()
        {
            ID = null;
            Name = null;
            IconPosition = 0;
            IsPseudoType = null;
            IsSpecialType = null;
            Weaknesses = new string[0];
            Resistances = new string[0];
            Immunities = new string[0];
        }
    }
}
