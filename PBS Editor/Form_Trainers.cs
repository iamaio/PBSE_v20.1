using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_Trainers : Form
    {
        readonly BindingSource TrainersListBS = new();
        readonly BindingSource TrainerItemsListBS = new();
        readonly BindingSource TrainerBattlersListBS = new();
        readonly BindingSource BattlerMovesListBS = new();
        PBS_Trainers thisTrainer = new();
        Battlers thisBattler = new();
        readonly List<PBS_Trainers> thisList = Global.Trainers_Dictionary.Values.ToList();
        List<string> PossibleAbilities = new();
        List<string> PossibleHiddenAbilities = new();
        public Form_Trainers()
        {
            InitializeComponent();
            TrainersListBS.DataSource = thisList;
            Trainers_ListBox.DataSource = TrainersListBS;
            Trainers_ListBox.DisplayMember = "Identification";
            TrainerType_ComboBox.DataSource = Global.TrainerTypesDictionary.Keys.ToList();
            Item_ComboBox.DataSource = Global.ItemsDictionary.Keys.ToList();
            BattlerSpecies_ComboBox.DataSource = Global.PokemonsDictionary.Keys.ToList();
            BattlerItem_ComboBox.DataSource = Global.ItemsDictionary.Keys.ToList();
            BattlerMoves_ComboBox.DataSource = Global.MovesDictionary.Keys.ToList();
            Nature_ComboBox.DataSource = Global.NatureArray;
            GlobalAbility_ComboBox.DataSource = Global.AbilitiesDictionary.Keys.ToList();
            BallType_ComboBox.DataSource = Global.BallTypeArray;
            List<string> GenderComboBox = new();
            GenderComboBox.Add("male"); GenderComboBox.Add("female");
            Gender_ComboBox.DataSource = GenderComboBox;
            SetupCustomMechanics();
            if (thisList.Count > 0)
            {
                Trainers_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Trainers_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Trainers_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }
        private void UpdateMainList()
        {
            thisTrainer = (PBS_Trainers)this.Trainers_ListBox.SelectedItem;
            TrainerType_ComboBox.Text = thisTrainer.TrainerType;
            Name_TextBox.Text = thisTrainer.Name;
            ID_Numeric.Value = thisTrainer.ID;
            Lose_TextBox.Text = thisTrainer.LoseText;
            UpdateTrainerItems();
            UpdateTrainerBattlers();
        }

        private void UpdateBattler()
        {
            if (thisTrainer.Battlers.Length > 0)
            {
                thisBattler = (Battlers)this.Battlers_ListBox.SelectedItem;
                BattlerSpecies_ComboBox.Text = thisBattler.Species;
                BattlerLevel_Numeric.Value = thisBattler.Level;
                UpdateBattlerItem();
                UpdateBattlerMoves();
                UpdateBattlerAbilities();
                UpdateBattlerGlobalAbility();
                UpdateBattlerGender();
                Form_Numeric.Value = thisBattler.Form;
                UpdateBattlerShiny();
                UpdateBattlerSuperShiny();
                UpdateBattlerIVS();
                UpdateBattlerEVS();
                UpdateBattlerNature();
                UpdateBattlerHappiness();
                Nick_TextBox.Text = thisBattler.Nickname;
                UpdateBattlerShadow();
                UpdateBattlerBallType();
                UpdateBattlerCustomMechanics();
            }
        }

        private void UpdateBattlerEVS()
        {
            if (thisBattler.EVS.Length == 0)
            {
                EV_CheckBox.Checked = false;
                DisableEVS();
                return;
            }
            EV_CheckBox.Checked = true;
            int[] tempEVS = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int tempEV = thisBattler.EVS[0];
                if (thisBattler.EVS.Length > i)
                {
                    tempEV = thisBattler.EVS[i];
                }
                tempEVS[i] = tempEV;
            }
            EnableEVS();
            EVHP_Numeric.Value = tempEVS[0];
            EVATK_Numeric.Value = tempEVS[1];
            EVDEF_Numeric.Value = tempEVS[2];
            EVSPD_Numeric.Value = tempEVS[3];
            EVSATK_Numeric.Value = tempEVS[4];
            EVSDEF_Numeric.Value = tempEVS[5];
        }
        private void UpdateBattlerIVS()
        {
            if (thisBattler.IVS.Length == 0)
            {
                IV_CheckBox.Checked = false;
                DisableIVS();
                return;
            }
            IV_CheckBox.Checked = true;
            int[] tempIVS = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int tempIV = thisBattler.IVS[0];
                if (thisBattler.IVS.Length > i)
                {
                    tempIV = thisBattler.IVS[i];
                }
                tempIVS[i] = tempIV;
            }
            EnableIVS();
            HPIV_Numeric.Value = tempIVS[0];
            ATKIV_Numeric.Value = tempIVS[1];
            DEFIV_Numeric.Value = tempIVS[2];
            SPDIV_Numeric.Value = tempIVS[3];
            SATKIV_Numeric.Value = tempIVS[4];
            SDEFIV_Numeric.Value = tempIVS[5];
        }
        private void UpdateBattlerGlobalAbility()
        {
            if (thisBattler.Ability == null)
            {
                GlobalAbility_CheckBox.Checked = false;
                GlobalAbility_ComboBox.Enabled = false;
                return;
            }
            GlobalAbility_CheckBox.Checked = true;
            GlobalAbility_ComboBox.Enabled = true;
            GlobalAbility_ComboBox.Text = thisBattler.Ability;
        }
        private void UpdateBattlerAbilities()
        {
            PossibleAbilities = new();
            PossibleHiddenAbilities = new();
            List<string> AllAbilities = new();
            if (thisBattler.Form == 0)
            {
                foreach (string ability in Global.PokemonsDictionary[thisBattler.Species].Abilities)
                {
                    PossibleAbilities.Add(ability);
                    AllAbilities.Add(ability);
                }
                foreach (string ability in Global.PokemonsDictionary[thisBattler.Species].HiddenAbility)
                {
                    PossibleHiddenAbilities.Add(ability);
                    AllAbilities.Add(ability);
                }
            }
            if (thisBattler.Form > 0)
            {
                foreach (string ability in Global.PokemonFormsDictionary[$"{thisBattler.Species}_{thisBattler.Form}"].Abilities)
                {
                    PossibleAbilities.Add(ability);
                    AllAbilities.Add(ability);
                }
                foreach (string ability in Global.PokemonFormsDictionary[$"{thisBattler.Species}_{thisBattler.Form}"].HiddenAbility)
                {
                    PossibleHiddenAbilities.Add(ability);
                    AllAbilities.Add(ability);
                }
            }
            Ability_ComboBox.DataSource = AllAbilities;

            if (thisBattler.AbilityIndex == -1)
            {
                Ability_CheckBox.Checked = false;
                Ability_ComboBox.Enabled = false;
                return;
            }
            Ability_CheckBox.Checked = true;
            Ability_ComboBox.Enabled = true;
            if (thisBattler.AbilityIndex <= 1)
            {
                Ability_ComboBox.Text = PossibleAbilities[thisBattler.AbilityIndex];
                return;
            }
            Ability_ComboBox.Text = PossibleHiddenAbilities[thisBattler.AbilityIndex - 2];
        }
        private void UpdateBattlerBallType()
        {
            if (thisBattler.BallType == null)
            {
                Balltype_CheckBox.Checked = false;
                BallType_ComboBox.Enabled = false;
                return;
            }
            Balltype_CheckBox.Checked = true;
            BallType_ComboBox.Enabled = true;
            BallType_ComboBox.Text = thisBattler.BallType;
        }
        private void UpdateBattlerCustomMechanics()
        {
            textBox_Mechanic1.Text = thisBattler.Mechanic1;
            textBox_Mechanic2.Text = thisBattler.Mechanic2;
            textBox_Mechanic3.Text = thisBattler.Mechanic3;
            textBox_Mechanic4.Text = thisBattler.Mechanic4;
            textBox_Mechanic5.Text = thisBattler.Mechanic5;
            textBox_Mechanic6.Text = thisBattler.Mechanic6;
            textBox_Mechanic7.Text = thisBattler.Mechanic7;
            textBox_Mechanic8.Text = thisBattler.Mechanic8;
            textBox_Mechanic9.Text = thisBattler.Mechanic9;
        }
        private void UpdateBattlerHappiness()
        {
            if (thisBattler.Happiness == -1)
            {
                Happiness_CheckBox.Checked = false;
                Happiness_Numeric.Enabled = false;
                return;
            }
            Happiness_CheckBox.Checked = true;
            Happiness_Numeric.Enabled = true;
            Happiness_Numeric.Value = thisBattler.Happiness;
        }
        private void UpdateBattlerShadow()
        {
            if (thisBattler.Shadow != "yes")
            {
                Shadow_CheckBox.Checked = false;
                return;
            }
            Shadow_CheckBox.Checked = true;
        }
        private void UpdateBattlerNature ()
        {
            if (thisBattler.Nature == null)
            {
                Nature_CheckBox.Checked = false;
                Nature_ComboBox.Enabled = false;
                return;
            }
            Nature_CheckBox.Checked = true;
            Nature_ComboBox.Enabled = true;
            Nature_ComboBox.Text = thisBattler.Nature;
        }
        private void UpdateBattlerShiny() 
        {
            if (thisBattler.Shiny != "yes")
            {
                Shiny_CheckBox.Checked = false;
                return;
            }
            Shiny_CheckBox.Checked = true;
        }
        private void UpdateBattlerSuperShiny()
        {
            if (thisBattler.SuperShiny != "yes")
            {
                checkBox_SuperShiny.Checked = false;
                return;
            }
            checkBox_SuperShiny.Checked = true;
        }
        private void UpdateBattlerGender()
        {
            if (thisBattler.Gender == null)
            {
                Gender_CheckBox.Checked = false;
                Gender_ComboBox.Enabled = false;
                return;
            }
            Gender_CheckBox.Checked = true;
            Gender_ComboBox.Enabled = true;
            Gender_ComboBox.Text = thisBattler.Gender;
        }
        private void UpdateBattlerMoves()
        {
            BattlerMovesListBS.DataSource = thisBattler.Moves;
            BattlerMoves_ListBox.DataSource = BattlerMovesListBS;
            if (thisBattler.Moves.Length == 0)
            {
                BattlerMoves_CheckBox.Checked = false;
                BattlerMoves_ListBox.Enabled = false;
                BattlerMoves_ComboBox.Enabled = false;
                return;
            }
            BattlerMoves_CheckBox.Checked = true;
            BattlerMoves_ListBox.Enabled = true;
            BattlerMoves_ComboBox.Enabled = true;
        }
        private void UpdateBattlerItem()
        {
            if (thisBattler.Item == null)
            {
                BattlerItem_CheckBox.Checked = false;
                BattlerItem_ComboBox.Enabled = false;
                return;
            }
            BattlerItem_CheckBox.Checked = true;
            BattlerItem_ComboBox.Enabled = true;
            BattlerItem_ComboBox.Text = thisBattler.Item;
        }

        private void UpdateTrainerBattlers()
        {
            TrainerBattlersListBS.DataSource = thisTrainer.Battlers;
            Battlers_ListBox.DataSource = TrainerBattlersListBS;
            Battlers_ListBox.DisplayMember = "Identification";
            UpdateBattler();
        }

        private void UpdateTrainerItems()
        {
            TrainerItemsListBS.DataSource = thisTrainer.Items;
            Items_ListBox.DataSource = TrainerItemsListBS;
        }

        private void Battlers_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Battlers_ListBox.Focused == true)
            {
                UpdateBattler();
            }
        }

        private void TrainerType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisTrainer.TrainerType = TrainerType_ComboBox.Text;
            TrainersListBS.ResetBindings(false);
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainer.Name = Name_TextBox.Text;
            TrainersListBS.ResetBindings(false);
        }

        private void ID_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisTrainer.ID = Convert.ToInt32(ID_Numeric.Value);
            TrainersListBS.ResetBindings(false);
        }

        private void Lose_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainer.LoseText = Lose_TextBox.Text;
        }

        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            List<string> tempList = thisTrainer.Items.ToList();
            tempList.Add(Item_ComboBox.Text);
            thisTrainer.Items = tempList.ToArray();
            UpdateTrainerItems();
        }

        private void DeleteItem_Button_Click(object sender, EventArgs e)
        {
            if (thisTrainer.Items.Length == 0)
            {
                return;
            }
            List<string> tempList = thisTrainer.Items.ToList();
            tempList.RemoveAt(Items_ListBox.SelectedIndex);
            thisTrainer.Items = tempList.ToArray();
            UpdateTrainerItems();
        }

        private void AddBattler_Button_Click(object sender, EventArgs e)
        {
            if (thisTrainer.Battlers.Length == 6)
            {
                return;
            }
            List<Battlers> tempList = thisTrainer.Battlers.ToList();
            Battlers newBattler = new();
            newBattler.Species = "CHARMANDER";
            newBattler.Level = 1;
            tempList.Add(newBattler);
            thisTrainer.Battlers = tempList.ToArray();
            UpdateTrainerBattlers();
        }

        private void DeleteBattler_Button_Click(object sender, EventArgs e)
        {
            if (thisTrainer.Battlers.Length == 0)
            {
                return;
            }
            List<Battlers> tempList = thisTrainer.Battlers.ToList();
            tempList.RemoveAt(Battlers_ListBox.SelectedIndex);
            thisTrainer.Battlers = tempList.ToArray();
            UpdateTrainerBattlers();
        }

        private void TrainerAdd_Button_Click(object sender, EventArgs e)
        {
            PBS_Trainers newTrainer = new();
            thisList.Add(newTrainer);
            TrainersListBS.ResetBindings(false);
            Trainers_ListBox.SelectedIndex = Trainers_ListBox.Items.Count - 1;
            UpdateMainList();
        }

        private void TrainerDelete_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Trainer?", "Delete Trainer", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(Trainers_ListBox.SelectedIndex);
                TrainersListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void BattlerSpecies_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisBattler.Species = BattlerSpecies_ComboBox.Text;
            if (BattlerSpecies_ComboBox.Focused == true)
            {
                thisBattler.Ability = null;
                thisBattler.AbilityIndex = -1;
                UpdateBattler();
            }
            TrainerBattlersListBS.ResetBindings(false);
        }

        private void BattlerLevel_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisBattler.Level = Convert.ToInt32(BattlerLevel_Numeric.Value);
            TrainerBattlersListBS.ResetBindings(false);
        }

        private void BattlerItem_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BattlerItem_CheckBox.Focused == false)
            {
                return;
            }
            if (BattlerItem_CheckBox.Checked == false)
            {
                BattlerItem_ComboBox.Enabled = false;
                thisBattler.Item = null;
                return;
            }
            BattlerItem_ComboBox.Enabled = true;
            BattlerItemEvent();
        }

        private void BattlerItem_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BattlerItemEvent();
        }

        private void BattlerItemEvent()
        {
            thisBattler.Item = BattlerItem_ComboBox.Text;
        }

        private void BattlerMoves_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BattlerMoves_CheckBox.Focused == false)
            {
                return;
            }
            if (BattlerMoves_CheckBox.Checked == false)
            {
                BattlerMoves_ListBox.Enabled = false;
                BattlerMoves_ComboBox.Enabled = false;
                thisBattler.Moves = Array.Empty<string>();
                return;
            }
            BattlerMoves_ListBox.Enabled = true;
            BattlerMoves_ComboBox.Enabled = true;
        }

        private void BattlerMoves_AddButton_Click(object sender, EventArgs e)
        {
            if (BattlerMoves_CheckBox.Checked == false || thisBattler.Moves.Length == 4
                || thisBattler.Moves.Contains(BattlerMoves_ComboBox.Text))
            {
                return;
            }
            List<string> tempList = thisBattler.Moves.ToList();
            tempList.Add(BattlerMoves_ComboBox.Text);
            thisBattler.Moves = tempList.ToArray();
            UpdateBattlerMoves();
        }

        private void BattlerMoves_DelButton_Click(object sender, EventArgs e)
        {
            if (BattlerMoves_CheckBox.Checked == false || thisBattler.Moves.Length == 0)
            {
                return;
            }
            List<string> tempList = thisBattler.Moves.ToList();
            tempList.RemoveAt(BattlerMoves_ListBox.SelectedIndex);
            thisBattler.Moves = tempList.ToArray();
            UpdateBattlerMoves();
        }

        private void GlobalAbility_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GlobalAbility_CheckBox.Focused == false)
            {
                return;
            }
            if (GlobalAbility_CheckBox.Checked == false)
            {
                GlobalAbility_ComboBox.Enabled = false;
                thisBattler.Ability = null;
                return;
            }
            Ability_CheckBox.Checked = false;
            Ability_ComboBox.Enabled = false;
            thisBattler.AbilityIndex = -1;
            GlobalAbility_ComboBox.Enabled = true;
            BattlerGlobalAbilityEvent();
        }

        private void GlobalAbility_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalAbility_ComboBox.Focused == false)
            {
                return;
            }
            BattlerGlobalAbilityEvent();
        }
        private void BattlerGlobalAbilityEvent()
        {
            thisBattler.Ability = GlobalAbility_ComboBox.Text;
        }
        private void Ability_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Ability_CheckBox.Focused == false)
            {
                return;
            }
            if (Ability_CheckBox.Checked == false)
            {
                Ability_ComboBox.Enabled = false;
                thisBattler.AbilityIndex = -1;
                return;
            }
            GlobalAbility_CheckBox.Checked = false;
            GlobalAbility_ComboBox.Enabled = false;
            thisBattler.Ability = null;
            Ability_ComboBox.Enabled = true;
            BattlerAbilityEvent();
        }

        private void Ability_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ability_ComboBox.Focused == false)
            {
                return;
            }
            BattlerAbilityEvent();
        }

        private void BattlerAbilityEvent()
        {
            thisBattler.AbilityIndex = GetBattlerAbility();
        }

        private void Gender_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Gender_CheckBox.Focused == false)
            {
                return;
            }
            if (Gender_CheckBox.Checked == false)
            {
                Gender_ComboBox.Enabled = false;
                thisBattler.Gender = null;
                return;
            }
            Gender_ComboBox.Enabled = true;
            BattlerGenderEvent();
        }

        private void Gender_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BattlerGenderEvent();
        }

        private void BattlerGenderEvent()
        {
            thisBattler.Gender = Gender_ComboBox.Text;
        }

        private void Form_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (Form_Numeric.Focused == false)
            {
                return;
            }
            thisBattler.Form = Convert.ToInt32(Form_Numeric.Value);
            if (thisBattler.Form > Global.PokemonsDictionary[thisBattler.Species].Forms)
            {
                thisBattler.Form = Global.PokemonsDictionary[thisBattler.Species].Forms;
            }
            thisBattler.Ability = null;
            thisBattler.AbilityIndex = -1;
            UpdateBattler();
        }

        private void Shiny_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Shiny_CheckBox.Focused == false)
            {
                return;
            }
            if (Shiny_CheckBox.Checked == false)
            {
                thisBattler.Shiny = null;
                return;
            }
            thisBattler.Shiny = "yes";
            thisBattler.SuperShiny = null;
            checkBox_SuperShiny.Checked = false;
        }

        private void CheckBox_SuperShiny_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SuperShiny.Focused == false)
            {
                return;
            }
            if (checkBox_SuperShiny.Checked == false)
            {
                thisBattler.SuperShiny = null;
                return;
            }
            thisBattler.SuperShiny = "yes";
            thisBattler.Shiny = "null";
            Shiny_CheckBox.Checked = false;
        }

        private int GetBattlerAbility()
        {
            for (int i = 0; i < PossibleAbilities.Count; i++)
            {
                if (PossibleAbilities[i] == Ability_ComboBox.Text)
                {
                    return i;
                }
            }
            for (int i = 0; i < PossibleHiddenAbilities.Count; i++)
            {
                if (PossibleHiddenAbilities[i] == Ability_ComboBox.Text)
                {
                    return i + 2;
                }
            }
            return 0;
        }

        private void Nature_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Nature_CheckBox.Focused == false)
            {
                return;
            }
            if (Nature_CheckBox.Checked == false)
            {
                Nature_ComboBox.Enabled = false;
                thisBattler.Nature = null;
                return;
            }
            Nature_ComboBox.Enabled = true;
            BattlerNatureEvent();
        }

        private void Nature_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BattlerNatureEvent();
        }

        private void BattlerNatureEvent()
        {
            thisBattler.Nature = Nature_ComboBox.Text;
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
                thisBattler.Happiness = -1;
                return;
            }
            Happiness_Numeric.Enabled = true;
            BattlerHappinessEvent();
        }

        private void Happiness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            BattlerHappinessEvent();
        }

        private void BattlerHappinessEvent()
        {
            thisBattler.Happiness = Convert.ToInt32(Happiness_Numeric.Value);
        }

        private void Nick_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Nick_TextBox.Text.Length > 10)
            {
                Nick_TextBox.Text = "Too Long";
                return;
            }
            thisBattler.Nickname = Nick_TextBox.Text;
        }

        private void TextBox_Mechanic1_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic1 = textBox_Mechanic1.Text;
        }

        private void TextBox_Mechanic2_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic2 = textBox_Mechanic2.Text;
        }

        private void TextBox_Mechanic3_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic3 = textBox_Mechanic3.Text;
        }

        private void TextBox_Mechanic4_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic4 = textBox_Mechanic4.Text;
        }

        private void TextBox_Mechanic5_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic5 = textBox_Mechanic5.Text;
        }

        private void TextBox_Mechanic6_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic6 = textBox_Mechanic6.Text;
        }

        private void TextBox_Mechanic7_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic7 = textBox_Mechanic7.Text;
        }

        private void TextBox_Mechanic8_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic8 = textBox_Mechanic8.Text;
        }

        private void TextBox_Mechanic9_TextChanged(object sender, EventArgs e)
        {
            thisBattler.Mechanic9 = textBox_Mechanic9.Text;
        }

        private void Shadow_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Shadow_CheckBox.Focused == false)
            {
                return;
            }
            if (Shadow_CheckBox.Checked == false)
            {
                thisBattler.Shadow = null;
                return;
            }
            thisBattler.Shadow = "yes";
        }

        private void Balltype_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Balltype_CheckBox.Focused == false)
            {
                return;
            }
            if (Balltype_CheckBox.Checked == false)
            {
                BallType_ComboBox.Enabled = false;
                thisBattler.BallType = null;
                return;
            }
            BallType_ComboBox.Enabled = true;
            BattlerBallTypeEvent();
        }

        private void BallType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BattlerBallTypeEvent();
        }

        private void BattlerBallTypeEvent()
        {
            thisBattler.BallType = BallType_ComboBox.Text;
        }

        private void IV_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IV_CheckBox.Focused == false)
            {
                return;
            }
            if (IV_CheckBox.Checked == false)
            {
                thisBattler.IVS = Array.Empty<int>();
                DisableIVS();
                return;
            }
            EnableIVS();
        }

        private void EV_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EV_CheckBox.Focused == false)
            {
                return;
            }
            if (EV_CheckBox.Checked == false)
            {
                thisBattler.EVS = Array.Empty<int>();
                DisableEVS();
                return;
            }
            EnableEVS();
        }

        private void DisableIVS()
        {
            HPIV_Numeric.Enabled = false;
            ATKIV_Numeric.Enabled = false;
            DEFIV_Numeric.Enabled = false;
            SPDIV_Numeric.Enabled = false;
            SATKIV_Numeric.Enabled = false;
            SDEFIV_Numeric.Enabled = false;
        }

        private void EnableIVS()
        {
            HPIV_Numeric.Enabled = true;
            ATKIV_Numeric.Enabled = true;
            DEFIV_Numeric.Enabled = true;
            SPDIV_Numeric.Enabled = true;
            SATKIV_Numeric.Enabled = true;
            SDEFIV_Numeric.Enabled = true;
            if (IV_CheckBox.Focused == true)
            {
                UpdateIVs();
            }
        }

        private void EnableEVS()
        {
            EVHP_Numeric.Enabled = true;
            EVATK_Numeric.Enabled = true;
            EVDEF_Numeric.Enabled = true;
            EVSPD_Numeric.Enabled = true;
            EVSATK_Numeric.Enabled = true;
            EVSDEF_Numeric.Enabled = true;
            if (EV_CheckBox.Focused == true)
            {
                UpdateEVs();
            }
        }

        private void DisableEVS()
        {
            EVHP_Numeric.Enabled = false;
            EVATK_Numeric.Enabled = false;
            EVDEF_Numeric.Enabled = false;
            EVSPD_Numeric.Enabled = false;
            EVSATK_Numeric.Enabled = false;
            EVSDEF_Numeric.Enabled = false;
        }

        private void HPIV_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateIVs();
        }

        private void ATKIV_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateIVs();
        }

        private void DEFIV_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateIVs();
        }

        private void SPDIV_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateIVs();
        }

        private void SATKIV_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateIVs();
        }

        private void SDEFIV_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateIVs();
        }

        private void UpdateIVs()
        {
            int[] newivs = { 0, 0, 0, 0, 0, 0 };
            newivs[0] = Convert.ToInt32(HPIV_Numeric.Value);
            newivs[1] = Convert.ToInt32(ATKIV_Numeric.Value);
            newivs[2] = Convert.ToInt32(DEFIV_Numeric.Value);
            newivs[3] = Convert.ToInt32(SPDIV_Numeric.Value);
            newivs[4] = Convert.ToInt32(SATKIV_Numeric.Value);
            newivs[5] = Convert.ToInt32(SDEFIV_Numeric.Value);
            thisBattler.IVS = newivs;
        }

        private void EVHP_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateEVs();
        }

        private void EVATK_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateEVs();
        }

        private void EVDEF_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateEVs();
        }

        private void EVSPD_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateEVs();
        }

        private void EVSATK_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateEVs();
        }

        private void EVSDEF_Numeric_ValueChanged(object sender, EventArgs e)
        {
            UpdateEVs();
        }

        private void UpdateEVs()
        {
            int[] newevs = { 0, 0, 0, 0, 0, 0 };
            newevs[0] = Convert.ToInt32(EVHP_Numeric.Value);
            newevs[1] = Convert.ToInt32(EVATK_Numeric.Value);
            newevs[2] = Convert.ToInt32(EVDEF_Numeric.Value);
            newevs[3] = Convert.ToInt32(EVSPD_Numeric.Value);
            newevs[4] = Convert.ToInt32(EVSATK_Numeric.Value);
            newevs[5] = Convert.ToInt32(EVSDEF_Numeric.Value);
            thisBattler.EVS = newevs;
        }

        private void SetupCustomMechanics()
        {
            if (Global.BattlerCustomMechanics["Mechanic1"] == "Mechanic1")
            {
                label_Mechanic1.Visible = false;
                textBox_Mechanic1.Visible = false;
            }
            label_Mechanic1.Text = Global.BattlerCustomMechanics["Mechanic1"];
            if (Global.BattlerCustomMechanics["Mechanic2"] == "Mechanic2")
            {
                label_Mechanic2.Visible = false;
                textBox_Mechanic2.Visible = false;
            }
            label_Mechanic2.Text = Global.BattlerCustomMechanics["Mechanic2"];
            if (Global.BattlerCustomMechanics["Mechanic3"] == "Mechanic3")
            {
                label_Mechanic3.Visible = false;
                textBox_Mechanic3.Visible = false;
            }
            label_Mechanic3.Text = Global.BattlerCustomMechanics["Mechanic3"];
            if (Global.BattlerCustomMechanics["Mechanic4"] == "Mechanic4")
            {
                label_Mechanic4.Visible = false;
                textBox_Mechanic4.Visible = false;
            }
            label_Mechanic4.Text = Global.BattlerCustomMechanics["Mechanic4"];
            if (Global.BattlerCustomMechanics["Mechanic5"] == "Mechanic5")
            {
                label_Mechanic5.Visible = false;
                textBox_Mechanic5.Visible = false;
            }
            label_Mechanic5.Text = Global.BattlerCustomMechanics["Mechanic5"];
            if (Global.BattlerCustomMechanics["Mechanic6"] == "Mechanic6")
            {
                label_Mechanic6.Visible = false;
                textBox_Mechanic6.Visible = false;
            }
            label_Mechanic6.Text = Global.BattlerCustomMechanics["Mechanic6"];
            if (Global.BattlerCustomMechanics["Mechanic7"] == "Mechanic7")
            {
                label_Mechanic7.Visible = false;
                textBox_Mechanic7.Visible = false;
            }
            label_Mechanic7.Text = Global.BattlerCustomMechanics["Mechanic7"];
            if (Global.BattlerCustomMechanics["Mechanic8"] == "Mechanic8")
            {
                label_Mechanic8.Visible = false;
                textBox_Mechanic8.Visible = false;
            }
            label_Mechanic8.Text = Global.BattlerCustomMechanics["Mechanic8"];
            if (Global.BattlerCustomMechanics["Mechanic9"] == "Mechanic9")
            {
                label_Mechanic9.Visible = false;
                textBox_Mechanic9.Visible = false;
            }
            label_Mechanic9.Text = Global.BattlerCustomMechanics["Mechanic9"];
        }

        private void GenerateTrainer_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Trainer.txt";
            using StreamWriter writetext = new(filepath);
            GenerateTrainer(thisTrainer, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\trainers.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_Trainers trainer in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateTrainer(trainer, writetext);
            }
            writetext.Close();
        }
        private static void GenerateTrainer(PBS_Trainers currentTrainer, StreamWriter writetext)
        {
            string header = $"[{currentTrainer.TrainerType},{currentTrainer.Name}";
            if (currentTrainer.ID > 0)
            {
                header = $"{header},{currentTrainer.ID}]";
            }
            else
            {
                header = $"{header}]";
            }
            writetext.WriteLine(header);
            string temp = "Items = ";
            if (currentTrainer.Items.Length > 0)
            {
                for (int i = 0; i < currentTrainer.Items.Length; i++)
                {
                    temp = $"{temp}{currentTrainer.Items[i]}";
                    if (i < currentTrainer.Items.Length - 1)
                    {
                        temp = $"{ temp },";
                    }
                }
                writetext.WriteLine(temp);
            }
            if (currentTrainer.LoseText != null)
            {
                writetext.WriteLine($"LoseText = {currentTrainer.LoseText}");
            }
            for (int i = 0; i < currentTrainer.Battlers.Length; i++)
            {
                Battlers thisBattler = currentTrainer.Battlers[i];
                writetext.WriteLine($"Pokemon = {thisBattler.Species},{thisBattler.Level}");
                if (thisBattler.Nickname != null)
                {
                    writetext.WriteLine($"    Name = {thisBattler.Nickname}");
                }
                if (thisBattler.Form > 0)
                {
                    writetext.WriteLine($"    Form = {thisBattler.Form}");
                }
                if (thisBattler.Gender != null)
                {
                    writetext.WriteLine($"    Gender = {thisBattler.Gender}");
                }
                if (thisBattler.Shiny == "yes")
                {
                    writetext.WriteLine($"    Shiny = {thisBattler.Shiny}");
                }
                if (thisBattler.SuperShiny == "yes")
                {
                    writetext.WriteLine($"    SuperShiny = {thisBattler.SuperShiny}");
                }
                if (thisBattler.Shadow == "yes")
                {
                    writetext.WriteLine($"    Shadow = {thisBattler.Shadow}");
                }
                if (thisBattler.Moves.Length > 0)
                {
                    temp = "    Moves = ";
                    for (int j = 0; j < thisBattler.Moves.Length; j++)
                    {
                        temp = $"{temp}{thisBattler.Moves[j]}";
                        if (j < thisBattler.Moves.Length - 1)
                        {
                            temp = $"{temp},";
                        }
                    }
                    writetext.WriteLine(temp);
                }
                if (thisBattler.Ability != null)
                {
                    writetext.WriteLine($"    Ability = {thisBattler.Ability}");
                }
                if (thisBattler.AbilityIndex != -1)
                {
                    writetext.WriteLine($"    AbilityIndex = {thisBattler.AbilityIndex}");
                }
                if (thisBattler.Item != null)
                {
                    writetext.WriteLine($"    Item = {thisBattler.Item}");
                }
                if (thisBattler.Nature != null)
                {
                    writetext.WriteLine($"    Nature = {thisBattler.Nature}");
                }
                if (thisBattler.IVS.Length > 0)
                {
                    string ivline = $"{thisBattler.IVS[0]}";
                    for (int iv = 1; iv < 6; iv++)
                    {
                        string fillerIV = thisBattler.IVS[0].ToString();
                        if (thisBattler.IVS.Length > iv)
                        {
                            fillerIV = thisBattler.IVS[iv].ToString();
                        }
                        ivline = $"{ivline},{fillerIV}";
                    }
                    writetext.WriteLine($"    IV = {ivline}");
                }
                if (thisBattler.EVS.Length > 0)
                {
                    string evline = $"{thisBattler.EVS[0]}";
                    for (int ev = 1; ev < 6; ev++)
                    {
                        string fillerEV = thisBattler.EVS[0].ToString();
                        if (thisBattler.EVS.Length > ev)
                        {
                            fillerEV = thisBattler.EVS[ev].ToString();
                        }
                        evline = $"{evline},{fillerEV}";
                    }
                    writetext.WriteLine($"    EV = {evline}");
                }
                if (thisBattler.Happiness != -1)
                {
                    writetext.WriteLine($"    Happiness = {thisBattler.Happiness}");
                }
                if (thisBattler.BallType != null)
                {
                    writetext.WriteLine($"    Ball = {thisBattler.BallType}");
                }
                if (thisBattler.Mechanic1 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic1"]} = {thisBattler.Mechanic1}");
                }
                if (thisBattler.Mechanic2 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic2"]} = {thisBattler.Mechanic2}");
                }
                if (thisBattler.Mechanic3 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic3"]} = {thisBattler.Mechanic3}");
                }
                if (thisBattler.Mechanic4 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic4"]} = {thisBattler.Mechanic4}");
                }
                if (thisBattler.Mechanic5 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic5"]} = {thisBattler.Mechanic5}");
                }
                if (thisBattler.Mechanic6 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic6"]} = {thisBattler.Mechanic6}");
                }
                if (thisBattler.Mechanic7 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic7"]} = {thisBattler.Mechanic7}");
                }
                if (thisBattler.Mechanic8 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic8"]} = {thisBattler.Mechanic8}");
                }
                if (thisBattler.Mechanic9 != "")
                {
                    writetext.WriteLine($"    {Global.BattlerCustomMechanics["Mechanic9"]} = {thisBattler.Mechanic9}");
                }
            }
        }

        private void OpenTrainer_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Trainer.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\trainers.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_Trainers> tempDic = new();
            bool errorfound = false;
            foreach (PBS_Trainers trainer in thisList)
            {
                if (tempDic.ContainsKey(trainer.Identification))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(trainer.Identification))
                {
                    tempDic.Add(trainer.Identification, trainer);
                }
            }
            if (!errorfound)
            {
                Global.Trainers_Dictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_Trainers_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close Trainers",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
