using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_TrainerTypes : Form
    {
        readonly BindingSource TrainerTypesListBS = new();
        PBS_TrainerTypes thisTrainerType = new();
        readonly List<PBS_TrainerTypes> thisList = Global.TrainerTypesDictionary.Values.ToList();
        public Form_TrainerTypes()
        {
            InitializeComponent();
            TrainerTypesListBS.DataSource = thisList;
            TrainerType_ListBox.DataSource = TrainerTypesListBS;
            TrainerType_ListBox.DisplayMember = "ID";
            if (thisList.Count > 0)
            {
                TrainerType_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void TrainerType_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainerType_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }
        private void UpdateMainList()
        {
            thisTrainerType = (PBS_TrainerTypes)this.TrainerType_ListBox.SelectedItem;
            InternalName_TextBox.Text = thisTrainerType.ID;
            Name_TextBox.Text = thisTrainerType.Name;
            BaseMoney_Numeric.Value = thisTrainerType.BaseMoney;
            introBGM_TextBox.Text = thisTrainerType.IntroBGM;
            BattleBGM_TextBox.Text = thisTrainerType.BattleBGM;
            VictoryBGM_TextBox.Text = thisTrainerType.VictoryBGM;
            Gender_ComboBox.Text = thisTrainerType.Gender;
            Skill_Numeric.Value = thisTrainerType.SkillLevel;
            SkillCode_TextBox.Text = thisTrainerType.Flags;
        }

        private void InternalName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainerType.ID = InternalName_TextBox.Text;
            TrainerTypesListBS.ResetBindings(false);
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainerType.Name = Name_TextBox.Text;
        }

        private void BaseMoney_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisTrainerType.BaseMoney = Convert.ToInt32(BaseMoney_Numeric.Value);
        }

        private void BGM_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainerType.IntroBGM = introBGM_TextBox.Text;
        }

        private void VictoryME_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainerType.BattleBGM = BattleBGM_TextBox.Text;
        }

        private void IntroME_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainerType.VictoryBGM = VictoryBGM_TextBox.Text;
        }

        private void Gender_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisTrainerType.Gender = Gender_ComboBox.Text;
        }

        private void Skill_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisTrainerType.SkillLevel = Convert.ToInt32(Skill_Numeric.Value);
        }

        private void SkillCode_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisTrainerType.Flags = SkillCode_TextBox.Text;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            PBS_TrainerTypes newTrainerType = new();
            newTrainerType.ID = "New Trainer Type";
            thisList.Add(newTrainerType);
            TrainerTypesListBS.ResetBindings(false);
            TrainerType_ListBox.SelectedIndex = TrainerType_ListBox.Items.Count - 1;
            UpdateMainList();
        }

        private void Del_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this TrainerType?", "Delete TrainerType", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(TrainerType_ListBox.SelectedIndex);
                TrainerTypesListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void GenerateTrainerType_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_TrainerType.txt";
            using StreamWriter writetext = new(filepath);
            GenerateTrainerType(thisTrainerType, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\trainertypes.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_TrainerTypes trainertype in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateTrainerType(trainertype, writetext);
            }
            writetext.Close();
        }
        private static void GenerateTrainerType(PBS_TrainerTypes currentTrainerType, StreamWriter writetext)
        {
            writetext.WriteLine($"[{currentTrainerType.ID}]");
            writetext.WriteLine($"Name = {currentTrainerType.Name}");
            writetext.WriteLine($"Gender = {currentTrainerType.Gender}");
            writetext.WriteLine($"BaseMoney = {currentTrainerType.BaseMoney}");
            if (currentTrainerType.SkillLevel != currentTrainerType.BaseMoney)
            {
                writetext.WriteLine($"SkillLevel = {currentTrainerType.SkillLevel}");
            }
            if (currentTrainerType.Flags != null)
            {
                writetext.WriteLine($"Flags = {currentTrainerType.Flags.Trim()}");
            }
            if (currentTrainerType.IntroBGM != null)
            {
                writetext.WriteLine($"IntroBGM = {currentTrainerType.IntroBGM}");
            }
            if (currentTrainerType.BattleBGM != null)
            {
                writetext.WriteLine($"BattleBGM = {currentTrainerType.BattleBGM}");
            }
            if (currentTrainerType.VictoryBGM != null)
            {
                writetext.WriteLine($"VictoryBGM = {currentTrainerType.VictoryBGM}");
            }
        }

        private void OpenTType_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_TrainerType.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\trainertypes.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_TrainerTypes> tempDic = new();
            bool errorfound = false;
            foreach (PBS_TrainerTypes ttype in thisList)
            {
                if (tempDic.ContainsKey(ttype.ID))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(ttype.ID))
                {
                    tempDic.Add(ttype.ID, ttype);
                }
            }
            if (!errorfound)
            {
                Global.TrainerTypesDictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_TrainerTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close TrainerTypes",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
