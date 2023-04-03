using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_Encounters : Form
    {
        readonly BindingSource MapListBS = new();
        readonly BindingSource EncTypeListBS = new();
        readonly BindingSource PokemonListBS = new();
        PBS_Encounters thisEncounter = new();
        EncounterSets thisEncounterSet = new();
        Encounters thisPokemon = new();
        List<PBS_Encounters> thisList = Global.Encounters_Dictionary.Values.ToList();
        public Form_Encounters()
        {
            InitializeComponent();
            MapListBS.DataSource = thisList;
            Map_ListBox.DataSource = MapListBS;
            Map_ListBox.DisplayMember = "Identification";
            EncounterType_ComboBox.DataSource = Global.ConfigEncounterDictionary.Keys.ToList();
            Pokemon_ComboBox.DataSource = Global.PokemonsDictionary.Keys.ToList();
            if (thisList.Count > 0)
            {
                Map_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Map_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Map_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }

        private void UpdateMainList()
        {
            thisEncounter = (PBS_Encounters)this.Map_ListBox.SelectedItem;
            MapNumber_Numeric.Value = thisEncounter.MapNumber;
            MapName_TextBox.Text = thisEncounter.MapName;
            MapID_Numeric.Value = thisEncounter.MapID;
            UpdateEncounterTypes();
        }

        private void UpdateEncounterTypes()
        {
            EncTypeListBS.DataSource = thisEncounter.Encounters;
            EncTypes_ListBox.DataSource = EncTypeListBS;
            EncTypes_ListBox.DisplayMember = "Identification";
            UpdateEncounterMethod();
        }

        private void UpdateEncounterMethod()
        {
            if (thisEncounter.Encounters.Length > 0)
            {
                thisEncounterSet = (EncounterSets)this.EncTypes_ListBox.SelectedItem;
                Density_Numeric.Value = thisEncounterSet.Density;
                UpdateEncounteredPokemons();
                UpdatePokemon();
            }
            if (thisEncounter.Encounters.Length == 0)
            {
                Encounters_ListBox.DataSource = null;
            }

        }
        private void UpdateEncounteredPokemons()
        {
            if (thisEncounterSet.EncounterPokemons.Length > 0)
            {
                PokemonListBS.DataSource = thisEncounterSet.EncounterPokemons;
                Encounters_ListBox.DataSource = PokemonListBS;
                Encounters_ListBox.DisplayMember = "Identification";
                UpdateValidChancesLabel();
                return;
            }
            PokemonListBS.DataSource = null;
        }
        private void UpdatePokemon()
        {
            if (thisEncounterSet.EncounterPokemons.Length > 0)
            {
                thisPokemon = (Encounters)this.Encounters_ListBox.SelectedItem;
                Pokemon_ComboBox.Text = thisPokemon.EncounterSpecies;
                MinLv_Numeric.Value = thisPokemon.EncounterMinLevel;
                MaxLv_Numeric.Value = thisPokemon.EncounterMaxLevel;
                Form_Numeric.Value = thisPokemon.EncounterForm;
                EncounterChance_Numeric.Value = thisPokemon.EncounterChance;
            }
        }
        private void UpdateValidChancesLabel()
        {
            int chancesSum = 0;
            foreach (var pokemon in thisEncounterSet.EncounterPokemons)
            {
                chancesSum += pokemon.EncounterChance;
            }
            if (chancesSum == 100)
            {
                ValidInvalidLabel.Text = "Valid";
                return;
            }
            ValidInvalidLabel.Text = $"Invalid: {chancesSum}%";
        }

        private void EncTypes_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EncTypes_ListBox.Focused == true)
            {
                UpdateEncounterMethod();
                UpdateValidChancesLabel();
            }
        }

        private void Encounters_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Encounters_ListBox.Focused == true)
            {
                UpdatePokemon();
            }
        }

        private void MapNumber_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisEncounter.MapNumber = Convert.ToInt32(MapNumber_Numeric.Value);
            MapListBS.ResetBindings(false);
        }

        private void MapName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisEncounter.MapName = MapName_TextBox.Text;
            MapListBS.ResetBindings(false);
        }

        private void MapID_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisEncounter.MapID = Convert.ToInt32(MapID_Numeric.Value);
            MapListBS.ResetBindings(false);
        }

        private void AddMap_Button_Click(object sender, EventArgs e)
        {
            PBS_Encounters newEncounter = new();
            thisList.Add(newEncounter);
            MapListBS.ResetBindings(false);
            Map_ListBox.SelectedIndex = Map_ListBox.Items.Count - 1;
            UpdateMainList();
        }

        private void DelMap_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Encounter?", "Delete Encounter", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(Map_ListBox.SelectedIndex);
                MapListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void AddEncType_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < thisEncounter.Encounters.Length; i++)
            {
                if (thisEncounter.Encounters[i].EncounterMethod == EncounterType_ComboBox.Text)
                {
                    return;
                }
            }
            List<EncounterSets> tempList = thisEncounter.Encounters.ToList();
            EncounterSets newEncounterSet = new();
            newEncounterSet.EncounterMethod = EncounterType_ComboBox.Text;
            newEncounterSet.Density = Global.ConfigEncounterDictionary[newEncounterSet.EncounterMethod];
            Encounters newPoke = new();
            newPoke.EncounterChance = 100;
            newPoke.EncounterMinLevel = 1;
            newPoke.EncounterMaxLevel = 1;
            newPoke.EncounterSpecies = "CHARMANDER";
            List<Encounters> newListOfPokes = new();
            newListOfPokes.Add(newPoke);
            newEncounterSet.EncounterPokemons = newListOfPokes.ToArray();
            tempList.Add(newEncounterSet);
            thisEncounter.Encounters = tempList.ToArray();
            UpdateEncounterTypes();
        }

        private void DeleteEncType_Button_Click(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            List<EncounterSets> tempList = thisEncounter.Encounters.ToList();
            tempList.RemoveAt(EncTypes_ListBox.SelectedIndex);
            thisEncounter.Encounters = tempList.ToArray();
            UpdateEncounterTypes();
        }

        private void Density_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            thisEncounterSet.Density = Convert.ToInt32(Density_Numeric.Value);
            EncTypeListBS.ResetBindings(false);
        }

        private void Pokemon_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            thisPokemon.EncounterSpecies = Pokemon_ComboBox.Text;
            PokemonListBS.ResetBindings(false);
        }

        private void Form_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            thisPokemon.EncounterForm = Convert.ToInt32(Form_Numeric.Value);
            if (thisPokemon.EncounterForm > Global.PokemonsDictionary[thisPokemon.EncounterSpecies].Forms)
            {
                thisPokemon.EncounterForm = Global.PokemonsDictionary[thisPokemon.EncounterSpecies].Forms;
            }
            PokemonListBS.ResetBindings(false);
        }

        private void MinLv_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            if (minLvlCheckBox.Checked == true)
            {
                foreach (var poke in thisEncounterSet.EncounterPokemons)
                {
                    UpdatePokemonMinLevel(poke);
                }
                return;
            }
            UpdatePokemonMinLevel(thisPokemon);
        }

        private void UpdatePokemonMinLevel(Encounters thisPoke)
        {
            thisPoke.EncounterMinLevel = Convert.ToInt32(MinLv_Numeric.Value);
            if (thisPoke.EncounterMaxLevel < thisPoke.EncounterMinLevel)
            {
                thisPoke.EncounterMaxLevel = thisPoke.EncounterMinLevel;
            }
            PokemonListBS.ResetBindings(false);
        }

        private void MaxLv_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            if (MaxLvlCheckBox.Checked == true)
            {
                foreach (var poke in thisEncounterSet.EncounterPokemons)
                {
                    UpdatePokemonMaxLevel(poke);
                }
                return;
            }
            if (Convert.ToInt32(MaxLv_Numeric.Value) < thisPokemon.EncounterMinLevel)
            {
                return;
            }
            UpdatePokemonMaxLevel(thisPokemon);
        }

        private void UpdatePokemonMaxLevel(Encounters thisPoke)
        {
            if (thisPoke.EncounterMinLevel > Convert.ToInt32(MaxLv_Numeric.Value))
            {
                return;
            }
            thisPoke.EncounterMaxLevel = Convert.ToInt32(MaxLv_Numeric.Value);
            PokemonListBS.ResetBindings(false);
        }

        private void EncounterChance_Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            thisPokemon.EncounterChance = Convert.ToInt32(EncounterChance_Numeric.Value);
            PokemonListBS.ResetBindings(false);
            UpdateValidChancesLabel();
        }

        private void AddPokemon_Button_Click(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            List<Encounters> tempList = thisEncounterSet.EncounterPokemons.ToList();
            Encounters newEnc = new();
            tempList.Add(newEnc);
            thisEncounterSet.EncounterPokemons = tempList.ToArray();
            UpdateEncounteredPokemons();
            UpdatePokemon();
        }

        private void DelPokemon_Button_Click(object sender, EventArgs e)
        {
            if (thisEncounter.Encounters.Length == 0)
            {
                return;
            }
            if (thisEncounterSet.EncounterPokemons.Length == 0)
            {
                return;
            }
            List<Encounters> tempList = thisEncounterSet.EncounterPokemons.ToList();
            tempList.RemoveAt(Encounters_ListBox.SelectedIndex);
            thisEncounterSet.EncounterPokemons = tempList.ToArray();
            UpdateEncounteredPokemons();
        }

        private void GenerateEncounter_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Encounter.txt";
            using StreamWriter writetext = new(filepath);
            GenerateEncounter(thisEncounter, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\encounters.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_Encounters encounter in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateEncounter(encounter, writetext);
            }
            writetext.Close();
        }
        private static void GenerateEncounter(PBS_Encounters currentEncounter, StreamWriter writetext)
        {
            string Header = $"[{currentEncounter.MapNumber:D3}] # {currentEncounter.MapName}";
            if (currentEncounter.MapID > 0)
            {
                Header = $"[{currentEncounter.MapNumber:D3},{currentEncounter.MapID}]" +
                    $" # {currentEncounter.MapName}";
            }
            writetext.WriteLine($"{Header}");
            foreach (EncounterSets encounterset in currentEncounter.Encounters)
            {
                string MethodHeader = $"{ encounterset.EncounterMethod },{encounterset.Density}";
                if (encounterset.Density == 0)
                {
                    MethodHeader = $"{encounterset.EncounterMethod}";
                }
                writetext.WriteLine($"{MethodHeader}");
                foreach (Encounters poke in encounterset.EncounterPokemons)
                {
                    string PokemonName = poke.EncounterSpecies;
                    if (poke.EncounterForm > 0)
                    {
                        PokemonName = $"{poke.EncounterSpecies}_{poke.EncounterForm}";
                    }
                    string levels = $"{poke.EncounterMinLevel}";
                    if (poke.EncounterMaxLevel != poke.EncounterMinLevel)
                    {
                        levels = $"{poke.EncounterMinLevel},{poke.EncounterMaxLevel}";
                    }
                    string PokemonHeader = $"{poke.EncounterChance},{PokemonName},{levels}";
                    writetext.WriteLine($"    {PokemonHeader}");
                }
            }
        }

        private void OpenEncounter_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Encounter.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\encounters.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_Encounters> tempDic = new();
            bool errorfound = false;
            foreach (PBS_Encounters encounter in thisList)
            {
                if (tempDic.ContainsKey(encounter.Identification))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(encounter.Identification))
                {
                    tempDic.Add(encounter.Identification, encounter);
                }
            }
            if (!errorfound)
            {
                Global.Encounters_Dictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void SortMap_Menu_Click(object sender, EventArgs e)
        {
            if (thisList.Count < 2)
            {
                return;
            }
            thisList = SortByMap(thisList);
            MapListBS.ResetBindings(false);
            Map_ListBox.SelectedIndex = 0;
            UpdateMainList();
        }
        private static List<PBS_Encounters> SortByMap(List<PBS_Encounters> SortingList)
        {
            bool doublecheck = false;
            for (int i = 0; i < SortingList.Count - 1; i++)
            {
                if (SortingList[i].SortingNumber > SortingList[i + 1].SortingNumber)
                {
                    doublecheck = true;
                    PBS_Encounters tempEnc = SortingList[i + 1];
                    SortingList[i + 1] = SortingList[i];
                    SortingList[i] = tempEnc;
                }
            }
            if (doublecheck)
            {
                SortByMap(SortingList);
            }
            return SortingList;
        }

        private void Form_Encounters_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close Encounters",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
