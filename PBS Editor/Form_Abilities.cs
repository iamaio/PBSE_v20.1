using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_Abilities : Form
    {
        readonly BindingSource AbilitiesListBS = new();
        PBS_Abilities thisAbility = new();
        readonly List<PBS_Abilities> thisList = Global.AbilitiesDictionary.Values.ToList();
        public Form_Abilities()
        {
            InitializeComponent();
            AbilitiesListBS.DataSource = thisList;
            listBox_Abilities.DataSource = AbilitiesListBS;
            listBox_Abilities.DisplayMember = "ID";
            AbilitiesListBS.ResetBindings(false);
            if (thisList.Count > 0)
            {
                listBox_Abilities.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Abilities_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Abilities.Focused == true)
            {
                UpdateMainList();
            }
        }

        private void UpdateMainList()
        {
            thisAbility = (PBS_Abilities)this.listBox_Abilities.SelectedItem;
            textBox_InternalName.Text = thisAbility.ID;
            textBox_Name.Text = thisAbility.Name;
            textBox_Description.Text = thisAbility.Description;
            string temp = "";
            for (int i = 0; i < thisAbility.Flags.Length; i++)
            {
                temp = $"{temp}{thisAbility.Flags[i]}";
                if (i < thisAbility.Flags.Length - 1)
                {
                    temp = $"{temp},";
                }
            }
            textBox_Flags.Text = temp;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            PBS_Abilities newAbi = new();
            newAbi.ID = "New Ability";
            thisList.Add(newAbi);
            AbilitiesListBS.ResetBindings(false);
            listBox_Abilities.SelectedIndex = listBox_Abilities.Items.Count-1;
            UpdateMainList();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Ability?", "Delete Ability", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(listBox_Abilities.SelectedIndex);
                AbilitiesListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void InternalName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisAbility.ID = textBox_InternalName.Text;
            AbilitiesListBS.ResetBindings(false);
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisAbility.Name = textBox_Name.Text;
        }

        private void TextBox_Flags_TextChanged(object sender, EventArgs e)
        {
            thisAbility.Flags = textBox_Flags.Text.Split(',');
        }

        private void Description_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisAbility.Description = textBox_Description.Text;
        }

        private void GenerateAbility_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Ability.txt";
            using StreamWriter writetext = new(filepath);
            GenerateAbility(thisAbility, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\abilities.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_Abilities ability in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateAbility(ability, writetext);
            }
            writetext.Close();
        }
        private static void GenerateAbility(PBS_Abilities currentAbility, StreamWriter writetext)
        {
            writetext.WriteLine($"[{currentAbility.ID}]");
            writetext.WriteLine($"Name = {currentAbility.Name}");
            if (currentAbility.Flags.Length > 0)
            {
                string temp = "Flags = ";
                for (int i = 0; i < currentAbility.Flags.Length; i++)
                {
                    temp = $"{temp}{currentAbility.Flags[i]}";
                    if (i < currentAbility.Flags.Length - 1)
                    {
                        temp = $"{temp},";
                    }
                }
                writetext.WriteLine(temp);
            }
            writetext.WriteLine($"Description = {currentAbility.Description}");
        }

        private void OpenAbility_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Ability.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\abilities.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_Abilities> tempDic = new();
            bool errorfound = false;
            foreach (PBS_Abilities ability in thisList)
            {
                if (tempDic.ContainsKey(ability.ID))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(ability.ID))
                {
                    tempDic.Add(ability.ID, ability);
                }
            }
            if (!errorfound)
            {
                Global.AbilitiesDictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_Abilities_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close Abilities",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
