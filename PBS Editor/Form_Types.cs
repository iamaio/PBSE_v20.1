using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_Types : Form
    {
        readonly BindingSource TypesListBS = new();
        readonly BindingSource WeaknessesListBS = new();
        readonly BindingSource ResistancesListBS = new();
        readonly BindingSource ImmunitiesListBS = new();
        readonly BindingSource TypesComboBoxBS = new();
        PBS_Types thisType = new();
        readonly List<PBS_Types> thisList = Global.TypesDictionary.Values.ToList();
        public Form_Types()
        {
            InitializeComponent();
            TypesListBS.DataSource = thisList;
            Types_ListBox.DataSource = TypesListBS;
            Types_ListBox.DisplayMember = "ID";
            TypesComboBoxBS.DataSource = thisList;
            TypesComboBox.DataSource = TypesComboBoxBS;
            TypesComboBox.DisplayMember = "ID";
            if (thisList.Count > 0)
            {
                Types_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Types_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Types_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }
        private void UpdateMainList()
        {
            thisType = (PBS_Types)this.Types_ListBox.SelectedItem;
            ID_Numeric.Value = thisType.IconPosition;
            InternalName_TextBox.Text = thisType.ID;
            Name_TextBox.Text = thisType.Name;
            Pseudo_CheckBox.Checked = (thisType.IsPseudoType == "true");
            Special_CheckBox.Checked = (thisType.IsSpecialType == "true");
            UpdateWeaknessList();
            UpdateResistancesList();
            UpdateImmunitiesList();
        }

        private void ID_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisType.IconPosition = Convert.ToInt32(ID_Numeric.Value);
            TypesListBS.ResetBindings(false);
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisType.Name = Name_TextBox.Text;
        }

        private void InternalName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisType.ID = InternalName_TextBox.Text;
            TypesListBS.ResetBindings(false);
        }

        private void Special_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Special_CheckBox.Checked == true)
            {
                thisType.IsSpecialType = "true";
                return;
            }
            thisType.IsSpecialType = null;
        }

        private void Pseudo_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Pseudo_CheckBox.Checked == true)
            {
                thisType.IsPseudoType = "true";
                return;
            }
            thisType.IsPseudoType = null;
        }

        private void UpdateWeaknessList()
        {
            WeaknessesListBS.DataSource = thisType.Weaknesses;
            Weaknesses_LisBox.DataSource = WeaknessesListBS;
        }

        private void UpdateResistancesList()
        {
            ResistancesListBS.DataSource = thisType.Resistances;
            Resistances_ListBox.DataSource = ResistancesListBS;
        }

        private void UpdateImmunitiesList()
        {
            ImmunitiesListBS.DataSource = thisType.Immunities;
            Immunities_ListBox.DataSource = ImmunitiesListBS;
        }

        private void AddWeakness_Button_Click(object sender, EventArgs e)
        {
            if (thisType.Weaknesses.Contains(TypesComboBox.Text))
            {
                return;
            }
            List<string> tempList = thisType.Weaknesses.ToList();
            tempList.Add(TypesComboBox.Text);
            thisType.Weaknesses = tempList.ToArray();
            UpdateWeaknessList();
        }

        private void DelWeakness_Button_Click(object sender, EventArgs e)
        {
            if (thisType.Weaknesses.Length == 0)
            {
                return;
            }
            List<string> tempList = thisType.Weaknesses.ToList();
            tempList.RemoveAt(Weaknesses_LisBox.SelectedIndex);
            thisType.Weaknesses = tempList.ToArray();
            UpdateWeaknessList();
        }

        private void AddResistance_Button_Click(object sender, EventArgs e)
        {
            if (thisType.Resistances.Contains(TypesComboBox.Text))
            {
                return;
            }
            List<string> tempList = thisType.Resistances.ToList();
            tempList.Add(TypesComboBox.Text);
            thisType.Resistances = tempList.ToArray();
            UpdateResistancesList();
        }

        private void DelResistance_Button_Click(object sender, EventArgs e)
        {
            if (thisType.Resistances.Length == 0)
            {
                return;
            }
            List<string> tempList = thisType.Resistances.ToList();
            tempList.RemoveAt(Resistances_ListBox.SelectedIndex);
            thisType.Resistances = tempList.ToArray();
            UpdateResistancesList();
        }

        private void AddImmunities_Button_Click(object sender, EventArgs e)
        {
            if (thisType.Immunities.Contains(TypesComboBox.Text))
            {
                return;
            }
            List<string> tempList = thisType.Immunities.ToList();
            tempList.Add(TypesComboBox.Text);
            thisType.Immunities = tempList.ToArray();
            UpdateImmunitiesList();
        }

        private void DelImmunities_Button_Click(object sender, EventArgs e)
        {
            if (thisType.Immunities.Length == 0)
            {
                return;
            }
            List<string> tempList = thisType.Immunities.ToList();
            tempList.RemoveAt(Immunities_ListBox.SelectedIndex);
            thisType.Immunities = tempList.ToArray();
            UpdateImmunitiesList();
        }

        private void TypeAdd_Button_Click(object sender, EventArgs e)
        {
            PBS_Types newType = new();
            newType.ID = "New Type";
            thisList.Add(newType);
            TypesListBS.ResetBindings(false);
            Types_ListBox.SelectedIndex = Types_ListBox.Items.Count - 1;
            UpdateMainList();
        }

        private void TypeDel_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Type?", "Delete Type", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(Types_ListBox.SelectedIndex);
                TypesListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void GenerateType_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Type.txt";
            using StreamWriter writetext = new(filepath);
            GenerateType(thisType, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\types.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_Types type in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateType(type, writetext);
            }
            writetext.Close();
        }
        private static void GenerateType(PBS_Types currentType, StreamWriter writetext)
        {
            writetext.WriteLine($"[{currentType.ID}]");
            writetext.WriteLine($"Name = {currentType.Name}");
            writetext.WriteLine($"IconPosition = {currentType.IconPosition}");
            if (currentType.IsSpecialType == "true")
            {
                writetext.WriteLine($"IsSpecialType = true");
            }
            if (currentType.IsPseudoType == "true")
            {
                writetext.WriteLine($"IsPseudoType = true");
            }
            if (currentType.Weaknesses.Length > 0)
            {
                string weak = "Weaknesses = ";
                for (int i = 0; i < currentType.Weaknesses.Length; i++)
                {
                    weak = $"{weak}{currentType.Weaknesses[i]}";
                    if (i < currentType.Weaknesses.Length - 1)
                    {
                        weak = $"{weak},";
                    }
                }
                writetext.WriteLine(weak);
            }
            if (currentType.Resistances.Length > 0)
            {
                string res = "Resistances = ";
                for (int i = 0; i < currentType.Resistances.Length; i++)
                {
                    res = $"{res}{currentType.Resistances[i]}";
                    if (i < currentType.Resistances.Length - 1)
                    {
                        res = $"{res},";
                    }
                }
                writetext.WriteLine(res);
            }
            if (currentType.Immunities.Length > 0)
            {
                string imu = "Immunities = ";
                for (int i = 0; i < currentType.Immunities.Length; i++)
                {
                    imu = $"{ imu }{ currentType.Immunities[i]}";
                    if (i < currentType.Immunities.Length - 1)
                    {
                        imu = $"{imu},";
                    }
                }
                writetext.WriteLine(imu);
            }
        }

        private void OpenType_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Type.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\types.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_Types> tempDic = new();
            bool errorfound = false;
            foreach (PBS_Types type in thisList)
            {
                if (tempDic.ContainsKey(type.ID))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(type.ID))
                {
                    tempDic.Add(type.ID, type);
                }
            }
            if (!errorfound)
            {
                Global.TypesDictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_Types_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close Types",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
