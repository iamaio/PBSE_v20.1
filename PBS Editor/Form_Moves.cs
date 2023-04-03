using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_Moves : Form
    {
        readonly BindingSource MovesListBS = new();
        readonly BindingSource FlagListBS = new();
        PBS_Moves thisMove = new();
        readonly List<PBS_Moves> thisList = Global.MovesDictionary.Values.ToList();
        public Form_Moves()
        {
            InitializeComponent();
            MovesListBS.DataSource = thisList;
            Moves_ListBox.DataSource = MovesListBS;
            Moves_ListBox.DisplayMember = "ID";
            Type_ComboBox.DataSource = Global.TypesDictionary.Keys.ToList();
            Target_ComboBox.DataSource = Global.TargetsArray;
            Priority_Numeric.Minimum = -10;
            FlagListBS.DataSource = Global.MoveFlagsArray.ToList();
            Flags_CheckedListBox.DataSource = FlagListBS;
            if (thisList.Count > 0)
            {
                Moves_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Moves_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Moves_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }

        private void UpdateMainList()
        {
            thisMove = (PBS_Moves)this.Moves_ListBox.SelectedItem;
            InternalName_TextBox.Text = thisMove.ID;
            Name_TextBox.Text = thisMove.Name;
            Code_TextBox.Text = thisMove.FunctionCode;
            Damage_Numeric.Value = thisMove.Power;
            Type_ComboBox.Text = thisMove.Type;
            Category_ComboBox.Text = thisMove.Category;
            Accuracy_Numeric.Value = thisMove.Accuracy;
            PP_Numeric.Value = thisMove.TotalPP;
            EffectChance_Numeric.Value = thisMove.EffectChance;
            Target_ComboBox.Text = thisMove.Target;
            Priority_Numeric.Value = thisMove.Priority;
            UpdateFlagListBox();
            Description_TextBox.Text = thisMove.Description;
        }

        private void UpdateFlagListBox()
        {
            for (int i = 0; i < Flags_CheckedListBox.Items.Count; i++)
            {
                bool state = false;
                string thisFlag = (string)Flags_CheckedListBox.Items[i];
                if (thisMove.Flags == null)
                {
                    continue;
                }
                if (thisMove.Flags.Contains(thisFlag))
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

        private void InternalName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisMove.ID = InternalName_TextBox.Text;
            MovesListBS.ResetBindings(false);
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisMove.Name = Name_TextBox.Text;
        }

        private void Code_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisMove.FunctionCode = Code_TextBox.Text;
        }

        private void Damage_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisMove.Power = Convert.ToInt32(Damage_Numeric.Value);
        }

        private void Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisMove.Type = Type_ComboBox.Text;
        }

        private void Category_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisMove.Category = Category_ComboBox.Text;
        }

        private void Accuracy_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisMove.Accuracy = Convert.ToInt32(Accuracy_Numeric.Value);
        }

        private void PP_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisMove.TotalPP = Convert.ToInt32(PP_Numeric.Value);
        }

        private void EffectChance_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisMove.EffectChance = Convert.ToInt32(EffectChance_Numeric.Value);
        }

        private void Target_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisMove.Target = Target_ComboBox.Text;
        }

        private void Priority_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisMove.Priority = Convert.ToInt32(Priority_Numeric.Value);
        }

        private void Description_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisMove.Description = Description_TextBox.Text;
        }

        private void UpdateFlag_Button_Click(object sender, EventArgs e)
        {
            List<string> tempList = new();
            for (int i = 0; i < Flags_CheckedListBox.CheckedItems.Count; i++)
            {
                string currFlag = (string)Flags_CheckedListBox.CheckedItems[i];
                tempList.Add(currFlag);
            }
            string [] flagarray = tempList.ToArray();
            string flags = "";
            for (int i = 0; i < flagarray.Length; i++)
            {
                flags = $"{flags}{flagarray[i]}";
                if (i < flagarray.Length - 1)
                {
                    flags= $"{flags},";
                }
            }
            thisMove.Flags = flags;
            UpdateFlagListBox();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            PBS_Moves newMove = new();
            newMove.ID = "New Move";
            thisList.Add(newMove);
            MovesListBS.ResetBindings(false);
            Moves_ListBox.SelectedIndex = Moves_ListBox.Items.Count - 1;
            UpdateMainList();
        }

        private void Del_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Move?", "Delete Move", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(Moves_ListBox.SelectedIndex);
                MovesListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void GenerateMove_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Move.txt";
            using StreamWriter writetext = new(filepath);
            GenerateMove(thisMove, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\moves.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_Moves move in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateMove(move, writetext);
            }
            writetext.Close();
        }
        private static void GenerateMove(PBS_Moves currentMove, StreamWriter writetext)
        {
            writetext.WriteLine($"[{currentMove.ID}]");
            writetext.WriteLine($"Name = {currentMove.Name}");
            writetext.WriteLine($"Type = {currentMove.Type}");
            writetext.WriteLine($"Category = {currentMove.Category}");
            if (currentMove.Power != 0)
            {
                writetext.WriteLine($"Power = {currentMove.Power}");
            }
            writetext.WriteLine($"Accuracy = {currentMove.Accuracy}");
            writetext.WriteLine($"TotalPP = {currentMove.TotalPP}");
            writetext.WriteLine($"Target = {currentMove.Target}");
            if (currentMove.Priority != 0)
            {
                writetext.WriteLine($"Priority = {currentMove.Priority}");
            }
            writetext.WriteLine($"FunctionCode = {currentMove.FunctionCode}");
            if (currentMove.Flags != "")
            {
                writetext.WriteLine($"Flags = {currentMove.Flags}");
            }
            if (currentMove.EffectChance != 0)
            {
                writetext.WriteLine($"EffectChance = {currentMove.EffectChance}");
            }
            writetext.WriteLine($"Description = {currentMove.Description}");
            
        }

        private void OpenMove_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Move.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\moves.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_Moves> tempDic = new();
            bool errorfound = false;
            foreach (PBS_Moves move in thisList)
            {
                if (tempDic.ContainsKey(move.ID))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(move.ID))
                {
                    tempDic.Add(move.ID, move);
                }
            }
            if (!errorfound)
            {
                Global.MovesDictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_Moves_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close Moves",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }

        private void Flags_CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
