using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_PokemonForms : Form
    {
        readonly BindingSource PokemonListBS = new();
        readonly BindingSource AbilitiesListBS = new();
        readonly BindingSource HiddenAbilitiesListBS = new();
        readonly BindingSource MovesListBS = new();
        readonly BindingSource TutorMovesListBS = new();
        readonly BindingSource EggMovesListBS = new();
        readonly BindingSource CompatibilitiesListBS = new();
        readonly BindingSource EvolutionsListBS = new();
        readonly BindingSource OffspringListBS = new();
        PBS_PokemonForms thisPokemon = new();
        readonly List<PBS_PokemonForms> thisList = Global.PokemonFormsDictionary.Values.ToList();
        public Form_PokemonForms()
        {
            InitializeComponent();
            PokemonListBS.DataSource = thisList;
            Pokemon_ListBox.DataSource = PokemonListBS;
            Pokemon_ListBox.DisplayMember = "Identification";
            InternalSpecies_ComboBox.DataSource = Global.PokemonsDictionary.Keys.ToList();
            Type1_ComboBox.DataSource = Global.TypesDictionary.Keys.ToList();
            Type2_ComboBox.DataSource = Global.TypesDictionary.Keys.ToList();
            Abilities_ComboBox.DataSource = Global.AbilitiesDictionary.Keys.ToList();
            Moves_ComboBox.DataSource = Global.MovesDictionary.Keys.ToList();
            Compatibility_ComboBox.DataSource = Global.EggGroupArray;
            Color_ComboBox.DataSource = Global.ColorArray;
            Shape_ComboBox.DataSource = Global.ShapeArray;
            Habitat_ComboBox.DataSource = Global.HabitatArray;
            WildItemCommon_ComboBox.DataSource = Global.ItemsDictionary.Keys.ToList();
            WildItemUncommon_ComboBox.DataSource = Global.ItemsDictionary.Keys.ToList();
            WildItemRare_ComboBox.DataSource = Global.ItemsDictionary.Keys.ToList();
            Species_ComboBox.DataSource = Global.PokemonsDictionary.Keys.ToList();
            EvolutionMethod_ComboBox.DataSource = Global.EvolutionMethods_Array;
            MegaStone_ComboBox.DataSource = Global.ItemsDictionary.Keys.ToList();
            MegaMove_ComboBox.DataSource = Global.MovesDictionary.Keys.ToList();
            Flags_CheckedListBox.DataSource = Global.PokemonFlags.ToList();
            offspringcomboBox.DataSource = Global.PokemonsDictionary.Keys.ToList();
            if (thisList.Count > 0)
            {
                Pokemon_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Pokemon_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pokemon_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }
        private void UpdateMainList()
        {
            thisPokemon = (PBS_PokemonForms)this.Pokemon_ListBox.SelectedItem;
            InternalSpecies_ComboBox.Text = thisPokemon.PokemonID;
            ID_Numeric.Value = thisPokemon.FormID;
            UpdateTypes();
            UpdateBaseStats();
            UpdateTotalBaseStats();
            UpdateEffortPoints();
            UpdateAbilities();
            UpdateHiddenAbilities();
            UpdateMoves();
            UpdateTutorMoves();
            UpdateEggMoves();
            UpdateCompatibility();
            UpdateBaseEXP();
            UpdateRareness();
            UpdateHappiness();
            UpdateStepsToHatch();
            UpdateHeight();
            UpdateWeight();
            UpdateColor();
            UpdateShape();
            UpdateHabitat();
            UpdateKind();
            UpdatePokedex();
            UpdateFormName();
            UpdateGeneration();
            UpdateWildItemCommon();
            UpdateWildItemUncommon();
            UpdateWildItemRare();
            UpdateEvolutions();
            UpdateMegaStone();
            UpdateMegaMove();
            UpdateMegaMessage();
            UpdateUnmegaForm();
            UpdatePokedexForm();
            UpdateOffspring();
            UpdateFlagListBox();
        }

        private void UpdateOffspring()
        {
            OffspringListBS.DataSource = thisPokemon.Offspring;
            offspring_Listbox.DataSource = OffspringListBS;
            OffspringListBS.ResetBindings(false);
        }

        private void UpdatePokedexForm()
        {
            if (thisPokemon.PokedexForm == -1)
            {
                PokedexForm_CheckBox.Checked = false;
                PokedexForm_Numeric.Enabled = false;
                return;
            }
            PokedexForm_CheckBox.Checked = true;
            PokedexForm_Numeric.Enabled = true;
            PokedexForm_Numeric.Value = thisPokemon.PokedexForm;
        }
        private void UpdateUnmegaForm()
        {
            if (thisPokemon.UnmegaForm == -1)
            {
                UnmegaForm_CheckBox.Checked = false;
                UnmegaForm_Numeric.Enabled = false;
                return;
            }
            UnmegaForm_CheckBox.Checked = true;
            UnmegaForm_Numeric.Enabled = true;
            UnmegaForm_Numeric.Value = thisPokemon.UnmegaForm;
        }
        private void UpdateMegaMessage()
        {
            if (thisPokemon.MegaMessage == -1)
            {
                MegaMessage_CheckBox.Checked = false;
                MegaMessage_Numeric.Enabled = false;
                return;
            }
            MegaMessage_CheckBox.Checked = true;
            MegaMessage_Numeric.Enabled = true;
            MegaMessage_Numeric.Value = thisPokemon.MegaMessage;
        }
        private void UpdateMegaMove()
        {
            if (thisPokemon.MegaMove == null)
            {
                MegaMove_CheckBox.Checked = false;
                MegaMove_ComboBox.Enabled = false;
                return;
            }
            MegaMove_CheckBox.Checked = true;
            MegaMove_ComboBox.Enabled = true;
            MegaMove_ComboBox.Text = thisPokemon.MegaMove;
        }
        private void UpdateMegaStone()
        {
            if (thisPokemon.MegaStone == null)
            {
                MegaStone_CheckBox.Checked = false;
                MegaStone_ComboBox.Enabled = false;
                return;
            }
            MegaStone_CheckBox.Checked = true;
            MegaStone_ComboBox.Enabled = true;
            MegaStone_ComboBox.Text = thisPokemon.MegaStone;
        }
        private void UpdateEvolutions()
        {
            EvolutionsListBS.DataSource = thisPokemon.Evolution;
            Evolutions_ListBox.DataSource = EvolutionsListBS;
            Evolutions_ListBox.DisplayMember = "Identification";
            if (thisPokemon.Evolution.Length == 0)
            {
                Evolutions_CheckBox.Checked = false;
                Evolutions_ListBox.Enabled = false;
                Species_ComboBox.Enabled = false;
                EvolutionMethod_ComboBox.Enabled = false;
                EvolutionParameter_TextBox.Enabled = false;
                return;
            }
            Evolutions_CheckBox.Checked = true;
            Evolutions_ListBox.Enabled = true;
            Species_ComboBox.Enabled = true;
            EvolutionMethod_ComboBox.Enabled = true;
            EvolutionParameter_TextBox.Enabled = true;
            UpdateEvolutionListBox();
        }
        
        private void UpdateWildItemRare()
        {
            if (thisPokemon.WildItemRare == null)
            {
                WildItemRare_CheckBox.Checked = false;
                WildItemRare_ComboBox.Enabled = false;
                return;
            }
            WildItemRare_CheckBox.Checked = true;
            WildItemRare_ComboBox.Enabled = true;
            WildItemRare_ComboBox.Text = thisPokemon.WildItemRare;
        }
        private void UpdateWildItemUncommon()
        {
            if (thisPokemon.WildItemUncommon == null)
            {
                WildItemUncommon_CheckBox.Checked = false;
                WildItemUncommon_ComboBox.Enabled = false;
                return;
            }
            WildItemUncommon_CheckBox.Checked = true;
            WildItemUncommon_ComboBox.Enabled = true;
            WildItemUncommon_ComboBox.Text = thisPokemon.WildItemUncommon;
        }
        private void UpdateWildItemCommon()
        {
            if (thisPokemon.WildItemCommon == null)
            {
                WildItemCommon_CheckBox.Checked = false;
                WildItemCommon_ComboBox.Enabled = false;
                return;
            }
            WildItemCommon_CheckBox.Checked = true;
            WildItemCommon_ComboBox.Enabled = true;
            WildItemCommon_ComboBox.Text = thisPokemon.WildItemCommon;
        }
        private void UpdateGeneration()
        {
            if (thisPokemon.Generation == -1)
            {
                Generation_CheckBox.Checked = false;
                Generation_Numeric.Enabled = false;
                return;
            }
            Generation_CheckBox.Checked = true;
            Generation_Numeric.Enabled = true;
            Generation_Numeric.Value = thisPokemon.Generation;
        }
        private void UpdateFormName()
        {
            if (thisPokemon.FormName == null)
            {
                FormName_CheckBox.Checked = false;
                FormName_TextBox.Enabled = false;
                return;
            }
            FormName_CheckBox.Checked = true;
            FormName_TextBox.Enabled = true;
            FormName_TextBox.Text = thisPokemon.FormName;
        }
        private void UpdatePokedex()
        {
            if (thisPokemon.Pokedex == null)
            {
                Pokedex_CheckBox.Checked = false;
                Pokedex_TextBox.Enabled = false;
                return;
            }
            Pokedex_CheckBox.Checked = true;
            Pokedex_TextBox.Enabled = true;
            Pokedex_TextBox.Text = thisPokemon.Pokedex;
        }
        private void UpdateKind()
        {
            if (thisPokemon.Category == null)
            {
                Kind_CheckBox.Checked = false;
                Kind_TextBox.Enabled = false;
                return;
            }
            Kind_CheckBox.Checked = true;
            Kind_TextBox.Enabled = true;
            Kind_TextBox.Text = thisPokemon.Category;
        }
        private void UpdateHabitat()
        {
            if (thisPokemon.Habitat == null)
            {
                Habitat_CheckBox.Checked = false;
                Habitat_ComboBox.Enabled = false;
                return;
            }
            Habitat_CheckBox.Checked = true;
            Habitat_ComboBox.Enabled = true;
            Habitat_ComboBox.Text = thisPokemon.Habitat;
        }
        private void UpdateShape()
        {
            if (thisPokemon.Shape == null)
            {
                Shape_CheckBox.Checked = false;
                Shape_ComboBox.Enabled = false;
                return;
            }
            Shape_CheckBox.Checked = true;
            Shape_ComboBox.Enabled = true;
            Shape_ComboBox.Text = thisPokemon.Shape;
        }
        private void UpdateColor()
        {
            if (thisPokemon.Color == null)
            {
                Color_CheckBox.Checked = false;
                Color_ComboBox.Enabled = false;
                return;
            }
            Color_CheckBox.Checked = true;
            Color_ComboBox.Enabled = true;
            Color_ComboBox.Text = thisPokemon.Color;
        }
        private void UpdateWeight()
        {
            if (thisPokemon.Weight == -1)
            {
                Weight_CheckBox.Checked = false;
                Weight_Numeric.Enabled = false;
                return;
            }
            Weight_CheckBox.Checked = true;
            Weight_Numeric.Enabled = true;
            Weight_Numeric.Value = thisPokemon.Weight;
        }
        private void UpdateHeight()
        {
            if (thisPokemon.Height == -1)
            {
                Height_CheckBox.Checked = false;
                Height_Numeric.Enabled = false;
                return;
            }
            Height_CheckBox.Checked = true;
            Height_Numeric.Enabled = true;
            Height_Numeric.Value = thisPokemon.Height;
        }
        private void UpdateStepsToHatch()
        {
            if (thisPokemon.HatchSteps == -1)
            {
                StepsToHatch_CheckBox.Checked = false;
                StepsToHatch_Numeric.Enabled = false;
                return;
            }
            StepsToHatch_CheckBox.Checked = true;
            StepsToHatch_Numeric.Enabled = true;
            StepsToHatch_Numeric.Value = thisPokemon.HatchSteps;
        }
        private void UpdateHappiness()
        {
            if (thisPokemon.Happiness == -1)
            {
                Happiness_CheckBox.Checked = false;
                Happiness_Numeric.Enabled = false;
                return;
            }
            Happiness_CheckBox.Checked = true;
            Happiness_Numeric.Enabled = true;
            Happiness_Numeric.Value = thisPokemon.Happiness;
        }
        private void UpdateRareness()
        {
            if (thisPokemon.CatchRate == -1)
            {
                Rareness_CheckBox.Checked = false;
                Rareness_Numeric.Enabled = false;
                return;
            }
            Rareness_CheckBox.Checked = true;
            Rareness_Numeric.Enabled = true;
            Rareness_Numeric.Value = thisPokemon.CatchRate;
        }
        private void UpdateBaseEXP()
        {
            if (thisPokemon.BaseExp == -1)
            {
                BaseEXP_CheckBox.Checked = false;
                BaseEXP_Numeric.Enabled = false;
                return;
            }
            BaseEXP_CheckBox.Checked = true;
            BaseEXP_Numeric.Enabled = true;
            BaseEXP_Numeric.Value = thisPokemon.BaseExp;
        }
        private void UpdateCompatibility()
        {
            CompatibilitiesListBS.DataSource = thisPokemon.EggGroups;
            Compatibility_ListBox.DataSource = CompatibilitiesListBS;
            if (thisPokemon.EggGroups.Length == 0)
            {
                Compatibility_ListBox.Enabled = false;
                Compatibility_ComboBox.Enabled = false;
                CompatibilityValidation_CheckBox.Checked = false;
                return;
            }
            Compatibility_ListBox.Enabled = true;
            Compatibility_ComboBox.Enabled = true;
            CompatibilityValidation_CheckBox.Checked = true;
        }
        private void UpdateEggMoves()
        {
            EggMovesListBS.DataSource = thisPokemon.Eggmoves;
            EggMoves_ListBox.DataSource = EggMovesListBS;
            if (thisPokemon.Eggmoves.Length == 0)
            {
                EggMoves_ListBox.Enabled = false;
                EggMovesValidation_CheckBox.Checked = false;
                return;
            }
            EggMoves_ListBox.Enabled = true;
            EggMovesValidation_CheckBox.Checked = true;
        }
        private void UpdateTutorMoves()
        {
            TutorMovesListBS.DataSource = thisPokemon.TutorMoves;
            TutorMoves_ListBox.DataSource = TutorMovesListBS;
            if (thisPokemon.TutorMoves.Length == 0)
            {
                TutorMoves_ListBox.Enabled = false;
                TutorMovesValidation_CheckBox.Checked = false;
                return;
            }
            TutorMoves_ListBox.Enabled = true;
            TutorMovesValidation_CheckBox.Checked = true;
        }
        private void UpdateMoves()
        {
            MovesListBS.DataSource = thisPokemon.Moves;
            Moves_ListBox.DataSource = MovesListBS;
            Moves_ListBox.DisplayMember = "Identification";
            if (thisPokemon.Moves.Length == 0)
            {
                Moves_ListBox.Enabled = false;
                MovesValidation_CheckBox.Checked = false;
                return;
            }
            Moves_ListBox.Enabled = true;
            MovesValidation_CheckBox.Checked = true;
        }
        private void UpdateAbilities()
        {
            AbilitiesListBS.DataSource = thisPokemon.Abilities;
            Abilities_ListBox.DataSource = AbilitiesListBS;
            AbilitiesListBS.ResetBindings(false);
            if (thisPokemon.Abilities.Length == 0)
            {
                AbilitiesValidation_CheckBox.Checked = false;
                Abilities_ListBox.Enabled = false;
                return;
            }
            AbilitiesValidation_CheckBox.Checked = true;
            Abilities_ListBox.Enabled = true;
        }
        private void UpdateHiddenAbilities()
        {
            HiddenAbilitiesListBS.DataSource = thisPokemon.HiddenAbility;
            HiddenAbilities_ListBox.DataSource = HiddenAbilitiesListBS;
            HiddenAbilitiesListBS.ResetBindings(false);
            if (thisPokemon.HiddenAbility.Length == 0)
            {
                HiddenAbilitiesValidation_CheckBox.Checked = false;
                HiddenAbilities_ListBox.Enabled = false;
                return;
            }
            HiddenAbilitiesValidation_CheckBox.Checked = true;
            HiddenAbilities_ListBox.Enabled = true;
        }
        private void UpdateBaseStats()
        {
            if (thisPokemon.BaseStats.Contains(-1))
            {
                BaseStats_CheckBox.Checked = false;
                BaseStatsHP_Numeric.Enabled = false;
                BaseStatsATK_Numeric.Enabled = false;
                BaseStatsDEF_Numeric.Enabled = false;
                BaseStatsSPD_Numeric.Enabled = false;
                BaseStatsSATK_Numeric.Enabled = false;
                BaseStatsSDEF_Numeric.Enabled = false;
                return;
            }
            BaseStats_CheckBox.Checked = true;
            BaseStatsHP_Numeric.Enabled = true;
            BaseStatsATK_Numeric.Enabled = true;
            BaseStatsDEF_Numeric.Enabled = true;
            BaseStatsSPD_Numeric.Enabled = true;
            BaseStatsSATK_Numeric.Enabled = true;
            BaseStatsSDEF_Numeric.Enabled = true;

            BaseStatsHP_Numeric.Value = thisPokemon.Hp;
            BaseStatsATK_Numeric.Value = thisPokemon.Atk;
            BaseStatsDEF_Numeric.Value = thisPokemon.Def;
            BaseStatsSPD_Numeric.Value = thisPokemon.Spd;
            BaseStatsSATK_Numeric.Value = thisPokemon.Satk;
            BaseStatsSDEF_Numeric.Value = thisPokemon.Sdef;
        }
        private void UpdateTotalBaseStats()
        {
            int TotalStats = thisPokemon.Hp + thisPokemon.Atk + thisPokemon.Def
                + thisPokemon.Spd + thisPokemon.Satk + thisPokemon.Sdef;
            if (TotalStats < 0)
            {
                PBS_Pokemons baseform = Global.PokemonsDictionary[thisPokemon.PokemonID];
                TotalStats = baseform.Hp + baseform.Atk + baseform.Def + baseform.Spd
                    + baseform.Satk + baseform.Sdef;
            }
            TotalBaseStatsNumeric.Value = TotalStats;
        }
        private void UpdateEffortPoints()
        {
            if (thisPokemon.EffortPoints.Contains(-1))
            {
                EffortPoints_CheckBox.Checked = false;
                EVHP_Numeric.Enabled = false;
                EVATK_Numeric.Enabled = false;
                EVDEF_Numeric.Enabled = false;
                EVSPD_Numeric.Enabled = false;
                EVSATK_Numeric.Enabled = false;
                EVSDEF_Numeric.Enabled = false;
                return;
            }
            EffortPoints_CheckBox.Checked = true;
            EVHP_Numeric.Enabled = true;
            EVATK_Numeric.Enabled = true;
            EVDEF_Numeric.Enabled = true;
            EVSPD_Numeric.Enabled = true;
            EVSATK_Numeric.Enabled = true;
            EVSDEF_Numeric.Enabled = true;

            EVHP_Numeric.Value = thisPokemon.HpEV;
            EVATK_Numeric.Value = thisPokemon.AtkEV;
            EVDEF_Numeric.Value = thisPokemon.DefEV;
            EVSPD_Numeric.Value = thisPokemon.SpdEV;
            EVSATK_Numeric.Value = thisPokemon.SatkEV;
            EVSDEF_Numeric.Value = thisPokemon.SdefEV;
        }
        private void UpdateTypes()
        {
            if (thisPokemon.Type1 == null)
            {
                Type1_CheckBox.Checked = false;
                Type1_ComboBox.Enabled = false;
                Type2_CheckBox.Checked = false;
                Type2_ComboBox.Enabled = false;
                return;
            }
            Type1_CheckBox.Checked = true;
            Type1_ComboBox.Enabled = true;
            Type1_ComboBox.Text = thisPokemon.Type1;
            if (thisPokemon.Type2 == null)
            {
                Type2_CheckBox.Checked = false;
                Type2_ComboBox.Enabled = false;
                return;
            }
            Type2_CheckBox.Checked = true;
            Type2_ComboBox.Enabled = true;
            Type2_ComboBox.Text = thisPokemon.Type2;
        }

        private void UpdateEvolutionListBox()
        {
            if (thisPokemon.Evolution.Length > 0)
            {
                EvolutionSets thisEvolutionSet = (EvolutionSets)this.Evolutions_ListBox.SelectedItem;
                Species_ComboBox.Text = thisEvolutionSet.InternalName;
                EvolutionMethod_ComboBox.Text = thisEvolutionSet.EvolutionMethod;
                EvolutionParameter_TextBox.Text = thisEvolutionSet.EvolutionParameter;
            }
        }

        private void Evolutions_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Evolutions_ListBox.Focused == true)
            {
                UpdateEvolutionListBox();
            }
        }

        private void AddPokemon_Button_Click(object sender, EventArgs e)
        {
            PBS_PokemonForms newPoke = new();
            newPoke.PokemonID = InternalSpecies_ComboBox.Text;
            newPoke.FormID = Global.PokemonsDictionary[newPoke.PokemonID].Forms + 1;
            Global.PokemonsDictionary[newPoke.PokemonID].Forms += 1;
            thisList.Add(newPoke);
            PokemonListBS.ResetBindings(false);
            Pokemon_ListBox.SelectedIndex = Pokemon_ListBox.Items.Count - 1;
            UpdateMainList();
        }

        private void DelPokemon_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this PokemonForm?", "Delete PokemonForm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(Pokemon_ListBox.SelectedIndex);
                PokemonListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void InternalSpecies_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisPokemon.PokemonID = InternalSpecies_ComboBox.Text;
            PokemonListBS.ResetBindings(false);
        }

        private void ID_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.FormID = Convert.ToInt32(ID_Numeric.Value);
            PokemonListBS.ResetBindings(false);
        }

        private void Type1_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Type1_CheckBox.Focused == false)
            {
                return;
            }
            if (Type1_CheckBox.Checked == false)
            {
                Type1_ComboBox.Enabled = false;
                Type2_CheckBox.Checked = false;
                Type2_ComboBox.Enabled = false;
                thisPokemon.Types = Array.Empty<string>();
                thisPokemon.Type1 = null;
                thisPokemon.Type2 = null;
                return;
            }
            Type1_ComboBox.Enabled = true;
            UpdateEventType1();
        }
        private void Type2_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Type2_CheckBox.Focused == false)
            {
                return;
            }
            if (Type1_CheckBox.Checked == false)
            {
                Type2_CheckBox.Checked = false;
                return;
            }
            if (Type2_CheckBox.Checked == false)
            {
                Type2_ComboBox.Enabled = false;
                thisPokemon.Type2 = null;
                return;
            }
            Type2_ComboBox.Enabled = true;
            UpdateEventType2();
        }

        private void Type1_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEventType1();
        }
        private void UpdateEventType1()
        {
            thisPokemon.Type1 = Type1_ComboBox.Text;
        }

        private void Type2_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thisPokemon.Type1 == Type2_ComboBox.Text)
            {
                return;
            }
            UpdateEventType2();
        }
        private void UpdateEventType2()
        {
            thisPokemon.Type2 = Type2_ComboBox.Text;
        }

        private void DisableBaseStats()
        {
            BaseStatsHP_Numeric.Enabled = false;
            BaseStatsATK_Numeric.Enabled = false;
            BaseStatsDEF_Numeric.Enabled = false;
            BaseStatsSPD_Numeric.Enabled = false;
            BaseStatsSATK_Numeric.Enabled = false;
            BaseStatsSDEF_Numeric.Enabled = false;
            thisPokemon.Hp = -1;
            thisPokemon.Atk = -1;
            thisPokemon.Def = -1;
            thisPokemon.Spd = -1;
            thisPokemon.Satk = -1;
            thisPokemon.Sdef = -1;
            UpdateTotalBaseStats();
        }
        private void EnableBaseStats()
        {
            BaseStatsHP_Numeric.Enabled = true;
            BaseStatsATK_Numeric.Enabled = true;
            BaseStatsDEF_Numeric.Enabled = true;
            BaseStatsSPD_Numeric.Enabled = true;
            BaseStatsSATK_Numeric.Enabled = true;
            BaseStatsSDEF_Numeric.Enabled = true;
            thisPokemon.Hp = Convert.ToInt32(BaseStatsHP_Numeric.Value);
            thisPokemon.Atk = Convert.ToInt32(BaseStatsATK_Numeric.Value);
            thisPokemon.Def = Convert.ToInt32(BaseStatsDEF_Numeric.Value);
            thisPokemon.Spd = Convert.ToInt32(BaseStatsSPD_Numeric.Value);
            thisPokemon.Satk = Convert.ToInt32(BaseStatsSATK_Numeric.Value);
            thisPokemon.Sdef = Convert.ToInt32(BaseStatsSDEF_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void BaseStats_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BaseStats_CheckBox.Focused == false)
            {
                return;
            }
            if (BaseStats_CheckBox.Checked == false)
            {
                DisableBaseStats();
                return;
            }
            EnableBaseStats();
        }
        private void BaseStatsHP_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.Hp = Convert.ToInt32(BaseStatsHP_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void BaseStatsATK_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.Atk = Convert.ToInt32(BaseStatsATK_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void BaseStatsDEF_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.Def = Convert.ToInt32(BaseStatsDEF_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void BaseStatsSPD_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.Spd = Convert.ToInt32(BaseStatsSPD_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void BaseStatsSATK_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.Satk = Convert.ToInt32(BaseStatsSATK_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void BaseStatsSDEF_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.Sdef = Convert.ToInt32(BaseStatsSDEF_Numeric.Value);
            UpdateTotalBaseStats();
        }

        private void EffortPoints_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EffortPoints_CheckBox.Focused == false)
            {
                return;
            }
            if (EffortPoints_CheckBox.Checked == false)
            {
                DisableEffortPoints();
                return;
            }
            EnableEffortPoints();
        }
        private void DisableEffortPoints()
        {
            EVHP_Numeric.Enabled = false;
            EVATK_Numeric.Enabled = false;
            EVDEF_Numeric.Enabled = false;
            EVSPD_Numeric.Enabled = false;
            EVSATK_Numeric.Enabled = false;
            EVSDEF_Numeric.Enabled = false;
            thisPokemon.HpEV = -1;
            thisPokemon.AtkEV = -1;
            thisPokemon.DefEV = -1;
            thisPokemon.SpdEV = -1;
            thisPokemon.SatkEV = -1;
            thisPokemon.SdefEV = -1;
        }

        private void EnableEffortPoints()
        {
            EVHP_Numeric.Enabled = true;
            EVATK_Numeric.Enabled = true;
            EVDEF_Numeric.Enabled = true;
            EVSPD_Numeric.Enabled = true;
            EVSATK_Numeric.Enabled = true;
            EVSDEF_Numeric.Enabled = true;
            thisPokemon.HpEV = Convert.ToInt32(EVHP_Numeric.Value);
            thisPokemon.AtkEV = Convert.ToInt32(EVATK_Numeric.Value);
            thisPokemon.DefEV = Convert.ToInt32(EVDEF_Numeric.Value);
            thisPokemon.SpdEV = Convert.ToInt32(EVSPD_Numeric.Value);
            thisPokemon.SatkEV = Convert.ToInt32(EVSATK_Numeric.Value);
            thisPokemon.SdefEV = Convert.ToInt32(EVSDEF_Numeric.Value);
        }

        private void EVHP_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.HpEV = Convert.ToInt32(EVHP_Numeric.Value);
        }

        private void EVATK_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.AtkEV = Convert.ToInt32(EVATK_Numeric.Value);
        }

        private void EVDEF_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.DefEV = Convert.ToInt32(EVDEF_Numeric.Value);
        }

        private void EVSPD_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.SpdEV = Convert.ToInt32(EVSPD_Numeric.Value);
        }

        private void EVSATK_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.SatkEV = Convert.ToInt32(EVSATK_Numeric.Value);
        }

        private void EVSDEF_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisPokemon.SdefEV = Convert.ToInt32(EVSDEF_Numeric.Value);
        }

        private void Abilities_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Abilities_CheckBox.Checked == false)
            {
                HiddenAbilities_CheckBox.Checked = true;
                return;
            }
            HiddenAbilities_CheckBox.Checked = false;
        }

        private void HiddenAbilities_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HiddenAbilities_CheckBox.Checked == false)
            {
                Abilities_CheckBox.Checked = true;
                return;
            }
            Abilities_CheckBox.Checked = false;
        }

        private void AbilitiesValidation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AbilitiesValidation_CheckBox.Focused == false)
            {
                return;
            }
            if (AbilitiesValidation_CheckBox.Checked == false)
            {
                Abilities_ListBox.Enabled = false;
                thisPokemon.Abilities = Array.Empty<string>();
                UpdateAbilities();
                return;
            }
            Abilities_ListBox.Enabled = true;
        }

        private void HiddenAbilitiesValidation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HiddenAbilitiesValidation_CheckBox.Focused == false)
            {
                return;
            }
            if (HiddenAbilitiesValidation_CheckBox.Checked == false)
            {
                HiddenAbilities_ListBox.Enabled = false;
                thisPokemon.HiddenAbility = Array.Empty<string>();
                UpdateHiddenAbilities();
                return;
            }
            HiddenAbilities_ListBox.Enabled = true;
        }

        private void AbilityAdd_Button_Click(object sender, EventArgs e)
        {
            if (Abilities_CheckBox.Checked == true)
            {
                if (thisPokemon.Abilities.Length == 2 || thisPokemon.Abilities.Contains(Abilities_ComboBox.Text))
                {
                    return;
                }
                List<string> tempLista = thisPokemon.Abilities.ToList();
                tempLista.Add(Abilities_ComboBox.Text);
                thisPokemon.Abilities = tempLista.ToArray();
                UpdateAbilities();
                return;
            }
            if (HiddenAbilities_CheckBox.Checked == true)
            {
                if (thisPokemon.HiddenAbility.Contains(Abilities_ComboBox.Text))
                {
                    return;
                }
                List<string> tempList = thisPokemon.HiddenAbility.ToList();
                tempList.Add(Abilities_ComboBox.Text);
                thisPokemon.HiddenAbility = tempList.ToArray();
                UpdateHiddenAbilities();
                return;
            }
        }

        private void AbilityDel_Button_Click(object sender, EventArgs e)
        {
            if (Abilities_CheckBox.Checked == true)
            {
                if (thisPokemon.Abilities.Length == 0)
                {
                    return;
                }
                List<string> tempLista = thisPokemon.Abilities.ToList();
                tempLista.RemoveAt(Abilities_ListBox.SelectedIndex);
                thisPokemon.Abilities = tempLista.ToArray();
                UpdateAbilities();
                return;
            }
            if (HiddenAbilities_CheckBox.Checked == true)
            {
                if (thisPokemon.HiddenAbility.Length == 0)
                {
                    return;
                }
                List<string> tempList = thisPokemon.HiddenAbility.ToList();
                tempList.RemoveAt(HiddenAbilities_ListBox.SelectedIndex);
                thisPokemon.HiddenAbility = tempList.ToArray();
                UpdateHiddenAbilities();
                return;
            }
        }

        private void Moves_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Moves_CheckBox.Checked == true)
            {
                TutorMoves_CheckBox.Checked = false;
                EggMoves_CheckBox.Checked = false;
            }
        }

        private void TutorMoves_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TutorMoves_CheckBox.Checked == true)
            {
                Moves_CheckBox.Checked = false;
                EggMoves_CheckBox.Checked = false;
            }
        }

        private void EggMoves_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EggMoves_CheckBox.Checked == true)
            {
                Moves_CheckBox.Checked = false;
                TutorMoves_CheckBox.Checked = false;
            }
        }

        private void MovesValidation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MovesValidation_CheckBox.Focused == false)
            {
                return;
            }
            if (MovesValidation_CheckBox.Checked == false)
            {
                Moves_ListBox.Enabled = false;
                thisPokemon.Moves = Array.Empty<MoveSets>();
                UpdateMoves();
                return;
            }
            Moves_ListBox.Enabled = true;
        }

        private void TutorMovesValidation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TutorMovesValidation_CheckBox.Focused == false)
            {
                return;
            }
            if (TutorMovesValidation_CheckBox.Checked == false)
            {
                TutorMoves_ListBox.Enabled = false;
                thisPokemon.TutorMoves = Array.Empty<string>();
                UpdateTutorMoves();
                return;
            }
            TutorMoves_ListBox.Enabled = true;
        }

        private void EggMovesValidation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EggMovesValidation_CheckBox.Focused == false)
            {
                return;
            }
            if (EggMovesValidation_CheckBox.Checked == false)
            {
                EggMoves_ListBox.Enabled = false;
                thisPokemon.Eggmoves = Array.Empty<string>();
                UpdateEggMoves();
                return;
            }
            EggMoves_ListBox.Enabled = true;
        }

        private List<MoveSets> SortMoveset(List<MoveSets> moveList)
        {
            bool doublecheck = false;
            for (int i = 0; i < moveList.Count - 1; i++)
            {
                if (moveList[i].Level > moveList[i + 1].Level)
                {
                    doublecheck = true;
                    MoveSets tempMoveset = moveList[i + 1];
                    moveList[i + 1] = moveList[i];
                    moveList[i] = tempMoveset;
                }
            }
            if (doublecheck)
            {
                SortMoveset(moveList);
            }
            return moveList;
        }
        private void MoveAdd_Button_Click(object sender, EventArgs e)
        {
            if (Moves_CheckBox.Checked == true)
            {
                MoveSets newMoveSet = new();
                newMoveSet.Level = Convert.ToInt32(MoveLevel_Numeric.Value);
                newMoveSet.Move = Moves_ComboBox.Text;
                List<MoveSets> tempList = thisPokemon.Moves.ToList();
                tempList.Add(newMoveSet);
                tempList = SortMoveset(tempList);
                thisPokemon.Moves = tempList.ToArray();
                UpdateMoves();
                return;
            }
            if (TutorMoves_CheckBox.Checked == true)
            {
                List<string> tempList = thisPokemon.TutorMoves.ToList();
                if (tempList.Contains(Moves_ComboBox.Text))
                {
                    return;
                }
                tempList.Add(Moves_ComboBox.Text);
                thisPokemon.TutorMoves = tempList.ToArray();
                UpdateTutorMoves();
                return;
            }
            if (EggMoves_CheckBox.Checked == true)
            {
                List<string> tempList = thisPokemon.Eggmoves.ToList();
                if (tempList.Contains(Moves_ComboBox.Text))
                {
                    return;
                }
                tempList.Add(Moves_ComboBox.Text);
                thisPokemon.Eggmoves = tempList.ToArray();
                UpdateEggMoves();
                return;
            }
        }

        private void MoveDelete_Button_Click(object sender, EventArgs e)
        {
            if (Moves_CheckBox.Checked == true)
            {
                if (thisPokemon.Moves.Length == 0)
                {
                    return;
                }
                List<MoveSets> tempList = thisPokemon.Moves.ToList();
                tempList.RemoveAt(Moves_ListBox.SelectedIndex);
                thisPokemon.Moves = tempList.ToArray();
                UpdateMoves();
                return;
            }
            if (TutorMoves_CheckBox.Checked == true)
            {
                if (thisPokemon.TutorMoves.Length == 0)
                {
                    return;
                }
                List<string> tempList = thisPokemon.TutorMoves.ToList();
                tempList.RemoveAt(TutorMoves_ListBox.SelectedIndex);
                thisPokemon.TutorMoves = tempList.ToArray();
                UpdateTutorMoves();
                return;
            }
            if (EggMoves_CheckBox.Checked == true)
            {
                if (thisPokemon.Eggmoves.Length == 0)
                {
                    return;
                }
                List<string> tempList = thisPokemon.Eggmoves.ToList();
                tempList.RemoveAt(EggMoves_ListBox.SelectedIndex);
                thisPokemon.Eggmoves = tempList.ToArray();
                UpdateEggMoves();
                return;
            }
        }

        private void CompatibilityValidation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CompatibilityValidation_CheckBox.Focused == false)
            {
                return;
            }
            if (CompatibilityValidation_CheckBox.Checked == false)
            {
                Compatibility_ListBox.Enabled = false;
                thisPokemon.EggGroups = Array.Empty<string>();
                UpdateCompatibility();
                return;
            }
            Compatibility_ListBox.Enabled = true;
            Compatibility_ComboBox.Enabled = true;
        }

        private void CompatibilityAdd_Button_Click(object sender, EventArgs e)
        {
            List<string> tempList = thisPokemon.EggGroups.ToList();
            if (tempList.Contains(Compatibility_ComboBox.Text))
            {
                return;
            }
            tempList.Add(Compatibility_ComboBox.Text);
            thisPokemon.EggGroups = tempList.ToArray();
            UpdateCompatibility();
            return;
        }

        private void CompatibilityDel_Button_Click(object sender, EventArgs e)
        {
            if (thisPokemon.EggGroups.Length == 0)
            {
                return;
            }
            List<string> tempList = thisPokemon.EggGroups.ToList();
            tempList.RemoveAt(Compatibility_ListBox.SelectedIndex);
            thisPokemon.EggGroups = tempList.ToArray();
            UpdateCompatibility();
            return;
        }

        private void BaseEXP_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BaseEXP_CheckBox.Focused == false)
            {
                return;
            }
            if (BaseEXP_CheckBox.Checked == false)
            {
                BaseEXP_Numeric.Enabled = false;
                thisPokemon.BaseExp = -1;
                return;
            }
            BaseEXP_Numeric.Enabled = true;
            UpdateBaseEXPEvent();
        }

        private void BaseEXP_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateBaseEXPEvent();
        }
        private void UpdateBaseEXPEvent()
        {
            thisPokemon.BaseExp = Convert.ToInt32(BaseEXP_Numeric.Value);
        }

        private void Rareness_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Rareness_CheckBox.Focused == false)
            {
                return;
            }
            if (Rareness_CheckBox.Checked == false)
            {
                Rareness_Numeric.Enabled = false;
                thisPokemon.CatchRate = -1;
                return;
            }
            Rareness_Numeric.Enabled = true;
            UpdateRarenessEvent();
        }

        private void Rareness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateRarenessEvent();
        }
        private void UpdateRarenessEvent()
        {
            thisPokemon.CatchRate = Convert.ToInt32(Rareness_Numeric.Value);
        }

        private void Happiness_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Happiness_CheckBox.Focused == false)
            {
                return;
            }
            if (Happiness_CheckBox.Checked == false)
            {
                Happiness_Numeric.Enabled = false;
                thisPokemon.Happiness = -1;
                return;
            }
            Happiness_Numeric.Enabled = true;
            UpdateHappinessEvent();
        }

        private void Happiness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateHappinessEvent();
        }
        private void UpdateHappinessEvent()
        {
            thisPokemon.Happiness = Convert.ToInt32(Happiness_Numeric.Value);
        }

        private void StepsToHatch_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StepsToHatch_CheckBox.Focused == false)
            {
                return;
            }
            if (StepsToHatch_CheckBox.Checked == false)
            {
                StepsToHatch_Numeric.Enabled = false;
                thisPokemon.HatchSteps = -1;
                return;
            }
            StepsToHatch_Numeric.Enabled = true;
            UpdateStepsToHatchEvent();
        }

        private void StepsToHatch_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateStepsToHatchEvent();
        }
        private void UpdateStepsToHatchEvent()
        {
            thisPokemon.HatchSteps = Convert.ToInt32(StepsToHatch_Numeric.Value);
        }

        private void Height_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Height_CheckBox.Focused == false)
            {
                return;
            }
            if (Height_CheckBox.Checked == false)
            {
                Height_Numeric.Enabled = false;
                thisPokemon.Height = -1;
                return;
            }
            Height_Numeric.Enabled = true;
            UpdateHeightEvent();
        }

        private void Height_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateHeightEvent();
        }
        private void UpdateHeightEvent()
        {
            thisPokemon.Height = Height_Numeric.Value;
        }

        private void Weight_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Weight_CheckBox.Focused == false)
            {
                return;
            }
            if (Weight_CheckBox.Checked == false)
            {
                Weight_Numeric.Enabled = false;
                thisPokemon.Weight = -1;
                return;
            }
            Weight_Numeric.Enabled = true;
            UpdateWeightEvent();
        }

        private void Weight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateWeightEvent();
        }
        private void UpdateWeightEvent()
        {
            thisPokemon.Weight = Weight_Numeric.Value;
        }

        private void Color_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Color_CheckBox.Focused == false)
            {
                return;
            }
            if (Color_CheckBox.Checked == false)
            {
                Color_ComboBox.Enabled = false;
                thisPokemon.Color = null;
                return;
            }
            Color_ComboBox.Enabled = true;
            UpdateColorEvent();
        }

        private void Color_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateColorEvent();
        }
        private void UpdateColorEvent()
        {
            thisPokemon.Color = Color_ComboBox.Text;
        }
        private void Shape_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Shape_CheckBox.Focused == false)
            {
                return;
            }
            if (Shape_CheckBox.Checked == false)
            {
                Shape_ComboBox.Enabled = false;
                thisPokemon.Shape = null;
                return;
            }
            Shape_ComboBox.Enabled = true;
            UpdateShapeEvent();
        }

        private void Shape_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShapeEvent();
        }
        private void UpdateShapeEvent()
        {
            thisPokemon.Shape = Shape_ComboBox.Text;
        }

        private void Habitat_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Habitat_CheckBox.Focused == false)
            {
                return;
            }
            if (Habitat_CheckBox.Checked == false)
            {
                Habitat_ComboBox.Enabled = false;
                thisPokemon.Habitat = null;
                return;
            }
            Habitat_ComboBox.Enabled = true;
            UpdateHabitatEvent();
        }

        private void Habitat_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHabitatEvent();
        }
        private void UpdateHabitatEvent()
        {
            thisPokemon.Habitat = Habitat_ComboBox.Text;
        }

        private void Kind_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Kind_CheckBox.Focused == false)
            {
                return;
            }
            if (Kind_CheckBox.Checked == false)
            {
                Kind_TextBox.Enabled = false;
                thisPokemon.Category = null;
                return;
            }
            Kind_TextBox.Enabled = true;
            UpdateKindEvent();
        }

        private void Kind_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateKindEvent();
        }
        private void UpdateKindEvent()
        {
            thisPokemon.Category = Kind_TextBox.Text;
        }

        private void Pokedex_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Pokedex_CheckBox.Focused == false)
            {
                return;
            }
            if (Pokedex_CheckBox.Checked == false)
            {
                Pokedex_TextBox.Enabled = false;
                thisPokemon.Pokedex = null;
                return;
            }
            Pokedex_TextBox.Enabled = true;
            UpdatePokedexEvent();
        }

        private void Pokedex_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePokedexEvent();
        }
        private void UpdatePokedexEvent()
        {
            thisPokemon.Pokedex = Pokedex_TextBox.Text;
        }

        private void FormName_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FormName_CheckBox.Focused == false)
            {
                return;
            }
            if (FormName_CheckBox.Checked == false)
            {
                FormName_TextBox.Enabled = false;
                thisPokemon.FormName = null;
                return;
            }
            FormName_TextBox.Enabled = true;
            UpdateFormNameEvent();
        }

        private void FormName_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFormNameEvent();
        }
        private void UpdateFormNameEvent()
        {
            thisPokemon.FormName = FormName_TextBox.Text;
        }

        private void Generation_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Generation_CheckBox.Focused == false)
            {
                return;
            }
            if (Generation_CheckBox.Checked == false)
            {
                Generation_Numeric.Enabled = false;
                thisPokemon.Generation = -1;
                return;
            }
            Generation_Numeric.Enabled = true;
            UpdateGenerationEvent();
        }

        private void Generation_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateGenerationEvent();
        }
        private void UpdateGenerationEvent()
        {
            thisPokemon.Generation = Convert.ToInt32(Generation_Numeric.Value);
        }

        private void WildItemCommon_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WildItemCommon_CheckBox.Focused == false)
            {
                return;
            }
            if (WildItemCommon_CheckBox.Checked == false)
            {
                WildItemCommon_ComboBox.Enabled = false;
                thisPokemon.WildItemCommon = null;
                return;
            }
            WildItemCommon_ComboBox.Enabled = true;
            UpdateWildItemCommonEvent();
        }
        private void WildItemCommon_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWildItemCommonEvent();
        }
        private void UpdateWildItemCommonEvent()
        {
            thisPokemon.WildItemCommon = WildItemCommon_ComboBox.Text;
        }

        private void WildItemUncommon_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WildItemUncommon_CheckBox.Focused == false)
            {
                return;
            }
            if (WildItemUncommon_CheckBox.Checked == false)
            {
                WildItemUncommon_ComboBox.Enabled = false;
                thisPokemon.WildItemUncommon = null;
                return;
            }
            WildItemUncommon_ComboBox.Enabled = true;
            UpdateWildItemUncommonEvent();
        }
        private void WildItemUncommon_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWildItemUncommonEvent();
        }
        private void UpdateWildItemUncommonEvent()
        {
            thisPokemon.WildItemUncommon = WildItemUncommon_ComboBox.Text;
        }

        private void WildItemRare_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WildItemRare_CheckBox.Focused == false)
            {
                return;
            }
            if (WildItemRare_CheckBox.Checked == false)
            {
                WildItemRare_ComboBox.Enabled = false;
                thisPokemon.WildItemRare = null;
                return;
            }
            WildItemRare_ComboBox.Enabled = true;
            UpdateWildItemRareEvent();
        }
        private void WildItemRare_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWildItemRareEvent();
        }
        private void UpdateWildItemRareEvent()
        {
            thisPokemon.WildItemRare = WildItemRare_ComboBox.Text;
        }

        private void Evolutions_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Evolutions_CheckBox.Focused == false)
            {
                return;
            }
            if (Evolutions_CheckBox.Checked == false)
            {
                Species_ComboBox.Enabled = false;
                EvolutionMethod_ComboBox.Enabled = false;
                EvolutionParameter_TextBox.Enabled = false;
                thisPokemon.Evolution = Array.Empty<EvolutionSets>();
                UpdateEvolutions();
                return;
            }
            Species_ComboBox.Enabled = true;
            EvolutionMethod_ComboBox.Enabled = true;
            EvolutionParameter_TextBox.Enabled = true;
        }

        private void EvolutionAdd_Button_Click(object sender, EventArgs e)
        {
            List<EvolutionSets> tempList = thisPokemon.Evolution.ToList();
            EvolutionSets newEvo = new();
            newEvo.InternalName = Species_ComboBox.Text;
            newEvo.EvolutionMethod = EvolutionMethod_ComboBox.Text;
            newEvo.EvolutionParameter = EvolutionParameter_TextBox.Text;
            tempList.Add(newEvo);
            thisPokemon.Evolution = tempList.ToArray();
            UpdateEvolutions();
        }

        private void EvolutionDel_Button_Click(object sender, EventArgs e)
        {
            if (thisPokemon.Evolution.Length == 0)
            {
                return;
            }
            List<EvolutionSets> tempList = thisPokemon.Evolution.ToList();
            tempList.RemoveAt(Evolutions_ListBox.SelectedIndex);
            thisPokemon.Evolution = tempList.ToArray();
            UpdateEvolutions();
        }

        private void MegaStone_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MegaStone_CheckBox.Focused == false)
            {
                return;
            }
            if (MegaStone_CheckBox.Checked == false)
            {
                MegaStone_ComboBox.Enabled = false;
                thisPokemon.MegaStone = null;
                return;
            }
            MegaStone_ComboBox.Enabled = true;
            UpdateMegaStoneEvent();
        }

        private void MegaStone_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMegaStoneEvent();
        }
        private void UpdateMegaStoneEvent()
        {
            thisPokemon.MegaStone = MegaStone_ComboBox.Text;
        }

        private void MegaMove_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MegaMove_CheckBox.Focused == false)
            {
                return;
            }
            if (MegaMove_CheckBox.Checked == false)
            {
                MegaMove_ComboBox.Enabled = false;
                thisPokemon.MegaMove = null;
                return;
            }
            MegaMove_ComboBox.Enabled = true;
            UpdateMegaMoveEvent();
        }

        private void MegaMove_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMegaMoveEvent();
        }
        private void UpdateMegaMoveEvent()
        {
            thisPokemon.MegaMove = MegaMove_ComboBox.Text;
        }

        private void MegaMessage_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MegaMessage_CheckBox.Focused == false)
            {
                return;
            }
            if (MegaMessage_CheckBox.Checked == false)
            {
                MegaMessage_Numeric.Enabled = false;
                thisPokemon.MegaMessage = -1;
                return;
            }
            MegaMessage_Numeric.Enabled = true;
            UpdateMegaMessageEvent();
        }

        private void MegaMessage_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateMegaMessageEvent();
        }
        private void UpdateMegaMessageEvent()
        {
            thisPokemon.MegaMessage = Convert.ToInt32(MegaMessage_Numeric.Value);
        }

        private void UnmegaForm_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UnmegaForm_CheckBox.Focused == false)
            {
                return;
            }
            if (UnmegaForm_CheckBox.Checked == false)
            {
                UnmegaForm_Numeric.Enabled = false;
                thisPokemon.UnmegaForm = -1;
                return;
            }
            UnmegaForm_Numeric.Enabled = true;
            UpdateUnmegaFormEvent();
        }

        private void UnmegaForm_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateUnmegaFormEvent();
        }
        private void UpdateUnmegaFormEvent()
        {
            thisPokemon.UnmegaForm = Convert.ToInt32(UnmegaForm_Numeric.Value);
        }

        private void PokedexForm_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PokedexForm_CheckBox.Focused == false)
            {
                return;
            }
            if (PokedexForm_CheckBox.Checked == false)
            {
                PokedexForm_Numeric.Enabled = false;
                thisPokemon.PokedexForm = -1;
                return;
            }
            PokedexForm_Numeric.Enabled = true;
            UpdatePokedexFormEvent();
        }

        private void PokedexForm_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdatePokedexFormEvent();
        }
        private void UpdatePokedexFormEvent()
        {
            thisPokemon.PokedexForm = Convert.ToInt32(PokedexForm_Numeric.Value);
        }

        private void GenerateForm_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Form.txt";
            using StreamWriter writetext = new(filepath);
            GenerateForm(thisPokemon, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\pokemonforms.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_PokemonForms form in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateForm(form, writetext);
            }
            writetext.Close();
        }
        private static void GenerateForm(PBS_PokemonForms currentPokemon, StreamWriter writetext)
        {
            writetext.WriteLine($"[{currentPokemon.PokemonID},{currentPokemon.FormID}]");
            if (currentPokemon.FormName != null)
            {
                writetext.WriteLine($"FormName = {currentPokemon.FormName}");
            }
            if (currentPokemon.MegaStone != null)
            {
                writetext.WriteLine($"MegaStone = {currentPokemon.MegaStone}");
            }
            if (currentPokemon.MegaMove != null)
            {
                writetext.WriteLine($"MegaMove = {currentPokemon.MegaMove}");
            }
            if (currentPokemon.MegaMessage != -1)
            {
                writetext.WriteLine($"MegaMessage = {currentPokemon.MegaMessage}");
            }
            if (currentPokemon.UnmegaForm != -1)
            {
                writetext.WriteLine($"UnmegaForm = {currentPokemon.UnmegaForm}");
            }
            if (currentPokemon.PokedexForm != -1)
            {
                writetext.WriteLine($"PokedexForm = {currentPokemon.PokedexForm}");
            }
            if (currentPokemon.Type1 != null)
            {
                string tempTypes = $"Types = {currentPokemon.Type1}";
                if (currentPokemon.Type2 != null)
                {
                    tempTypes = $"{tempTypes},{currentPokemon.Type2}";
                }
                writetext.WriteLine($"{tempTypes}");
            }
            if (!currentPokemon.BaseStats.Contains(-1))
            {
                writetext.WriteLine($"BaseStats = {currentPokemon.Hp},{currentPokemon.Atk}," +
                $"{currentPokemon.Def},{currentPokemon.Spd},{currentPokemon.Satk}," +
                $"{currentPokemon.Sdef}");
            }
            if (currentPokemon.BaseExp != -1)
            {
                writetext.WriteLine($"BaseExp = {currentPokemon.BaseExp}");
            }
            if (!currentPokemon.EffortPoints.Contains(-1))
            {
                string temp = "EVs = ";
                if (currentPokemon.HpEV > 0)
                {
                    temp = $"{temp}HP,{currentPokemon.HpEV},";
                }
                if (currentPokemon.AtkEV > 0)
                {
                    temp = $"{temp}ATTACK,{currentPokemon.AtkEV},";
                }
                if (currentPokemon.DefEV > 0)
                {
                    temp = $"{temp}DEFENSE,{currentPokemon.DefEV},";
                }
                if (currentPokemon.SatkEV > 0)
                {
                    temp = $"{temp}SPECIAL_ATTACK,{currentPokemon.SatkEV},";
                }
                if (currentPokemon.SdefEV > 0)
                {
                    temp = $"{temp}SPECIAL_DEFENSE,{currentPokemon.SdefEV},";
                }
                if (currentPokemon.SpdEV > 0)
                {
                    temp = $"{temp}SPEED,{currentPokemon.SpdEV},";
                }
                temp = temp.Remove(temp.Length - 1, 1);
                writetext.WriteLine($"{temp}");
            }
            if (currentPokemon.CatchRate != -1)
            {
                writetext.WriteLine($"Rareness = {currentPokemon.CatchRate}");
            }
            if (currentPokemon.Happiness != -1)
            {
                writetext.WriteLine($"Happiness = {currentPokemon.Happiness}");
            }
            if (currentPokemon.Abilities.Length > 0)
            {
                string temp = "Abilities = ";
                for (int i = 0; i < currentPokemon.Abilities.Length; i++)
                {
                    temp = $"{temp}{currentPokemon.Abilities[i]}";
                    if (i < currentPokemon.Abilities.Length - 1)
                    {
                        temp = $"{temp},";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.HiddenAbility.Length > 0)
            {
                string temp = "HiddenAbilities = ";
                for (int i = 0; i < currentPokemon.HiddenAbility.Length; i++)
                {
                    temp = $"{temp}{currentPokemon.HiddenAbility[i]}";
                    if (i < currentPokemon.HiddenAbility.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.Moves.Length > 0)
            {
                string temp = "Moves = ";
                for (int i = 0; i < currentPokemon.Moves.Length; i++)
                {
                    temp = $"{ temp }{ currentPokemon.Moves[i].Generation }";
                    if (i < currentPokemon.Moves.Length - 1)
                    {
                        temp = $"{temp},";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.TutorMoves.Length > 0)
            {
                string temp = "TutorMoves = ";
                for (int i = 0; i < currentPokemon.TutorMoves.Length; i++)
                {
                    temp = $"{ temp }{ currentPokemon.TutorMoves[i] }";
                    if (i < currentPokemon.TutorMoves.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.Eggmoves.Length > 0)
            {
                string temp = "EggMoves = ";
                for (int i = 0; i < currentPokemon.Eggmoves.Length; i++)
                {
                    temp = $"{ temp }{currentPokemon.Eggmoves[i]}";
                    if (i < currentPokemon.Eggmoves.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.EggGroups.Length > 0)
            {
                string temp = "EggGroups = ";
                for (int i = 0; i < currentPokemon.EggGroups.Length; i++)
                {
                    temp = $"{ temp }{currentPokemon.EggGroups[i]}";
                    if (i < currentPokemon.EggGroups.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.HatchSteps != -1)
            {
                writetext.WriteLine($"HatchSteps = {currentPokemon.HatchSteps}");
            }
            if (currentPokemon.Offspring.Length > 0)
            {
                string temp = "Offspring = ";
                for (int i = 0; i < currentPokemon.Offspring.Length; i++)
                {
                    temp = $"{temp}{currentPokemon.Offspring[i]}";
                    if (i < currentPokemon.Offspring.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentPokemon.Height != -1)
            {
                writetext.WriteLine($"Height = {currentPokemon.Height.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)}");
            }
            if (currentPokemon.Weight != -1)
            {
                writetext.WriteLine($"Weight = {currentPokemon.Weight.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)}");
            }
            if (currentPokemon.Color != null)
            {
                writetext.WriteLine($"Color = {currentPokemon.Color}");
            }
            if (currentPokemon.Shape != null)
            {
                writetext.WriteLine($"Shape = {currentPokemon.Shape}");
            }
            if (currentPokemon.Habitat != null)
            {
                writetext.WriteLine($"Habitat = {currentPokemon.Habitat}");
            }
            if (currentPokemon.Category != null)
            {
                writetext.WriteLine($"Category = {currentPokemon.Category}");
            }
            if (currentPokemon.Pokedex != null)
            {
                writetext.WriteLine($"Pokedex = {currentPokemon.Pokedex}");
            }
            if (currentPokemon.Generation != -1)
            {
                writetext.WriteLine($"Generation = {currentPokemon.Generation}");
            }
            if (currentPokemon.Flags != "")
            {
                writetext.WriteLine($"Flags = {currentPokemon.Flags.Trim()}");
            }
            if (currentPokemon.WildItemCommon != null)
            {
                writetext.WriteLine($"WildItemCommon = {currentPokemon.WildItemCommon}");
            }
            if (currentPokemon.WildItemUncommon != null)
            {
                writetext.WriteLine($"WildItemUncommon = {currentPokemon.WildItemUncommon}");
            }
            if (currentPokemon.WildItemRare != null)
            {
                writetext.WriteLine($"WildItemRare = {currentPokemon.WildItemRare}");
            }
            if (currentPokemon.Evolution.Length > 0)
            {
                string temp = "Evolutions = ";
                for (int i = 0; i < currentPokemon.Evolution.Length; i++)
                {
                    temp = $"{ temp }{ currentPokemon.Evolution[i].Generation }";
                    if (i < currentPokemon.Evolution.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
        }

        private void OpenForm_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Form.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\pokemonforms.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_PokemonForms> tempDic = new();
            bool errorfound = false;
            foreach (PBS_PokemonForms form in thisList)
            {
                if (tempDic.ContainsKey(form.Identification))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(form.Identification))
                {
                    tempDic.Add(form.Identification, form);
                }
            }
            if (!errorfound)
            {
                Global.PokemonFormsDictionary = tempDic;
                Global.RefreshStatDictionary();
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_PokemonForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close PokemonForms",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }

        private void ShowStatDetails_Button_Click(object sender, EventArgs e)
        {
            Form_TotalStats TotalStatsForm = new(Convert.ToInt32(TotalBaseStatsNumeric.Value));
            TotalStatsForm.Show();
        }

        private void Button_AddOffspring_Click(object sender, EventArgs e)
        {
            List<string> tempList = thisPokemon.Offspring.ToList();
            if (thisPokemon.Offspring.Contains(offspringcomboBox.Text))
            {
                return;
            }
            tempList.Add(offspringcomboBox.Text);
            thisPokemon.Offspring = tempList.ToArray();
            UpdateOffspring();
            return;
        }

        private void Button_DelOffspring_Click(object sender, EventArgs e)
        {
            if (thisPokemon.Offspring.Length == 0)
            {
                return;
            }
            List<string> tempList = thisPokemon.Offspring.ToList();
            tempList.RemoveAt(offspring_Listbox.SelectedIndex);
            thisPokemon.Offspring = tempList.ToArray();
            UpdateOffspring();
            return;
        }

        private void UpdateFlagListBox()
        {
            for (int i = 0; i < Flags_CheckedListBox.Items.Count; i++)
            {
                bool state = false;
                string thisFlag = (string)Flags_CheckedListBox.Items[i];
                if (thisPokemon.Flags.Contains(thisFlag))
                {
                    state = true;
                }
                if (state)
                {
                    Flags_CheckedListBox.SetItemChecked(i, true);
                }
                if (!state)
                {
                    Flags_CheckedListBox.SetItemChecked(i, false);
                }
            }
        }

        private void UpdateFlag_Button_Click(object sender, EventArgs e)
        {
            List<string> tempList = new();
            for (int i = 0; i < Flags_CheckedListBox.CheckedItems.Count; i++)
            {
                string currFlag = (string)Flags_CheckedListBox.CheckedItems[i];
                tempList.Add(currFlag);
            }
            string[] flagarray = tempList.ToArray();
            string flags = "";
            for (int i = 0; i < flagarray.Length; i++)
            {
                flags = $"{flags}{flagarray[i]}";
                if (i < flagarray.Length - 1)
                {
                    flags = $"{flags},";
                }
            }
            thisPokemon.Flags = flags;
            UpdateFlagListBox();
        }
    }
}
