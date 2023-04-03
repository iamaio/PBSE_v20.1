using System;
using System.Collections.Generic;

namespace PBSELibrary
{
    public class Global
    {
        public static string ExecutableURL = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..");
        //For debugging comment out the previous line and uncomment the next and add in the game directory
        //public static string ExecutableURL = @"";
        public static Dictionary<string, Config_Flags> FlagDictionary = new Dictionary<string, Config_Flags>();
        public static string[] TargetsArray;
        public static Dictionary<string, string> PocketsDictionary = new Dictionary<string, string>();
        public static string[] ItemFlags;
        public static string[] AbilityFlagsArray;
        public static string[] GenderRateArray;
        public static string[] GrowthRateArray;
        public static string[] EggGroupArray;
        public static string[] ColorArray;
        public static string[] ShapeArray;
        public static string[] HabitatArray;
        public static string[] EvolutionMethodInteger_Array;
        public static string[] EvolutionMethodNull_Array;
        public static string[] EvolutionMethodItem_Array;
        public static string[] EvolutionMethodType_Array;
        public static string[] EvolutionMethodMove_Array;
        public static string[] EvolutionMethodPokemon_Array;
        public static string[] EvolutionMethodString_Array;
        public static string[] EvolutionMethods_Array;
        public static Dictionary<string, int> ConfigEncounterDictionary = new Dictionary<string, int>();
        public static string[] NatureArray;
        public static string[] BallTypeArray;
        public static string[] FieldUseArray;
        public static string[] BattleUseArray;
        public static string[] PokemonFlags;
        public static string[] MoveFlagsArray;
        public static string TextOpener = "notepad.exe";

        public static Dictionary<string, PBS_Abilities> AbilitiesDictionary = new Dictionary<string, PBS_Abilities>();
        public static Dictionary<string, PBS_Types> TypesDictionary = new Dictionary<string, PBS_Types>();
        public static Dictionary<string, PBS_Moves> MovesDictionary = new Dictionary<string, PBS_Moves>();
        public static Dictionary<string, PBS_Items> ItemsDictionary = new Dictionary<string, PBS_Items>();
        public static Dictionary<string, PBS_TrainerTypes> TrainerTypesDictionary = new Dictionary<string, PBS_TrainerTypes>();
        public static Dictionary<string, PBS_Pokemons> PokemonsDictionary = new Dictionary<string, PBS_Pokemons>();
        public static Dictionary<string, PBS_PokemonForms> PokemonFormsDictionary = new Dictionary<string, PBS_PokemonForms>();
        public static Dictionary<string, PBS_Encounters> Encounters_Dictionary = new Dictionary<string, PBS_Encounters>();
        public static Dictionary<string, PBS_Trainers> Trainers_Dictionary = new Dictionary<string, PBS_Trainers>();
        public static Dictionary<int, List<string>> BaseStats_Dictionary = new Dictionary<int, List<string>>();
        public static Dictionary<string, string> BattlerCustomMechanics = new Dictionary<string, string>();

        public static void ResetCompilation()
        {
            FlagDictionary.Clear();
            PocketsDictionary.Clear();
            ConfigEncounterDictionary.Clear();
            AbilitiesDictionary.Clear();
            TypesDictionary.Clear();
            MovesDictionary.Clear();
            ItemsDictionary.Clear();
            TrainerTypesDictionary.Clear();
            PokemonsDictionary.Clear();
            PokemonFormsDictionary.Clear();
            Encounters_Dictionary.Clear();
            Trainers_Dictionary.Clear();
            BaseStats_Dictionary.Clear();
            BattlerCustomMechanics.Clear();
        }
        public static void RefreshStatDictionary()
        {
            BaseStats_Dictionary.Clear();
            foreach (PBS_Pokemons poke in PokemonsDictionary.Values)
            {
                int Total = poke.Hp + poke.Atk + poke.Def + poke.Spd + poke.Satk + poke.Sdef;
                AddBaseStatToDictionary(Total, poke.ID);
            }
            foreach (PBS_PokemonForms poke in PokemonFormsDictionary.Values)
            {
                int Total = poke.Hp + poke.Atk + poke.Def + poke.Spd + poke.Satk + poke.Sdef;
                AddBaseStatToDictionary(Total, $"{poke.PokemonID}_{poke.FormID}");
            }
        }
        private static void AddBaseStatToDictionary(int Total, string Pokemon)
        {
            if (BaseStats_Dictionary.ContainsKey(Total))
            {
                List<string> tempList = BaseStats_Dictionary[Total];
                tempList.Add(Pokemon);
                BaseStats_Dictionary[Total] = tempList;
            }
            else
            {
                List<string> tempList = new List<string>()
                {
                    Pokemon
                };
                BaseStats_Dictionary.Add(Total, tempList);
            }
        }
    }
}
