using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_Trainers
    {
        public string TrainerType { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string[] Items { get; set; }
        public string LoseText { get; set; }
        public Battlers[] Battlers { get; set; }
        public string Identification
        {
            get
            {
                return $"{ TrainerType } { Name }, {ID}";
            }
        }

        public PBS_Trainers()
        {
            TrainerType = null;
            Name = null;
            ID = 0;
            Items = new string[0] { };
            Battlers = new Battlers[0] { };
        }
    }
}
