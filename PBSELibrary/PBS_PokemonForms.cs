using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSELibrary
{
    public class PBS_PokemonForms
    {
        public string PokemonID { get; set; }
        public int FormID { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string[] Types { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spd { get; set; }
        public int Satk { get; set; }
        public int Sdef { get; set; }
        public int BaseExp { get; set; }
        public int HpEV { get; set; }
        public int AtkEV { get; set; }
        public int DefEV { get; set; }
        public int SpdEV { get; set; }
        public int SatkEV { get; set; }
        public int SdefEV { get; set; }
        public int CatchRate { get; set; }
        public int Happiness { get; set; }
        public string[] Abilities { get; set; }
        public string[] HiddenAbility { get; set; }
        public MoveSets[] Moves { get; set; }
        public string[] TutorMoves { get; set; }
        public string[] Eggmoves { get; set; }
        public string[] EggGroups { get; set; }
        public int HatchSteps { get; set; }
        public string[] Offspring { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Habitat { get; set; }
        public string Category { get; set; }
        public string Pokedex { get; set; }
        public string FormName { get; set; }
        public int Generation { get; set; }
        public string Flags { get; set; }
        public string WildItemCommon { get; set; }
        public string WildItemUncommon { get; set; }
        public string WildItemRare { get; set; }
        public EvolutionSets[] Evolution { get; set; }
        public string MegaStone { get; set; }
        public string MegaMove { get; set; }
        public int MegaMessage { get; set; }
        public int UnmegaForm { get; set; }
        public int PokedexForm { get; set; }
        public string Identification
        {
            get
            {
                return $"{ PokemonID }_{ FormID }";
            }
        }

        public int[] BaseStats
        {
            get
            {
                return new int[] { Hp, Atk, Def, Spd, Satk, Sdef };
            }
        }

        public int[] EffortPoints
        {
            get
            {
                return new int[] { HpEV, AtkEV, DefEV, SpdEV, SatkEV, SdefEV };
            }
        }

        public PBS_PokemonForms()
        {
            PokemonID = null;
            FormID = 1;
            Types = new string[0];
            Hp = -1;
            Atk = -1;
            Def = -1;
            Spd = -1;
            Satk = -1;
            Sdef = -1;
            BaseExp = -1;
            HpEV = -1;
            AtkEV = -1;
            DefEV = -1;
            SpdEV = -1;
            SatkEV = -1;
            SdefEV = -1;
            CatchRate = -1;
            Happiness = -1;
            Abilities = new string[0];
            HiddenAbility = new string[0];
            Moves = new MoveSets[0];
            TutorMoves = new string[0];
            Eggmoves = new string[0];
            EggGroups = new string[0];
            HatchSteps = -1;
            Offspring = new string[0];
            Height = -1;
            Weight = -1;
            Color = null;
            Shape = null;
            Habitat = null;
            Category = null;
            Pokedex = null;
            FormName = null;
            Generation = -1;
            Flags = "";
            WildItemCommon = null;
            WildItemUncommon = null;
            WildItemRare = null;
            Evolution = new EvolutionSets[0];
            MegaStone = null;
            MegaMove = null;
            MegaMessage = -1;
            UnmegaForm = -1;
            PokedexForm = -1;
        }
    }
}
