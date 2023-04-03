using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBS_Editor;
using PBSELibrary;

namespace PBSE_3
{
    public partial class StartUI : Form
    {
        bool HasCompiled = false;
        public StartUI()
        {
            InitializeComponent();
        }

        private void Compile_Button_Click(object sender, EventArgs e)
        {
            if (!RecompilationMessage())
            {
                return;
            }
            label_CompilationStatus.Text = "Status: Compiling";
            label_CompilationStatus.Refresh();
            if (Errors.ErrorList.Count > 0)
            {
                button_OpenErrorLog.Visible = false;
                Errors.ErrorList.Clear();
            }
            CreateNeededFiles();
            CheckRequiredFiles();
            if (Errors.ErrorList.Count == 0)
            {
                CheckConfig();
                CheckAbilities();
                CheckTypes();
                CheckMoves();
                CheckItems();
                CheckTrainerTypes();
                CheckPokemon();
                CheckPokemonForms();
                CheckEncounters();
                CheckTrainers();
            }
            if (Errors.ErrorList.Count > 0)
            {
                label_CompilationStatus.Text = "Status: Invalid";
                PrintErrorsToFile();
                button_OpenErrorLog.Visible = true;
                return;
            }
            button_Backup.Enabled = true;
            button_EditPBS.Enabled = true;
            comboBox_PBS.Visible = true;
            textBox_Backup.Visible = true;
            RefreshBackupStatusLabel();
            label_BackupStatus.Visible = true;
            label_CompilationStatus.Text = "Status: Compiled";
            HasCompiled = true;
            button_Compile.Text = "ReCompile";
        }
        private bool RecompilationMessage()
        {
            if (!HasCompiled)
            {
                return true;
            }
            if (MessageBox.Show("Doing this will discard all unsaved changes. Are you sure you want to recompile?", "Confirm Recompilation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Global.ResetCompilation();
                return true;
            }
            return false;
        }

        private static void PrintErrorsToFile()
        {
            using StreamWriter w = File.AppendText($"{Global.ExecutableURL}\\PBSE\\PBSE_ErrorLog.txt");
            w.WriteLine("Error Log Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine(":");
            foreach (var error in Errors.ErrorList)
            {
                w.WriteLine($"{error.Description}");
            }
            w.WriteLine("-------------------");
            w.Close();
        }

        private static void CreateNeededFiles()
        {
            string basefilepath = Global.ExecutableURL;
            string[] pbsefilepaths = { @"\PBSE\Generated\abilities.txt", @"\PBSE\Generated\types.txt",
            @"\PBSE\Generated\moves.txt", @"\PBSE\Generated\items.txt", @"\PBSE\Generated\trainertypes.txt",
            @"\PBSE\Generated\pokemon.txt", @"\PBSE\Generated\pokemonforms.txt", @"\PBSE\Generated\trainers.txt",
            @"\PBSE\Generated\encounters.txt", @"\PBSE\Generated\Gen_Ability.txt", @"\PBSE\Generated\Gen_Type.txt",
            @"\PBSE\Generated\Gen_Move.txt", @"\PBSE\Generated\Gen_Item.txt", @"\PBSE\Generated\Gen_TrainerType.txt",
            @"\PBSE\Generated\Gen_Pokemon.txt", @"\PBSE\Generated\Gen_Form.txt", @"\PBSE\Generated\Gen_Trainer.txt",
            @"\PBSE\Generated\Gen_Encounter.txt", @"\PBSE\PBSE_ErrorLog.txt"};

            Directory.CreateDirectory($"{basefilepath}\\PBSE\\");
            Directory.CreateDirectory($"{basefilepath}\\PBSE\\Backup\\");
            Directory.CreateDirectory($"{basefilepath}\\PBSE\\Generated\\");

            foreach (var path in pbsefilepaths)
            {
                string tempFilePath = $"{basefilepath}{path}";
                if (!File.Exists(tempFilePath))
                {
                    File.Create($"{tempFilePath}").Close();
                }
            }
        }
        private static void CheckRequiredFiles()
        {
            string basefilepath = Global.ExecutableURL;
            string[] neededfilepaths = { @"\PBS\abilities.txt",
            @"\PBS\types.txt", @"\PBS\moves.txt", @"\PBS\items.txt",
            @"\PBS\trainer_types.txt", @"\PBS\pokemon.txt", @"\PBS\pokemon_forms.txt",
            @"\PBS\trainers.txt", @"\PBS\encounters.txt", @"\PBSE\PBSEConfig.txt"};

            foreach(var path in neededfilepaths)
            {
                if (!File.Exists($"{basefilepath}{path}"))
                {
                    Errors.ErrorList.Add(new Errors($"Missing File: {path}"));
                }
            }
        }

        private static void CheckConfig()
        {
            string ConfigFilePath = $"{Global.ExecutableURL}\\PBSE\\PBSEConfig.txt";
            string[] ConfigFile = File.ReadAllLines(ConfigFilePath);

            string Identifier = "";

            List<string> TargetsList = new();
            List<string> ItemFlags = new();
            List<string> GenderRateList = new();
            List<string> GrowthRateList = new();
            List<string> EggGroupList = new();
            List<string> ColorList = new();
            List<string> HabitatList = new();
            List<string> ShapeList = new();
            List<string> EvolutionMethodInteger_List = new();
            List<string> EvolutionMethodNull_List = new();
            List<string> EvolutionMethodItem_List = new();
            List<string> EvolutionMethodType_List = new();
            List<string> EvolutionMethodMove_List = new();
            List<string> EvolutionMethodPokemon_List = new();
            List<string> EvolutionMethodString_List = new();
            List<string> EvolutionMethods_List = new();
            List<string> NaturesList = new();
            List<string> BallTypesList = new();
            List<string> FieldUseList = new();
            List<string> BattleUseList = new();
            List<string> PokemonFlagsList = new();
            List<string> MoveFlags = new();
            List<string> AbilityFlagsList = new();

            foreach (string line in ConfigFile)
            {
                if (line.Contains('['))
                {
                    Identifier = line.Trim();
                    continue;
                }
                switch (Identifier)
                {
                    case "[AbilityFlags]":
                        AbilityFlagsList.Add(line.Trim());
                        break;
                    case "[MoveFlags]":
                        MoveFlags.Add(line.Trim());
                        break;
                    case "[Targets]":
                        TargetsList.Add(line.Trim());
                        break;
                    case "[Pockets]":
                        Global.PocketsDictionary.Add(line.Split('=')[0], line.Split('=')[1].Trim());
                        break;
                    case "[ItemFlags]":
                        ItemFlags.Add(line.Trim());
                        break;
                    case "[GenderRate]":
                        GenderRateList.Add(line.Trim());
                        break;
                    case "[GrowthRate]":
                        GrowthRateList.Add(line.Trim());
                        break;
                    case "[EggGroup]":
                        EggGroupList.Add(line.Trim());
                        break;
                    case "[Color]":
                        ColorList.Add(line.Trim());
                        break;
                    case "[Habitat]":
                        HabitatList.Add(line.Trim());
                        break;
                    case "[Shape]":
                        ShapeList.Add(line.Trim());
                        break;
                    case "[EvolutionMethods]":
                        string method = line.Split('=')[0].Trim();
                        string parameter = line.Split('=')[1].Trim();
                        switch (parameter)
                        {
                            case "Integer":
                                EvolutionMethodInteger_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            case "null":
                                EvolutionMethodNull_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            case "Item":
                                EvolutionMethodItem_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            case "Type":
                                EvolutionMethodType_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            case "Move":
                                EvolutionMethodMove_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            case "Pokemon":
                                EvolutionMethodPokemon_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            case "String":
                                EvolutionMethodString_List.Add(method);
                                EvolutionMethods_List.Add(method);
                                break;
                            default:
                                Errors.ErrorList.Add(new Errors($"Config File: Unknown evolution parameter: {line}"));
                                break;
                        }
                        break;
                    case "[Encounters]":
                        Global.ConfigEncounterDictionary.Add(line.Split('=')[0].Trim(), GetInt(line.Split('=')[1].Trim(), $"Config File: Encounters: {line}", 0));
                        break;
                    case "[Natures]":
                        NaturesList.Add(line.Trim());
                        break;
                    case "[BallTypes]":
                        BallTypesList.Add(line.Trim());
                        break;
                    case "[FieldUse]":
                        FieldUseList.Add(line.Trim());
                        break;
                    case "[BattleUse]":
                        BattleUseList.Add(line.Trim());
                        break;
                    case "[PokemonFlags]":
                        PokemonFlagsList.Add(line.Trim());
                        break;
                    case "[TextOpener]":
                        Global.TextOpener = line.Trim();
                        break;
                    case "[CustomBattlerMechanics]":
                        Global.BattlerCustomMechanics.Add(line.Split('=')[0].Trim(), line.Split('=')[1].Trim());
                        break;
                    default:
                        Errors.ErrorList.Add(new Errors($"Config File: Unknown Tag: {Identifier}"));
                        break;
                }
            }
            Global.ItemFlags = ItemFlags.ToArray();
            Global.TargetsArray = TargetsList.ToArray();
            Global.GenderRateArray = GenderRateList.ToArray();
            Global.GrowthRateArray = GrowthRateList.ToArray();
            Global.EggGroupArray = EggGroupList.ToArray();
            Global.ColorArray = ColorList.ToArray();
            Global.HabitatArray = HabitatList.ToArray();
            Global.ShapeArray = ShapeList.ToArray();
            Global.EvolutionMethodInteger_Array = EvolutionMethodInteger_List.ToArray();
            Global.EvolutionMethodNull_Array = EvolutionMethodNull_List.ToArray();
            Global.EvolutionMethodItem_Array = EvolutionMethodItem_List.ToArray();
            Global.EvolutionMethodType_Array = EvolutionMethodType_List.ToArray();
            Global.EvolutionMethodMove_Array = EvolutionMethodMove_List.ToArray();
            Global.EvolutionMethodPokemon_Array = EvolutionMethodPokemon_List.ToArray();
            Global.EvolutionMethodString_Array = EvolutionMethodString_List.ToArray();
            Global.EvolutionMethods_Array = EvolutionMethods_List.ToArray();
            Global.NatureArray = NaturesList.ToArray();
            Global.BallTypeArray = BallTypesList.ToArray();
            Global.FieldUseArray = FieldUseList.ToArray();
            Global.BattleUseArray = BattleUseList.ToArray();
            Global.PokemonFlags = PokemonFlagsList.ToArray();
            Global.MoveFlagsArray = MoveFlags.ToArray();
            Global.AbilityFlagsArray = AbilityFlagsList.ToArray();
        }

        private static void CheckAbilities()
        {
            string AbilitiesFilepath = $"{Global.ExecutableURL}\\PBS\\abilities.txt";
            List<string> AbilityLines = File.ReadAllLines(AbilitiesFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_Abilities thisAbility = new();
            for (int i = 0; i < AbilityLines.Count; i++)
            {
                string line = AbilityLines[i];
                if (!CheckForEmptyLine(line, "Abilities"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisAbility = new();
                    thisAbility.ID = line.Replace("[", "").Replace("]", "").Trim();
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Name":
                            thisAbility.Name = line.Split('=')[1].Trim();
                            break;
                        case "Flags":
                            thisAbility.Flags = GetAbilityFlags(line.Split('=')[1].Trim(), "Abilities:");
                            break;
                        case "Description":
                            thisAbility.Description = line.Split('=')[1].Trim();
                            break;

                    }
                }
                bool TimetoAddThisAbility = (i == AbilityLines.Count - 1);
                if (!TimetoAddThisAbility)
                {
                    TimetoAddThisAbility = AbilityLines[i + 1].Contains(']');
                }
                if (TimetoAddThisAbility)
                {
                    if(thisAbility.ID == null)
                    {
                        thisAbility.ID = "Error";
                        Errors.ErrorList.Add(new Errors($"Abilities: An ability lacks an ID."));
                    }
                    if (!Global.AbilitiesDictionary.ContainsKey(thisAbility.ID))
                    {
                        Global.AbilitiesDictionary.Add(thisAbility.ID, thisAbility);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Abilities: {thisAbility.ID} is repeated."));
                    }
                }
            }
        }

        private static void CheckTypes()
        {
            string TypesFilepath = $"{Global.ExecutableURL}\\PBS\\types.txt";
            List<string> TypeLines = File.ReadAllLines(TypesFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_Types thisType = new();
            List<string> usedTypes = new();

            for (int i = 0; i < TypeLines.Count; i++)
            {
                string line = TypeLines[i];
                if (!CheckForEmptyLine(line, "Types"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisType = new();
                    thisType.ID = line.Replace("[", "").Replace("]", "").Trim();
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Name":
                            thisType.Name = line.Split('=')[1].Trim();
                            break;
                        case "IconPosition":
                            thisType.IconPosition = GetInt(line.Split('=')[1].Trim(), $"Types ({ thisType.ID })", -1);
                            break;
                        case "IsPseudoType":
                            thisType.IsPseudoType = line.Split('=')[1].Trim();
                            break;
                        case "IsSpecialType":
                            thisType.IsSpecialType = line.Split('=')[1].Trim();
                            break;
                        case "Weaknesses":
                            thisType.Weaknesses = line.Split('=')[1].Trim().Split(',');
                            usedTypes = AddTypesWithPendingValidation(line.Split('=')[1].Trim().Split(','), usedTypes);
                            break;
                        case "Resistances":
                            thisType.Resistances = line.Split('=')[1].Trim().Split(',');
                            usedTypes = AddTypesWithPendingValidation(line.Split('=')[1].Trim().Split(','), usedTypes);
                            break;
                        case "Immunities":
                            thisType.Immunities = line.Split('=')[1].Trim().Split(',');
                            usedTypes = AddTypesWithPendingValidation(line.Split('=')[1].Trim().Split(','), usedTypes);
                            break;
                    }
                }

                bool TimeToAddThisType = (i == TypeLines.Count -1);
                if (!TimeToAddThisType)
                {
                    TimeToAddThisType = TypeLines[i + 1].Contains(']');
                }
                if (TimeToAddThisType)
                {
                    if (thisType.ID == null)
                    {
                        thisType.ID = "Error";
                        Errors.ErrorList.Add(new Errors($"Types: Type lacks an ID."));
                    }
                    if (!Global.TypesDictionary.ContainsKey(thisType.ID))
                    {
                        Global.TypesDictionary.Add(thisType.ID, thisType);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Types: {thisType.ID} is repeated."));
                    }
                }
            }
            ValidatePendingTypes(usedTypes);
        }

        private static void CheckMoves()
        {
            string MovesFilepath = $"{Global.ExecutableURL}\\PBS\\moves.txt";
            List<string> MoveLines = File.ReadAllLines(MovesFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_Moves thisMove = new();

            for (int i = 0; i < MoveLines.Count; i++)
            {
                string line = MoveLines[i];
                if (!CheckForEmptyLine(line, "Moves"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisMove = new();
                    thisMove.ID = line.Replace("[", "").Replace("]", "").Trim();
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Name":
                            thisMove.Name = line.Split('=')[1].Trim();
                            break;
                        case "Type":
                            thisMove.Type = GetType(line.Split('=')[1].Trim(), $"Moves: ({ thisMove.ID }", null);
                            break;
                        case "Category":
                            thisMove.Category = GetCategory(line.Split('=')[1].Trim(), $"Moves: ({ thisMove.ID })", null);
                            break;
                        case "Power":
                            thisMove.Power = GetInt(line.Split('=')[1], $"Moves: ({ thisMove.ID })", -1);
                            break;
                        case "Accuracy":
                            thisMove.Accuracy = GetInt(line.Split('=')[1], $"Moves: ({ thisMove.ID })", -1);
                            break;
                        case "TotalPP":
                            thisMove.TotalPP = GetInt(line.Split('=')[1], $"Moves: ({ thisMove.ID })", -1);
                            break;
                        case "Target":
                            thisMove.Target = GetTarget(line.Split('=')[1].Trim(), $"Moves: ({ thisMove.ID })", null);
                            break;
                        case "Priority":
                            thisMove.Priority = GetIntegerBetweenMinMax(line.Split('=')[1], -10, 10,
                                $"Moves: { thisMove.ID }'s Priority", -11);
                            break;
                        case "FunctionCode":
                            thisMove.FunctionCode = line.Split('=')[1].Trim();
                            break;
                        case "Flags":
                            thisMove.Flags = GetFlag(line.Split('=')[1].Trim(), $"Moves: ({ thisMove.ID })");
                            break;
                        case "EffectChance":
                            thisMove.EffectChance = GetInt(line.Split('=')[1], $"Moves: ({ thisMove.ID })", -1);
                            break;
                        case "Description":
                            thisMove.Description = line.Split('=')[1].Trim();
                            break;
                    }
                }
                bool TimeToAddThisMove = (i == MoveLines.Count - 1);
                if (!TimeToAddThisMove)
                {
                    TimeToAddThisMove = MoveLines[i + 1].Contains(']');
                }
                if (TimeToAddThisMove)
                {
                    if (thisMove.ID == null)
                    {
                        thisMove.ID = "Error";
                        Errors.ErrorList.Add(new Errors($"Moves: Move lacks an ID."));
                    }
                    if (!Global.MovesDictionary.ContainsKey(thisMove.ID))
                    {
                        Global.MovesDictionary.Add(thisMove.ID, thisMove);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Moves: {thisMove.ID} is repeated."));
                    }
                }
            }
        }

        private static void CheckItems()
        {
            string ItemsFilepath = $"{Global.ExecutableURL}\\PBS\\items.txt";
            List<string> ItemLines = File.ReadAllLines(ItemsFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_Items thisItem = new();

            for (int i = 0; i < ItemLines.Count; i++)
            {
                string line = ItemLines[i];
                if (!CheckForEmptyLine(line, "Items"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisItem = new();
                    thisItem.ID = line.Replace("[", "").Replace("]", "").Trim();
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Name":
                            thisItem.Name = line.Split('=')[1].Trim();
                            break;
                        case "NamePlural":
                            thisItem.NamePlural = line.Split('=')[1].Trim();
                            break;
                        case "Pocket":
                            thisItem.Pocket = GetPocket(line.Split('=')[1].Trim(), null);
                            break;
                        case "Price":
                            thisItem.Price = GetInt(line.Split('=')[1], $"Items: ({ thisItem.ID })", -1);
                            break;
                        case "SellPrice":
                            thisItem.SellPrice = GetInt(line.Split('=')[1], $"Items: ({ thisItem.ID })", -1);
                            break;
                        case "FieldUse":
                            thisItem.FieldUse = GetUsabilityOut(line.Split('=')[1].Trim(), $"Items: ({ thisItem.ID })", null);
                            break;
                        case "BattleUse":
                            thisItem.BattleUse = GetUsabilityIn(line.Split('=')[1].Trim(), $"Items: ({ thisItem.ID })", null);
                            break;
                        case "Consumable":
                            thisItem.Consumable = line.Split('=')[1].Trim();
                            break;
                        case "Flags":
                            thisItem.Flags = GetSpecialItem(line.Split('=')[1].Trim(), $"Items: ({ thisItem.ID })");
                            break;
                        case "Move":
                            thisItem.Move = GetMove(line.Split('=')[1].Trim(), $"Items: ({ thisItem.ID })", null, true);
                            break;
                        case "Description":
                            thisItem.Description = line.Split('=')[1].Trim();
                            break;
                        case "HeldDescription":
                            thisItem.HeldDescription = line.Split('=')[1].Trim();
                            break;
                    }
                }
                bool TimeToAddThisItem = (i == ItemLines.Count - 1);
                if (!TimeToAddThisItem)
                {
                    TimeToAddThisItem = ItemLines[i + 1].Contains(']');
                }
                if (TimeToAddThisItem)
                {
                    if (thisItem.ID == null)
                    {
                        thisItem.ID = "Error";
                        Errors.ErrorList.Add(new Errors($"Items: Item lacks an ID."));
                    }
                    if (!Global.ItemsDictionary.ContainsKey(thisItem.ID))
                    {
                        Global.ItemsDictionary.Add(thisItem.ID, thisItem);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Items: {thisItem.ID} is repeated."));
                    }
                }
            }
        }

        private static void CheckTrainerTypes()
        {
            string TrainerTypesFilepath = $"{Global.ExecutableURL}\\PBS\\trainer_types.txt";
            List<string> TrainerTypesLines = File.ReadAllLines(TrainerTypesFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_TrainerTypes thisTrainerType = new();

            for (int i = 0; i < TrainerTypesLines.Count; i++)
            {
                string line = TrainerTypesLines[i];
                if (!CheckForEmptyLine(line, "TrainerTypes"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisTrainerType = new();
                    thisTrainerType.ID = line.Replace("[", "").Replace("]", "").Trim();
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Name":
                            thisTrainerType.Name = line.Split('=')[1].Trim();
                            break;
                        case "Gender":
                            thisTrainerType.Gender = GetTrainerGender(line.Split('=')[1].Trim(), $"TrainerTypes: ({ thisTrainerType.ID })", null);
                            break;
                        case "BaseMoney":
                            thisTrainerType.BaseMoney = GetTrainerTypeIntegerHigherEqual(line.Split('=')[1], 0, $"TrainerTypes: ({ thisTrainerType.ID })");
                            break;
                        case "SkillLevel":
                            thisTrainerType.SkillLevel = GetTrainerTypeIntegerHigherEqual(line.Split('=')[1], 0, $"TrainerTypes: ({ thisTrainerType.ID })");
                            break;
                        case "Flags":
                            thisTrainerType.Flags = line.Split('=')[1];
                            break;
                        case "IntroBGM":
                            thisTrainerType.IntroBGM = CheckForPathExistance(line.Split('=')[1].Trim(), @"\Audio\BGM\", $"TrainerTypes: ({ thisTrainerType.ID })", true);
                            break;
                        case "BattleBGM":
                            thisTrainerType.BattleBGM = CheckForPathExistance(line.Split('=')[1].Trim(), @"\Audio\BGM\", $"TrainerTypes: ({ thisTrainerType.ID })", true);
                            break;
                        case "VictoryBGM":
                            thisTrainerType.VictoryBGM = CheckForPathExistance(line.Split('=')[1].Trim(), @"\Audio\BGM\", $"TrainerTypes: ({ thisTrainerType.ID })", true);
                            break;
                    }
                }
                bool TimeToAddThisTrainerType = (i == TrainerTypesLines.Count - 1);
                if (!TimeToAddThisTrainerType)
                {
                    TimeToAddThisTrainerType = TrainerTypesLines[i + 1].Contains(']');
                }
                if (TimeToAddThisTrainerType)
                {
                    if (thisTrainerType.ID == null)
                    {
                        thisTrainerType.ID = "Error";
                        Errors.ErrorList.Add(new Errors($"TrainerTypes: Trainer Types lacks an ID."));
                    }
                    if (thisTrainerType.SkillLevel == 0)
                    {
                        thisTrainerType.SkillLevel = thisTrainerType.BaseMoney;
                    }
                    if (!Global.TrainerTypesDictionary.ContainsKey(thisTrainerType.ID))
                    {
                        Global.TrainerTypesDictionary.Add(thisTrainerType.ID, thisTrainerType);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"TrainerTypes: {thisTrainerType.ID} is repeated."));
                    }
                }
            }
        }

        private static void CheckPokemon()
        {
            string PokemonsFilepath = $"{Global.ExecutableURL}\\PBS\\pokemon.txt";
            List<string> PokemonLines = File.ReadAllLines(PokemonsFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_Pokemons thisPoke = new();
            List<string> nextEvolution = new();

            for (int i = 0; i < PokemonLines.Count; i++)
            {
                string line = PokemonLines[i];
                if (!CheckForEmptyLine(line, "Pokemons"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisPoke = new();
                    thisPoke.ID = line.Replace("[", "").Replace("]", "");
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Name":
                            thisPoke.Name = line.Split('=')[1].Trim();
                            break;
                        case "Types":
                            thisPoke.Types = GetTypeArray(line.Split('=')[1], $"Pokemons: ({thisPoke.ID}: Types");
                            if (thisPoke.Types.Length > 0)
                            {
                                thisPoke.Type1 = thisPoke.Types[0];
                            }
                            if (thisPoke.Types.Length > 1)
                            {
                                thisPoke.Type2 = thisPoke.Types[1];
                            }
                            break;
                        case "BaseStats":
                            string[] StatsInputsRaw = line.Split('=')[1].Trim().Split(',');
                            int[] BaseStats = GetValidIntegerArray(StatsInputsRaw, 1, 999, $"Pokemons: ({ thisPoke.ID }): BaseStats",
                                true, 6, 6);
                            thisPoke.Hp = BaseStats[0];
                            thisPoke.Atk = BaseStats[1];
                            thisPoke.Def = BaseStats[2];
                            thisPoke.Spd = BaseStats[3];
                            thisPoke.Satk = BaseStats[4];
                            thisPoke.Sdef = BaseStats[5];
                            AddBaseStatToDictionary(BaseStats, thisPoke.ID);
                            break;
                        case "GenderRatio":
                            thisPoke.GenderRatio = GetGenderRate(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID })", null);
                            break;
                        case "GrowthRate":
                            thisPoke.GrowthRate = GetGrowthRate(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID })", null);
                            break;
                        case "BaseExp":
                            thisPoke.BaseExp = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(), 1, $"Pokemons: ({ thisPoke.ID }): BaseEXP", -1);
                            break;
                        case "EVs":
                            string[] EffortPointsInputsRaw = line.Split('=')[1].Trim().Split(',');
                            int[] EffortPoints = GetEffortPoints(line.Trim().Split('=')[1], $"Pokemons: ({thisPoke.ID}) : Effort Points");
                            thisPoke.HpEV = EffortPoints[0];
                            thisPoke.AtkEV = EffortPoints[1];
                            thisPoke.DefEV = EffortPoints[2];
                            thisPoke.SpdEV = EffortPoints[3];
                            thisPoke.SatkEV= EffortPoints[4];
                            thisPoke.SdefEV = EffortPoints[5];
                            break;
                        case "CatchRate":
                            thisPoke.CatchRate = GetIntegerBetweenMinMax(line.Split('=')[1].Trim(), 0, 255, $"Pokemons: ({ thisPoke.ID }): Rareness", -1);
                            break;
                        case "Happiness":
                            thisPoke.Happiness = GetIntegerBetweenMinMax(line.Split('=')[1].Trim(), 0, 255, $"Pokemons: ({ thisPoke.ID }): Happiness", -1);
                            break;
                        case "Abilities":
                            string[] Abilities = line.Split('=')[1].Trim().Split(',');
                            thisPoke.Abilities = GetAbilities(Abilities, $"Pokemons: ({ thisPoke.ID }): Abilities");
                            break;
                        case "HiddenAbilities":
                            string[] HAbilities = line.Split('=')[1].Trim().Split(',');
                            thisPoke.HiddenAbility = GetAbilities(HAbilities, $"Pokemons: ({ thisPoke.ID }): HiddenAbilities");
                            break;
                        case "Moves":
                            string[] RawMoves = line.Split('=')[1].Trim().Split(',');
                            thisPoke.Moves = ConvertMovesToMoveSets(RawMoves, $"Pokemons: ({ thisPoke.ID }): Moves");
                            break;
                        case "TutorMoves":
                            string[] Moves = line.Split('=')[1].Trim().Split(',');
                            thisPoke.TutorMoves = GetMoveArray(Moves, $"Pokemons: ({ thisPoke.ID }): TutorMoves");
                            break;
                        case "EggMoves":
                            if (line.StartsWith("EggMoves = "))
                            {
                                string[] EggMoves = line.Split('=')[1].Trim().Split(',');
                                thisPoke.Eggmoves = GetMoveArray(EggMoves, $"Pokemons: ({ thisPoke.ID }): EggMoves");
                            }
                            break;
                        case "EggGroups":
                            string[] EggGroups = line.Split('=')[1].Trim().Split(',');
                            thisPoke.EggGroups = GetCompatibility(EggGroups, $"Pokemons: ({ thisPoke.ID })");
                            break;
                        case "HatchSteps":
                            thisPoke.HatchSteps = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(),
                                1, $"Pokemons: ({ thisPoke.ID }): StepsToHatch", -1);
                            break;
                        case "Offspring":
                            thisPoke.Offspring = line.Split('=')[1].Trim().Split(',');
                            foreach (var offspring in thisPoke.Offspring)
                            {
                                nextEvolution.Add(offspring);
                            }
                            break;
                        case "Height":
                            thisPoke.Height = GetDecimal(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): Height", -1);
                            break;
                        case "Weight":
                            thisPoke.Weight = GetDecimal(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): Weight", -1);
                            break;
                        case "Color":
                            thisPoke.Color = GetColor(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID })", null);
                            break;
                        case "Shape":
                            thisPoke.Shape = GetShape(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID })", null);
                            break;
                        case "Habitat":
                            thisPoke.Habitat = GetHabitat(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID })", null);
                            break;
                        case "Category":
                            thisPoke.Category = line.Split('=')[1].Trim();
                            break;
                        case "Pokedex":
                            thisPoke.Pokedex = line.Split('=')[1].Trim();
                            break;
                        case "FormName":
                            thisPoke.FormName = line.Split('=')[1].Trim();
                            break;
                        case "Generation":
                            thisPoke.Generation = GetInt(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): Generation", 0);
                            break;
                        case "Flags":
                            thisPoke.Flags = GetPokeFlags(line.Split('=')[1], "Pokemons");
                            break;
                        case "WildItemCommon":
                            thisPoke.WildItemCommon = GetItem(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): WildItemCommon", null);
                            break;
                        case "WildItemUncommon":
                            thisPoke.WildItemUncommon = GetItem(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): WildItemUncommon", null);
                            break;
                        case "WildItemRare":
                            thisPoke.WildItemRare = GetItem(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): WildItemRare", null);
                            break;
                        case "Evolutions":
                            string[] RawEvolutions = line.Split('=')[1].Trim().Split(',');
                            EvolutionSets[] Evolutions = ConvertEvolutionsToEvolutionSets(RawEvolutions, $"Pokemons: ({ thisPoke.ID }): Evolutions", false);
                            thisPoke.Evolution = Evolutions;

                            foreach (var evo in Evolutions)
                            {
                                nextEvolution.Add(evo.InternalName);
                                if (Global.EvolutionMethodPokemon_Array.Contains(evo.EvolutionMethod))
                                {
                                    nextEvolution.Add(evo.EvolutionParameter);
                                }
                            }
                            break;
                        case "Incense":
                            thisPoke.Incense = GetItem(line.Split('=')[1].Trim(), $"Pokemons: ({ thisPoke.ID }): Incense", null);
                            break;
                        default:
                            Errors.ErrorList.Add(new Errors($"Pokemons: { thisPoke.ID } has an invalid property - { line.Split('=')[0] }."));
                            break;
                    }
                }

                bool TimeToAddThisPokemon = (i == PokemonLines.Count - 1);
                if (!TimeToAddThisPokemon)
                {
                    TimeToAddThisPokemon = PokemonLines[i + 1].Contains(']');
                }
                if (TimeToAddThisPokemon)
                {
                    if (thisPoke.ID == null)
                    {
                        thisPoke.ID = "Error";
                        Errors.ErrorList.Add(new Errors($"Pokemons: {thisPoke.ID} lacks an ID."));
                    }
                    if (!Global.PokemonsDictionary.ContainsKey(thisPoke.ID))
                    {
                        Global.PokemonsDictionary.Add(thisPoke.ID, thisPoke);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Pokemons: {thisPoke.ID} is repeated."));
                    }
                }
            }
            ValidatePendingPokemons(nextEvolution, "Pokemons");
        }

        private static void CheckPokemonForms()
        {
            string PokemonFormsFilepath = $"{Global.ExecutableURL}\\PBS\\pokemon_forms.txt";
            List<string> PokemonFormsLines = File.ReadAllLines(PokemonFormsFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_PokemonForms thisForm = new();

            for (int i = 0; i < PokemonFormsLines.Count; i++)
            {
                string line = PokemonFormsLines[i];
                if (!CheckForEmptyLine(line, "PokemonForms"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisForm = new();
                    string[] Header = line.Replace("]", "").Replace("[", "").Trim().Split(',');
                    CheckForInvalidParameterAmount(Header, 2, $"PokemonForms ({ line })");
                    if (PokemonExists(Header[0], $"PokemonForms ({ line })"))
                    {
                        thisForm.PokemonID = Header[0];
                        thisForm.FormID = GetInt(Header[1], $"PokemonForms ({ line })", 1);
                        if (thisForm.FormID > Global.PokemonsDictionary[Header[0]].Forms)
                        {
                            Global.PokemonsDictionary[Header[0]].Forms = thisForm.FormID;
                        }
                    }
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Types":
                            thisForm.Types = GetTypeArray(line.Split('=')[1], $"PokemonForms: ({thisForm.Identification}: Types");
                            if (thisForm.Types.Length > 0)
                            {
                                thisForm.Type1 = thisForm.Types[0];
                            }
                            if (thisForm.Types.Length > 1)
                            {
                                thisForm.Type2 = thisForm.Types[1];
                            }
                            break;

                        case "BaseStats":
                            string[] StatsInputsRaw = line.Split('=')[1].Trim().Split(',');
                            int[] BaseStats = GetValidIntegerArray(StatsInputsRaw, 1, 999, $"PokemonForms: ({ thisForm.Identification }): BaseStats",
                                true, 6, 6);
                            thisForm.Hp = BaseStats[0];
                            thisForm.Atk = BaseStats[1];
                            thisForm.Def = BaseStats[2];
                            thisForm.Spd = BaseStats[3];
                            thisForm.Satk = BaseStats[4];
                            thisForm.Sdef = BaseStats[5];
                            AddBaseStatToDictionary(BaseStats, $"{thisForm.PokemonID}_{thisForm.FormID}");
                            break;
                        case "BaseExp":
                            thisForm.BaseExp = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(), 1, $"PokemonForms: ({ thisForm.Identification }): BaseEXP", -1);
                            break;
                        case "EVs":
                            string[] EffortPointsInputsRaw = line.Split('=')[1].Trim().Split(',');
                            int[] EffortPoints = GetEffortPoints(line.Trim().Split('=')[1], $"PokemonForms: ({thisForm.Identification}) : Effort Points");
                            thisForm.HpEV = EffortPoints[0];
                            thisForm.AtkEV = EffortPoints[1];
                            thisForm.DefEV = EffortPoints[2];
                            thisForm.SpdEV = EffortPoints[3];
                            thisForm.SatkEV = EffortPoints[4];
                            thisForm.SdefEV = EffortPoints[5];
                            break;
                        case "CatchRate":
                            thisForm.CatchRate = GetIntegerBetweenMinMax(line.Split('=')[1].Trim(), 0, 255, $"PokemonForms: ({ thisForm.Identification }): Rareness", -1);
                            break;
                        case "Happiness":
                            thisForm.Happiness = GetIntegerBetweenMinMax(line.Split('=')[1].Trim(), 0, 255, $"PokemonForms: ({ thisForm.Identification }): Happiness", -1);
                            break;
                        case "Abilities":
                            string[] Abilities = line.Split('=')[1].Trim().Split(',');
                            thisForm.Abilities = GetAbilities(Abilities, $"PokemonForms: ({ thisForm.Identification }): Abilities");
                            break;
                        case "HiddenAbilities":
                            string[] HAbilities = line.Split('=')[1].Trim().Split(',');
                            thisForm.HiddenAbility = GetAbilities(HAbilities, $"PokemonForms: ({ thisForm.Identification }): HiddenAbilities");
                            break;
                        case "Moves":
                            string[] RawMoves = line.Split('=')[1].Trim().Split(',');
                            thisForm.Moves = ConvertMovesToMoveSets(RawMoves, $"PokemonForms: ({ thisForm.Identification }): Moves");
                            break;
                        case "TutorMoves":
                            string[] Moves = line.Split('=')[1].Trim().Split(',');
                            thisForm.TutorMoves = GetMoveArray(Moves, $"PokemonForms: ({ thisForm.Identification }): TutorMoves");
                            break;
                        case "EggMoves":
                            string[] EggMoves = line.Split('=')[1].Trim().Split(',');
                            thisForm.Eggmoves = GetMoveArray(EggMoves, $"PokemonForms: ({ thisForm.Identification }): EggMoves");
                            break;
                        case "EggGroups":
                            string[] EggGroups = line.Split('=')[1].Trim().Split(',');
                            thisForm.EggGroups = GetCompatibility(EggGroups, $"PokemonForms: ({ thisForm.Identification })");
                            break;
                        case "HatchSteps":
                            thisForm.HatchSteps = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(),
                                1, $"PokemonForms: ({ thisForm.Identification }): StepsToHatch", -1);
                            break;
                        case "Offspring":
                            thisForm.Offspring = line.Split('=')[1].Trim().Split(',');
                            foreach (var offspring in thisForm.Offspring)
                            {
                                if (!Global.PokemonsDictionary.ContainsKey(thisForm.PokemonID))
                                {
                                    Errors.ErrorList.Add(new Errors($"PokemonForms: { thisForm.Identification } has an invalid offspring - { line.Split('=')[1] }."));
                                }
                            }
                            break;
                        case "Height":
                            thisForm.Height = GetDecimal(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): Height", -1);
                            break;
                        case "Weight":
                            thisForm.Weight = GetDecimal(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): Weight", -1);
                            break;
                        case "Color":
                            thisForm.Color = GetColor(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification })", null);
                            break;
                        case "Shape":
                            thisForm.Shape = GetShape(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification })", null);
                            break;
                        case "Habitat":
                            thisForm.Habitat = GetHabitat(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification })", null);
                            break;
                        case "Category":
                            thisForm.Category = line.Split('=')[1].Trim();
                            break;
                        case "Pokedex":
                            thisForm.Pokedex = line.Split('=')[1].Trim();
                            break;
                        case "FormName":
                            thisForm.FormName = line.Split('=')[1].Trim();
                            break;
                        case "Generation":
                            thisForm.Generation = GetInt(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): Generation", 0);
                            break;
                        case "Flags":
                            thisForm.Flags = GetPokeFlags(line.Split('=')[1], "PokemonForms");
                            break;
                        case "WildItemCommon":
                            thisForm.WildItemCommon = GetItem(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): WildItemCommon", null);
                            break;
                        case "WildItemUncommon":
                            thisForm.WildItemUncommon = GetItem(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): WildItemUncommon", null);
                            break;
                        case "WildItemRare":
                            thisForm.WildItemRare = GetItem(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): WildItemRare", null);
                            break;
                        case "Evolutions":
                            string[] RawEvolutions = line.Split('=')[1].Trim().Split(',');
                            thisForm.Evolution = ConvertEvolutionsToEvolutionSets(RawEvolutions, $"PokemonForms: ({ thisForm.Identification }): Evolutions", true);
                            break;
                        case "MegaStone":
                            thisForm.MegaStone = GetItem(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): MegaStone", null);
                            break;
                        case "MegaMove":
                            thisForm.MegaMove = GetMove(line.Split('=')[1].Trim(), $"PokemonForms: ({ thisForm.Identification }): MegaMove", null, false);
                            break;
                        case "MegaMessage":
                            thisForm.MegaMessage = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(), 0, $"PokemonForms: ({ thisForm.Identification }): MegaMessage", -1);
                            break;
                        case "UnmegaForm":
                            thisForm.UnmegaForm = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(), 0, $"PokemonForms: ({ thisForm.Identification }): UnmegaForm", -1);
                            break;
                        case "PokedexForm":
                            thisForm.PokedexForm = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(), 0, $"PokemonForms: ({ thisForm.Identification }): PokedexForm", -1);
                            break;
                    }
                }
                bool TimeToAddThisForm = (i == PokemonFormsLines.Count - 1);
                if (!TimeToAddThisForm)
                {
                    TimeToAddThisForm = PokemonFormsLines[i + 1].Contains(']');
                }
                if (TimeToAddThisForm)
                {
                    if (!Global.PokemonFormsDictionary.ContainsKey(thisForm.Identification))
                    {
                        Global.PokemonFormsDictionary.Add(thisForm.Identification, thisForm);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"PokemonForms: {thisForm.PokemonID}_{thisForm.FormID} is repeated."));
                    }
                }
            }
        }

        private static void CheckEncounters()
        {
            string EncounterFilepath = $"{Global.ExecutableURL}\\PBS\\encounters.txt";
            List<string> EncounterLines = File.ReadAllLines(EncounterFilepath).Where(s => !s.StartsWith("#")).ToList();

            PBS_Encounters thisEncounter = new();
            EncounterSets thisEncounterSet = new();
            Encounters thisPokemonEncounter = new();
            List<EncounterSets> AllMethodsInthisEncounter = new();
            List<Encounters> PokemonsInThiSEncounterMethod = new();

            for (int i = 0; i < EncounterLines.Count; i++)
            {
                string line = EncounterLines[i];
                if (!CheckForEmptyLine(line, "Encounters"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisEncounter = new();
                    thisEncounterSet = new();
                    thisPokemonEncounter = new();
                    AllMethodsInthisEncounter = new();
                    PokemonsInThiSEncounterMethod = new();
                    string[] Header = line.Split('#')[0].Replace("]", "").Replace("[", "").Trim().Split(',');
                    if (Header.Length != 1)
                    {
                        CheckForInvalidParameterAmount(Header, 2, $"Encounters: ({ line })");
                    }
                    thisEncounter.MapNumber = GetInt(Header[0], $"Encounters: ({ line })", 0);
                    if (Header.Length == 2)
                    {
                        thisEncounter.MapID = GetInt(Header[1], $"Encounters: ({ line })", 0);
                    }
                    AllMethodsInthisEncounter = new();
                }
                if (line.Split('#').Length == 2)
                {
                    thisEncounter.MapName = line.Split('#')[1].Trim();
                }
                if (Global.ConfigEncounterDictionary.ContainsKey(line.Split(',')[0].Trim()))
                {
                    thisEncounterSet = new();
                    thisEncounterSet.EncounterMethod = line.Split(',')[0].Trim();
                    if (line.Split(',').Length == 2)
                    {
                        thisEncounterSet.Density = GetInt(line.Split(',')[1].Trim(), $"Encounters: ({ line })", 0);
                    }
                    PokemonsInThiSEncounterMethod = new();
                }
                if (line.Split(',').Length == 3 || line.Split(',').Length == 4)
                {
                    string[] pokemonline = line.Split(',');
                    thisPokemonEncounter = new();
                    thisPokemonEncounter.EncounterChance = GetIntegerBetweenMinMax(pokemonline[0].Trim(), 0, 100, $"Encounters: ({ line })", 0);
                    if (PokemonExists(pokemonline[1], $"Encounters: ({ line })"))
                    {
                        thisPokemonEncounter.EncounterSpecies = pokemonline[1].Split('_')[0];
                        if (pokemonline[1].Split('_').Length > 1)
                        {
                            thisPokemonEncounter.EncounterForm = GetInt(pokemonline[1].Split('_')[1], $"Encounters: ({ line })", 0);
                        }
                    }
                    thisPokemonEncounter.EncounterMinLevel = GetIntegerHigherOrEqualThan(pokemonline[2], 1, $"Encounters: ({ line })", 0);
                    if (pokemonline.Length == 4)
                    {
                        thisPokemonEncounter.EncounterMaxLevel = GetIntegerHigherOrEqualThan(pokemonline[3], 
                            thisPokemonEncounter.EncounterMinLevel, $"Encounters: ({ line })", 0);
                    }
                    if (thisPokemonEncounter.EncounterMaxLevel == 1)
                    {
                        thisPokemonEncounter.EncounterMaxLevel = thisPokemonEncounter.EncounterMinLevel;
                    }
                    PokemonsInThiSEncounterMethod.Add(thisPokemonEncounter);
                }

                bool TimeToAddThisEncounter = (i == EncounterLines.Count - 1);
                if (!TimeToAddThisEncounter)
                {
                    TimeToAddThisEncounter = EncounterLines[i + 1].Contains(']');
                }
                bool TimeToAddThisEncounterSet = TimeToAddThisEncounter;
                if (!TimeToAddThisEncounterSet)
                {
                    TimeToAddThisEncounterSet = Global.ConfigEncounterDictionary.ContainsKey(EncounterLines[i + 1].Split(',')[0].Trim());
                }

                if (TimeToAddThisEncounterSet)
                {
                    thisEncounterSet.EncounterPokemons = PokemonsInThiSEncounterMethod.ToArray();
                    if (thisEncounterSet.EncounterPokemons.Length > 0)
                    {
                        AllMethodsInthisEncounter.Add(thisEncounterSet);
                    }
                }
                if (TimeToAddThisEncounter)
                {
                    thisEncounter.Encounters = AllMethodsInthisEncounter.ToArray();
                    if (!Global.Encounters_Dictionary.ContainsKey(thisEncounter.Identification))
                    {
                        Global.Encounters_Dictionary.Add(thisEncounter.Identification, thisEncounter);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Encounters: {thisEncounter.Identification} is repeated."));
                    }
                }
            }
        }

        private static void CheckTrainers()
        {
            string TrainerFilepath = $"{Global.ExecutableURL}\\PBS\\trainers.txt";
            List<string> TrainerLines = File.ReadAllLines(TrainerFilepath).Where(s => !s.StartsWith("#")).ToList();
            PBS_Trainers thisTrainer = new();
            List<Battlers> BattlerList = new();
            Battlers thisBattler = new();
            string mechanic1 = Global.BattlerCustomMechanics["Mechanic1"];
            string mechanic2 = Global.BattlerCustomMechanics["Mechanic2"];
            string mechanic3 = Global.BattlerCustomMechanics["Mechanic3"];
            string mechanic4 = Global.BattlerCustomMechanics["Mechanic4"];
            string mechanic5 = Global.BattlerCustomMechanics["Mechanic5"];
            string mechanic6 = Global.BattlerCustomMechanics["Mechanic6"];
            string mechanic7 = Global.BattlerCustomMechanics["Mechanic7"];
            string mechanic8 = Global.BattlerCustomMechanics["Mechanic8"];
            string mechanic9 = Global.BattlerCustomMechanics["Mechanic9"];

            for (int i = 0; i < TrainerLines.Count; i++)
            {
                string line = TrainerLines[i];
                if (!CheckForEmptyLine(line, "Trainers"))
                {
                    continue;
                }
                if (line.Contains(']'))
                {
                    thisTrainer = new();
                    BattlerList = new();
                    thisBattler = new();
                    string[] Header = line.Replace("]", "").Replace("[", "").Trim().Split(',');
                    if (Header.Length != 2)
                    {
                        CheckForInvalidParameterAmount(Header, 3, $"Trainers ({ line })");
                    }
                    thisTrainer.TrainerType = GetTrainerType(Header[0].Trim(), $"Trainers ({ line })");
                    thisTrainer.Name = Header[1];
                    if (Header.Length == 3)
                    {
                        thisTrainer.ID = GetInt(Header[2], $"Trainers ({ line })", 0);
                    }
                }
                if (line.Contains('=') && line.Split('=').Length == 2)
                {
                    switch (line.Split('=')[0].Trim())
                    {
                        case "Items":
                            string[] TrainerItems = line.Split('=')[1].Trim().Split(',');
                            foreach (string item in TrainerItems)
                            {
                                ItemExists(item, $"Trainers ({ line })", false);
                            }
                            thisTrainer.Items = TrainerItems;
                            break;
                        case "LoseText":
                            thisTrainer.LoseText = line.Split('=')[1].Trim();
                            break;
                        case "Pokemon":
                            thisBattler = new();
                            string[] BattlerSpeciesAndLevel = line.Split('=')[1].Trim().Split(',');
                            if (!CheckForInvalidParameterAmount(BattlerSpeciesAndLevel, 2, $"Trainers ({ line })"))
                            {
                                continue;
                            }
                            if (PokemonExists(BattlerSpeciesAndLevel[0], $"Trainers ({ line })"))
                            {
                                thisBattler.Species = BattlerSpeciesAndLevel[0];
                            }
                            thisBattler.Level = GetIntegerHigherOrEqualThan(BattlerSpeciesAndLevel[1], 1, $"Trainers ({ line })", 0);
                            break;
                        case "Item":
                            thisBattler.Item = GetItem(line.Split('=')[1].Trim(), $"Trainers ({ line })", null);
                            break;
                        case "Moves":
                            string[] BattlerMoves = line.Split('=')[1].Trim().Split(',');
                            thisBattler.Moves = GetMoveArray(BattlerMoves, $"Trainers ({ line })");
                            ValidateIntegerProperty(BattlerMoves.Length.ToString(), 1, 4,
                                "BetweenMinAndMax", $"Trainers ({ line }, amount of moves)");
                            break;
                        case "Ability":
                            thisBattler.Ability = GetSingleAbility(line.Split('=')[1].Trim(), $"Trainers ({ line })");
                            break;
                        case "AbilityIndex":
                            thisBattler.AbilityIndex = GetIntegerHigherOrEqualThan(line.Split('=')[1].Trim(), 0, $"Trainers ({ line })", 0);
                            if (thisBattler.Ability != null)
                            {
                                Errors.ErrorList.Add(new Errors($"Trainers: {thisBattler.Identification} cannot have both an Ability and AbilityIndex."));
                            }
                            break;
                        case "Gender":
                            thisBattler.Gender = GetGender(line.Split('=')[1].Trim(), $"Trainers ({ line })");
                            break;
                        case "Form":
                            string BattlerForm = line.Split('=')[1].Trim();
                            if (PokemonExists($"{thisBattler.Species}_{BattlerForm}", $"Trainers ({ line })"))
                            {
                                thisBattler.Form = GetInt(BattlerForm, $"Trainers ({ line })", 0);
                            }
                            break;
                        case "Shiny":
                            if (line.Split('=')[1].Trim() == "yes")
                            {
                                thisBattler.Shiny = "yes";
                            }
                            break;
                        case "SuperShiny":
                            if (line.Split('=')[1].Trim() == "yes")
                            {
                                thisBattler.SuperShiny = "yes";
                            }
                            break;
                        case "Nature":
                            thisBattler.Nature = GetNature(line.Split('=')[1].Trim(), $"Trainers ({ line })");
                            break;
                        case "IV":
                            string[] IVArrayAsString = line.Split('=')[1].Trim().Split(',');
                            thisBattler.IVS = GetValidIntegerArray(IVArrayAsString, 0, 31, $"Trainers: IVs ({ line })", true, 1, 6);
                            break;
                        case "EV":
                            string[] EVArrayAsString = line.Split('=')[1].Trim().Split(',');
                            thisBattler.EVS = GetValidIntegerArray(EVArrayAsString, 0, 255, $"Trainers: EVs ({ line })", true, 1, 6);
                            ValidateEVAmount(thisBattler.EVS, $"Trainers: Total EVs ({ line })");
                            break;
                        case "Happiness":
                            ValidateIntegerProperty(line.Split('=')[1].Trim(), 0, 255,
                                "BetweenMinAndMax", $"Trainers ({ line })");
                            thisBattler.Happiness = GetIntegerBetweenMinMax(line.Split('=')[1].Trim(), 0, 255, $"Trainers ({ line })", -1);
                            break;
                        case "Name":
                            ValidateIntegerProperty(line.Split('=')[1].Trim().Length.ToString(), 1, 10,
                                "BetweenMinAndMax", $"Trainers ({ line })");
                            thisBattler.Nickname = line.Split('=')[1].Trim();
                            break;
                        case "Shadow":
                            if (line.Split('=')[1].Trim() == "yes")
                            {
                                thisBattler.Shadow = "yes";
                            }
                            break;
                        case "Ball":
                            thisBattler.BallType = GetBallType(line.Split('=')[1].Trim(), $"Trainers ({ line })");
                            break;
                        default:
                            if (line.Split('=')[0].Trim() == mechanic1)
                            {
                                thisBattler.Mechanic1 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic2)
                            {
                                thisBattler.Mechanic2 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic3)
                            {
                                thisBattler.Mechanic3 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic4)
                            {
                                thisBattler.Mechanic4 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic5)
                            {
                                thisBattler.Mechanic5 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic6)
                            {
                                thisBattler.Mechanic6 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic7)
                            {
                                thisBattler.Mechanic7 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic8)
                            {
                                thisBattler.Mechanic8 = line.Split('=')[1].Trim();
                            }
                            if (line.Split('=')[0].Trim() == mechanic9)
                            {
                                thisBattler.Mechanic9 = line.Split('=')[1].Trim();
                            }
                            break;
                    }
                }
                bool TimeToAddThisBattler = (i == TrainerLines.Count - 1);
                if (!TimeToAddThisBattler)
                {
                    TimeToAddThisBattler = TrainerLines[i + 1].Contains(']');
                }
                bool TimeToAddThisTrainer = TimeToAddThisBattler;
                if (!TimeToAddThisBattler)
                {
                    TimeToAddThisBattler = (TrainerLines[i + 1].Contains('=') && TrainerLines[i + 1].Split('=')[0].Contains("Pokemon"));
                }
                if (TimeToAddThisBattler && thisBattler.Species != null)
                {
                    BattlerList.Add(thisBattler);
                }
                if (TimeToAddThisTrainer && BattlerList.Count != 0)
                {
                    thisTrainer.Battlers = BattlerList.ToArray();
                    if (!Global.Trainers_Dictionary.ContainsKey(thisTrainer.Identification))
                    {
                        Global.Trainers_Dictionary.Add(thisTrainer.Identification, thisTrainer);
                    }
                    else
                    {
                        Errors.ErrorList.Add(new Errors($"Trainers: {thisTrainer.Identification} is repeated."));
                    }
                }
            }
        }

        private static List<string> AddTypesWithPendingValidation(string[] ArrayWithTypes, List<string> ListToCheck)
        {
            foreach (var item in ArrayWithTypes)
            {
                if (!ListToCheck.Contains(item))
                {
                    ListToCheck.Add(item);
                }
            }
            return ListToCheck;
        }

        private static void ValidatePendingTypes(List<string> usedTypes)
        {
            foreach (string type in usedTypes)
            {
                if (!Global.TypesDictionary.ContainsKey(type))
                {
                    Errors.ErrorList.Add(new Errors($"Types: {type} isn't a valid Type."));
                }
            }
        }

        private static void ValidatePendingPokemons(List<string> usedPokemons, string Error)
        {
            foreach (string poke in usedPokemons)
            {
                if (!Global.PokemonsDictionary.ContainsKey(poke))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {poke} isn't a valid Pokémon."));
                }
            }
        }

        private static int[] GetValidIntegerArray(string[] IntegerArrayAsStrings, int Min, int Max, 
            string Error, bool CheckSize, int MinSize, int Maxsize)
        {
            if (CheckSize && (IntegerArrayAsStrings.Length < MinSize || IntegerArrayAsStrings.Length > Maxsize))
            {
                Errors.ErrorList.Add(new Errors($"{Error}: array has an invalid amount of parameters for this property."));
                return new int[Maxsize];
            }
            List<int> outputIntArray = new();
            foreach (string IntegerToCheck in IntegerArrayAsStrings)
            {
                outputIntArray.Add(GetIntegerBetweenMinMax(IntegerToCheck, Min, Max, Error, Min));
            }
            return outputIntArray.ToArray();
        }

        private static bool TypeExists(string TypeToCheck, string Error)
        {
            bool Exists = Global.TypesDictionary.Keys.Contains(TypeToCheck);
            if (!Exists)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {TypeToCheck} isn't a valid Type."));
            }
            return Exists;
        }

        private static string GetFlag(string StringToCheck, string Error)
        {
            string[] FlagArray = StringToCheck.Trim().Split(',');
            foreach (string flag in FlagArray)
            {
                if (!Global.MoveFlagsArray.Contains(flag))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {flag} isn't a valid Flag."));
                }
            }
            return StringToCheck;
        }

        private static string GetPocket(string StringToCheck, string DefaultWhenError)
        {
            if (Global.PocketsDictionary.ContainsKey(StringToCheck))
            {
                return StringToCheck;
            }
            Errors.ErrorList.Add(new Errors($"Items: {StringToCheck} isn't a valid Pocket."));
            return DefaultWhenError;
        }

        private static string GetUsabilityOut (string StringToCheck, string Error, string DefaultWhenError)
        {
            if (Global.FieldUseArray.Contains(StringToCheck))
            {
                return StringToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {StringToCheck} isn't a valid usability outside battle."));
            return DefaultWhenError;
        }

        private static string GetUsabilityIn(string StringToCheck, string Error, string DefaultWhenError)
        {
            if (Global.BattleUseArray.Contains(StringToCheck))
            {
                return StringToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {StringToCheck} isn't a valid usability in battle."));
            return DefaultWhenError;
        }

        private static string GetSpecialItem(string StringToCheck, string Error)
        {
            string[] ItemFlags = StringToCheck.Trim().Split(',');
            foreach (string flag in ItemFlags)
            {
                if (!Global.ItemFlags.Contains(flag))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {flag} isn't a valid Item Flag."));
                }
            }
            return StringToCheck;
        }

        private static bool PokemonExists(string PokemonToCheck, string Error)
        {
            int PokemonForm = 0;
            if (PokemonToCheck.Split('_').Length == 2)
            {
                PokemonForm = GetInt(PokemonToCheck.Split('_')[1].Trim(), Error, 0);
                PokemonToCheck = PokemonToCheck.Split('_')[0].Trim();
            }
            bool Exists = Global.PokemonsDictionary.ContainsKey(PokemonToCheck);
            if (!Exists)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {PokemonToCheck} isn't a valid Pokemon."));
                return false;
            }
            if (PokemonForm > 0)
            {
                return Global.PokemonsDictionary[PokemonToCheck].Forms >= PokemonForm;
            }
            return Exists;
        }

        private static bool MoveExists(string MoveToCheck, string Error, bool IgnoreNull)
        {
            bool Exists = Global.MovesDictionary.ContainsKey(MoveToCheck);
            if (!Exists)
            {
                if (IgnoreNull && MoveToCheck == "")
                {
                    return true;
                }
                Errors.ErrorList.Add(new Errors($"{Error}: {MoveToCheck} isn't a valid Move."));
            }
            return Exists;
        }

        private static bool ItemExists(string ItemToCheck, string Error, bool IgnoreNull)
        {
            bool Exists = Global.ItemsDictionary.ContainsKey(ItemToCheck);
            if (!Exists)
            {
                if (IgnoreNull && ItemToCheck == "")
                {
                    return true;
                }
                Errors.ErrorList.Add(new Errors($"{Error}: {ItemToCheck} isn't a valid Item."));
            }
            return Exists;
        }

        private static string  GetTrainerType(string TrainerTypeToCheck, string Error)
        {
            if (!Global.TrainerTypesDictionary.ContainsKey(TrainerTypeToCheck))
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {TrainerTypeToCheck} isn't a valid TrainerType."));
            }
            return TrainerTypeToCheck;
        }

        private static bool CheckForEmptyLine(string Line, string Error)
        {
            if (Line == "" || Line == null)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: Contains an empty line."));
                return false;
            }
            return true;
        }

        private static bool CheckForInvalidParameterAmount(string[] Line, int ParameterAmount, string Error)
        {
            if (Line.Length != ParameterAmount)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {Line[0]} has {Line.Length} arguments, expected {ParameterAmount}."));
                return false;
            }
            return true;
        }

        private static string GetGenderRate(string testing_Gender, string Error, string DefaultWhenError)
        {
            if (Global.GenderRateArray.Contains(testing_Gender))
            {
                return testing_Gender;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {testing_Gender} isn't a valid GenderRate."));
            return DefaultWhenError;
        }
        
        private static string GetGrowthRate(string testing_Growth, string Error, string DefaultWhenError)
        {
            if (Global.GrowthRateArray.Contains(testing_Growth))
            {
                return testing_Growth;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {testing_Growth} isn't a valid GrowthRate."));
            return DefaultWhenError;
        }

        private static bool ValidateIntegerProperty(string testing_Int, int Min, int Max, string TypeOfCheck, string Error)
        {
            bool validation = Int32.TryParse(testing_Int, out int newInt);
            if (!validation)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {testing_Int} isn't a valid Integer."));
                return validation;
            }
            switch (TypeOfCheck)
            {
                case "GreaterThanMin":
                    validation = newInt > Min;
                    break;
                case "GreaterThanOrEqualMin":
                    validation = newInt >= Min;
                    break;
                case "LesserThanMax":
                    validation = newInt < Max;
                    break;
                case "LesserThanOrEqualMax":
                    validation = newInt <= Max;
                    break;
                case "BetweenMinAndMax":
                    validation = (newInt >= Min && newInt <= Max);
                    break;
                default:
                    Errors.ErrorList.Add(new Errors($"{Error}: Poor use of ValidateIntegerProperty."));
                    return false;
            }
            if (!validation)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {testing_Int} isn't a valid parameter."));
            }
            return validation;
        }

        private static string[] GetAbilities(string[] Abilities, string Error)
        {
            foreach (string Ability in Abilities)
            {
                if (!Global.AbilitiesDictionary.ContainsKey(Ability))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {Ability} isn't a valid ability."));
                }
            }
            return Abilities;
        }
        private static string GetSingleAbility(string Ability, string Error)
        {
            if (!Global.AbilitiesDictionary.ContainsKey(Ability))
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {Ability} isn't a valid ability."));
            }
            return Ability;
        }

        private static string[] GetMoveArray(string[] RawMoves, string Error)
        {
            foreach (string move in RawMoves)
            {
                if (!Global.MovesDictionary.ContainsKey(move))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {move} isn't a valid move."));
                }
            }
            return RawMoves;
        }

        private static MoveSets[] ConvertMovesToMoveSets(string[] RawMoves, string Error)
        {
            List<MoveSets> ListMoveSets = new();
            for (int i = 0; i < RawMoves.Length-1; i+=2)
            {
                MoveSets thisMoveSet = new();
                thisMoveSet.Level = GetInt(RawMoves[i], Error, 0);
                if (MoveExists(RawMoves[i + 1], Error, false))
                {
                    thisMoveSet.Move = RawMoves[i + 1];
                }
                ListMoveSets.Add(thisMoveSet);
            }
            return ListMoveSets.ToArray();
        }

        private static EvolutionSets[] ConvertEvolutionsToEvolutionSets(string[] RawEvolutions, string Error, bool ValidatePokemon)
        {
            List<EvolutionSets> ListEvolutionSets = new();
            for (int i = 0; i < RawEvolutions.Length-2; i+=3)
            {
                EvolutionSets thisEvolutionSet = new();
                thisEvolutionSet.InternalName = RawEvolutions[i];
                if (ValidatePokemon)
                {
                    PokemonExists(RawEvolutions[i], Error);
                }
                if (ValidEvolutionMethod(RawEvolutions[i+1], RawEvolutions[i+2], Error, ValidatePokemon))
                {
                    thisEvolutionSet.EvolutionMethod = RawEvolutions[i + 1];
                    thisEvolutionSet.EvolutionParameter = RawEvolutions[i + 2];
                }
                ListEvolutionSets.Add(thisEvolutionSet);
            }
            return ListEvolutionSets.ToArray();
        }

        private static bool ValidEvolutionMethod(string EvolutionMethod, string EvolutionParameter, string Error, bool ValidatePokemon)
        {
            if (Global.EvolutionMethodInteger_Array.Contains(EvolutionMethod))
            {
                return Int32.TryParse(EvolutionParameter, out int p);
            }
            if (Global.EvolutionMethodItem_Array.Contains(EvolutionMethod))
            {
                return ItemExists(EvolutionParameter, Error, false);
            }
            if (Global.EvolutionMethodString_Array.Contains(EvolutionMethod))
            {
                return true;
            }
            if (Global.EvolutionMethodMove_Array.Contains(EvolutionMethod))
            {
                return MoveExists(EvolutionParameter, Error, false);
            }
            if (Global.EvolutionMethodNull_Array.Contains(EvolutionMethod))
            {
                if (EvolutionParameter == "")
                {
                    return true;
                }
                Errors.ErrorList.Add(new Errors($"{Error}: {EvolutionMethod} requires an empty parameter, " +
                    $"received {EvolutionParameter}."));
                return false;
            }
            if (Global.EvolutionMethodPokemon_Array.Contains(EvolutionMethod))
            {
                if (ValidatePokemon)
                {
                    return PokemonExists(EvolutionParameter, Error);
                }
                return true;
            }
            if (Global.EvolutionMethodType_Array.Contains(EvolutionMethod))
            {
                return TypeExists(EvolutionParameter, Error);
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {EvolutionMethod} is invalid."));
            return false;
        }

        public static string GetPokeFlags(string FlagsToCheck, string Error)
        {
            string[] PokeFlags = FlagsToCheck.Trim().Split(',');
            foreach (string flag in PokeFlags)
            {
                if (!Global.PokemonFlags.Contains(flag))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {flag} isn't a Pokemon Flag."));
                }
            }
            return FlagsToCheck;
        }

        private static int GetInt(string IntegerAsString, string Error, int DefaultInt)
        {
            bool conversion = Int32.TryParse(IntegerAsString, out int FinalInteger);
            if (!conversion)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {IntegerAsString} isn't a valid integer."));
                return DefaultInt;
            }
            return FinalInteger;
        }

        private static int GetTrainerTypeIntegerHigherEqual(string IntegerAsString, int Min, String Error)
        {
            if (IntegerAsString == "")
            {
                return 0;
            }
            int newInteger = GetInt(IntegerAsString, Error, -1);
            if (newInteger < Min)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {IntegerAsString} isn't a valid amount for this property."));
            }
            return newInteger;
        }

        private static decimal GetDecimal(string DecimalAsString, string Error, decimal DefaultDec)
        {
            bool conversion = Decimal.TryParse(DecimalAsString, NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out decimal FinalDecimal);
            if (!conversion)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {DecimalAsString} isn't a valid decimal."));
                return DefaultDec;
            }
            return FinalDecimal;
        }

        private static string GetColor(string checking_Color, string Error, string DefaultWhenError)
        {
            if (!Global.ColorArray.Contains(checking_Color))
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {checking_Color} isn't a valid color."));
                return DefaultWhenError;
            }
            return checking_Color;
        }

        private static string GetHabitat(string checking_Habitat, string Error, string DefaultWhenError)
        {
            if (!Global.HabitatArray.Contains(checking_Habitat))
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {checking_Habitat} isn't a valid habitat."));
                return DefaultWhenError;
            }
            return checking_Habitat;
        }

        private static string GetShape(string checking_Shape, string Error, string DefaultWhenError)
        {
            if (!Global.ShapeArray.Contains(checking_Shape))
            {
                Errors.ErrorList.Add(new Errors($"{Error}: {checking_Shape} isn't a valid shape."));
                return DefaultWhenError;
            }
            return checking_Shape;
        }

        private static string[] GetCompatibility(string[] EggGroups, string Error)
        {
            foreach (string Group in EggGroups)
            {
                if (!Global.EggGroupArray.Contains(Group))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {Group} isn't a valid Egg Group."));
                }
            }
            return EggGroups;
        }

        private static string GetGender(string GenderToCheck, string Error)
        {
            if (GenderToCheck == "male" || GenderToCheck == "female")
            {
                return GenderToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {GenderToCheck} isn't a valid Gender."));
            return null;
        }

        private static string GetNature(string NatureToCheck, string Error)
        {
            if (Global.NatureArray.Contains(NatureToCheck))
            {
                return NatureToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {NatureToCheck} isn't a valid Nature."));
            return null;
        }

        private static string GetBallType(string BallToCheck, string Error)
        {
            if (Global.BallTypeArray.Contains(BallToCheck))
            {
                return BallToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {BallToCheck} isn't a valid Ball Type."));
            return BallToCheck;
        }

        private static string GetItem(string ItemToCheck, string Error, string DefaultWhenError)
        {
            if (Global.ItemsDictionary.ContainsKey(ItemToCheck))
            {
                return ItemToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {ItemToCheck} isn't a valid Item."));
            return DefaultWhenError;
        }
        private static string GetType(string TypeToCheck, string Error, string DefaultWhenError)
        {
            if (Global.TypesDictionary.ContainsKey(TypeToCheck))
            {
                return TypeToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {TypeToCheck} isn't a valid Type."));
            return DefaultWhenError;
        }
        private static string[] GetTypeArray(string TypesToCheck, string Error)
        {
            string[] TypeArray = TypesToCheck.Trim().Split(',');
            foreach (string type in TypeArray)
            {
                GetType(type, Error, null);
            }
            return TypeArray;
        }

        private static string GetMove(string MoveToCheck, string Error, string DefaultWhenError, bool AcceptNull)
        {
            if (Global.MovesDictionary.ContainsKey(MoveToCheck))
            {
                return MoveToCheck;
            }
            if (AcceptNull && MoveToCheck == "")
            {
                return MoveToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {MoveToCheck} isn't a valid Move."));
            return DefaultWhenError;
        }

        private static string GetCategory(string CategoryToCheck, string Error, string DefaultWhenError)
        {
            string[] Categories = { "Physical", "Special", "Status" };
            if (Categories.Contains(CategoryToCheck))
            {
                return CategoryToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {CategoryToCheck} isn't a valid Category."));
            return DefaultWhenError;
        }

        private static string GetTarget (string TargetToCheck, string Error, string DefaultWhenError)
        {
            if (Global.TargetsArray.Contains(TargetToCheck))
            {
                return TargetToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {TargetToCheck} isn't a valid Target."));
            return DefaultWhenError;
        }

        private static string[] GetAbilityFlags(string FlagsString, string Error)
        {
            string[] FlagArray = FlagsString.Split(',');
            foreach (string flag in FlagArray)
            {
                if (!Global.AbilityFlagsArray.Contains(flag))
                {
                    Errors.ErrorList.Add(new Errors($"{Error}: {flag} isn't a valid ability flag."));
                }
            }
            return FlagArray;
        }

        private static string GetTrainerGender(string GenderToCheck, string Error, string DefaultWhenError)
        {
            string[] GenderArray = { "Male", "Female", "Unknown" };
            if (GenderArray.Contains(GenderToCheck))
            {
                return GenderToCheck;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {GenderToCheck} isn't a valid Gender."));
            return DefaultWhenError;
        }

        private static int GetIntegerBetweenMinMax(string Integer, int Min, int Max, string Error, int DefaultWhenError)
        {
            int newInteger = GetInt(Integer, Error, DefaultWhenError);
            if (newInteger >= Min && newInteger <= Max)
            {
                return newInteger;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {Integer} isn't a valid amount for this Property."));
            return DefaultWhenError;
        }

        private static int GetIntegerHigherOrEqualThan(string Integer, int Min, string Error, int DefaultWhenError)
        {
            int newInteger = GetInt(Integer, Error, DefaultWhenError);
            if (newInteger >= Min)
            {
                return newInteger;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {Integer} isn't a valid amount for this Property."));
            return DefaultWhenError;
        }

        private static void ValidateEVAmount(int[] EVArray, string Error)
        {
            int Sum = 0;
            int Addition;
            for (int i = 0; i < 6; i++)
            {
                Addition = EVArray[0];
                if (EVArray.Length > i)
                {
                    Addition = EVArray[i];
                }
                Sum += Addition;
            }
            if (Sum > 510)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: Trainer Pokemon has more than 510 EVs. {EVArray[1]} {Sum}"));
            }
        }

        public static int[] GetEffortPoints(string EVLine, string Error)
        {
            string[] RawArray = EVLine.Trim().Split(',');
            int[] EffortValueArray = { 0, 0, 0, 0, 0, 0 };
            if (RawArray.Length < 2)
            {
                Errors.ErrorList.Add(new Errors($"{Error}: Not enough Effort Points"));
            }
            for (int i = 0; i < RawArray.Length-1; i+=2)
            {
                switch (RawArray[i])
                {
                    case "HP":
                        EffortValueArray[0] = GetInt(RawArray[i + 1], Error, 0);
                        break;
                    case "ATTACK":
                        EffortValueArray[1] = GetInt(RawArray[i + 1], Error, 0);
                        break;
                    case "DEFENSE":
                        EffortValueArray[2] = GetInt(RawArray[i + 1], Error, 0);
                        break;
                    case "SPEED":
                        EffortValueArray[3] = GetInt(RawArray[i + 1], Error, 0);
                        break;
                    case "SPECIAL_ATTACK":
                        EffortValueArray[4] = GetInt(RawArray[i + 1], Error, 0);
                        break;
                    case "SPECIAL_DEFENSE":
                        EffortValueArray[5] = GetInt(RawArray[i + 1], Error, 0);
                        break;
                    default:
                        Errors.ErrorList.Add(new Errors($"{Error}: Invalid Stat: {i}"));
                        break;
                }
            }
            return EffortValueArray;
        }

        private static void AddBaseStatToDictionary(int[] BaseStats, string Pokemon)
        {
            int Total = 0;
            for (int i = 0; i < BaseStats.Length; i++)
            {
                Total += BaseStats[i];
            }
            if (Global.BaseStats_Dictionary.ContainsKey(Total))
            {
                List<string> tempList = Global.BaseStats_Dictionary[Total];
                tempList.Add(Pokemon);
                Global.BaseStats_Dictionary[Total] = tempList;
            }
            else
            {
                List<string> tempList = new();
                tempList.Add(Pokemon);
                Global.BaseStats_Dictionary.Add(Total, tempList);
            }
        }

        private static string CheckForPathExistance(string test_Filepath, string TargetFolder, string Error, bool AcceptNull)
        {
            if (AcceptNull && test_Filepath == "")
            {
                return test_Filepath;
            }
            DirectoryInfo root = new($"{Global.ExecutableURL}{TargetFolder}");
            FileInfo[] listfiles = root.GetFiles($"{ test_Filepath }.*");

            if (listfiles.Length > 0)
            {
                return test_Filepath;
            }
            Errors.ErrorList.Add(new Errors($"{Error}: {test_Filepath} doesn't exist in {TargetFolder}."));
            return null;
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            switch (comboBox_PBS.Text)
            {
                case "Pokemon":
                    Form_Pokemons OpenPokemonForm = new();
                    OpenPokemonForm.Show();
                    break;
                case "Abilities":
                    Form_Abilities OpenAbilitiesForm = new();
                    OpenAbilitiesForm.Show();
                    break;
                case "Types":
                    Form_Types OpenTypesForm = new();
                    OpenTypesForm.Show();
                    break;
                case "Trainer Types":
                    Form_TrainerTypes OpenTrainerTypesForm = new();
                    OpenTrainerTypesForm.Show();
                    break;
                case "Items":
                    Form_Items OpenItemsForm = new();
                    OpenItemsForm.Show();
                    break;
                case "Moves":
                    Form_Moves OpenMovesForm = new();
                    OpenMovesForm.Show();
                    break;
                case "Encounters":
                    Form_Encounters OpenEncountersForm = new();
                    OpenEncountersForm.Show();
                    break;
                case "Pokemon Forms":
                    Form_PokemonForms OpenPokemonFormsForm = new();
                    OpenPokemonFormsForm.Show();
                    break;
                case "Trainers":
                    Form_Trainers OpenTrainersForm = new();
                    OpenTrainersForm.Show();
                    break;
                default:
                    MessageBox.Show("Select the PBS file you want to edit.");
                    break;
            }
        }

        private void OpenErrorLog_Button_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\PBSE_ErrorLog.txt");
        }

        private void Backup_Button_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Backup\\";
            string filepath2 = textBox_Backup.Text;
            Directory.CreateDirectory(filepath);
            bool exists = Directory.Exists($"{ filepath }{ filepath2 }");
            if (exists)
            {
                MessageBox.Show("That folder already exists.");
            }
            else
            {
                List<string> Filepaths = new();
                Filepaths.Add(new string("\\Abilities.txt"));
                Filepaths.Add(new string("\\types.txt"));
                Filepaths.Add(new string("\\items.txt"));
                Filepaths.Add(new string("\\trainer_types.txt"));
                Filepaths.Add(new string("\\moves.txt"));
                Filepaths.Add(new string("\\pokemon.txt"));
                Filepaths.Add(new string("\\pokemon_forms.txt"));
                Filepaths.Add(new string("\\trainers.txt"));
                Filepaths.Add(new string("\\encounters.txt"));

                string newbackupfolder = $"{ filepath }{ filepath2 }";
                Directory.CreateDirectory(newbackupfolder);
                foreach (var item in Filepaths)
                {
                    File.Copy($"{ Global.ExecutableURL }\\PBS{ item }", $"{ newbackupfolder }{ item }");
                }
                MessageBox.Show("Backup created.");
                RefreshBackupStatusLabel();
            }
        }

        private void RefreshBackupStatusLabel()
        {
            var directoryInfo = new DirectoryInfo($"{ Global.ExecutableURL }\\PBSE\\Backup");
            int directoryCount = directoryInfo.GetDirectories().Length;

            label_BackupStatus.Text = $"You have {directoryCount} backups.";
        }

        private void StartUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close PBS Editor",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}