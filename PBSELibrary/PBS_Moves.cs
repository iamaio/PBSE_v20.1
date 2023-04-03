using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_Moves
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
        public int TotalPP { get; set; }
        public string Target { get; set; }
        public int Priority { get; set; }
        public string FunctionCode { get; set; }
        public string Flags { get; set; }
        public int EffectChance { get; set; }
        public string Description { get; set; }

        public PBS_Moves()
        {
            ID = null;
            Name = null;
            Type = null;
            Category = null;
            Power = 0;
            Accuracy = 0;
            TotalPP = 0;
            Target = null;
            Priority = 0;
            FunctionCode = null;           
            Flags = ""; 
            EffectChance = 0;
            Description = null;
        }
    }
}
