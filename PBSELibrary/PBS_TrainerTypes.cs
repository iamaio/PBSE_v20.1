using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_TrainerTypes
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int BaseMoney { get; set; }
        public int SkillLevel { get; set; }
        public string Flags { get; set; }
        public string IntroBGM { get; set; }
        public string BattleBGM { get; set; }
        public string VictoryBGM { get; set; }
        
        
        public PBS_TrainerTypes()
        {
            ID = null;
            Name = null;
            Gender = "Unknown";
            BaseMoney = 30;
            SkillLevel = 0;
            Flags = null;
            IntroBGM = null;
            BattleBGM = null;
            VictoryBGM = null;
        }
    }
}
