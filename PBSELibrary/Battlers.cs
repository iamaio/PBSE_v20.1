using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class Battlers
    {
        public string Species { get; set; }
        public int Level { get; set; }
        public string Item { get; set; }
        public string[] Moves { get; set; }
        public string Ability { get; set; }
        public int AbilityIndex { get; set; }
        public string Gender { get; set; }
        public int Form { get; set; }
        public string Shiny { get; set; }
        public string SuperShiny { get; set; }
        public string Nature { get; set; }
        public int[] IVS { get; set; }
        public int[] EVS { get; set; }
        public int Happiness { get; set; }
        public string Nickname { get; set; }
        public string Shadow { get; set; }
        public string BallType { get; set; }
        public string Mechanic1 { get; set; }
        public string Mechanic2 { get; set; }
        public string Mechanic3 { get; set; }
        public string Mechanic4 { get; set; }
        public string Mechanic5 { get; set; }
        public string Mechanic6 { get; set; }
        public string Mechanic7 { get; set; }
        public string Mechanic8 { get; set; }
        public string Mechanic9 { get; set; }

        public string Identification
        {
            get
            {
                return $"{ Species }, { Level}";
            }
        }

        public Battlers()
        {
            Species = null;
            Level = -1;
            Item = null;
            Moves = new string[0] { };
            Ability = null;
            AbilityIndex = -1;
            Gender = null;
            Form = 0;
            Shiny = null;
            SuperShiny = null;
            Nature = null;
            IVS = new int[0] { };
            EVS = new int[0] { };
            Happiness = -1;
            Nickname = null;
            Shadow = null;
            BallType = null;
            Mechanic1 = "";
            Mechanic2 = "";
            Mechanic3 = "";
            Mechanic4 = "";
            Mechanic5 = "";
            Mechanic6 = "";
            Mechanic7 = "";
            Mechanic8 = "";
            Mechanic9 = "";
        }
    }
}
