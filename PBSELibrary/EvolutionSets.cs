using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class EvolutionSets
    {
        public string InternalName { get; set; }
        public string EvolutionMethod { get; set; }
        public string EvolutionParameter { get; set; }
        public string Identification
        {
            get
            {
                return $"{ InternalName }, { EvolutionMethod}, {EvolutionParameter}";
            }
        }
        public string Generation
        {
            get
            {
                return $"{ InternalName },{ EvolutionMethod },{ EvolutionParameter }";
            }
        }
        public EvolutionSets()
        {
            InternalName = null;
            EvolutionMethod = null;
            EvolutionParameter = null;
        }
    }
}
