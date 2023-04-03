using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_Items : Form
    {
        readonly BindingSource ItemsListBS = new();
        readonly BindingSource FlagListBS = new();
        PBS_Items thisItem = new();
        readonly List<PBS_Items> thisList = Global.ItemsDictionary.Values.ToList();
        public Form_Items()
        {
            InitializeComponent();
            ItemsListBS.DataSource = thisList;
            Items_ListBox.DataSource = ItemsListBS;
            Items_ListBox.DisplayMember = "ID";
            Pocket_ComboBox.DataSource = Global.PocketsDictionary.Values.ToList();
            UsabilityOut_ComboBox.DataSource = Global.FieldUseArray.ToList();
            UsabilityIn_ComboBox.DataSource = Global.BattleUseArray.ToList();
            TM_ComboBox.DataSource = Global.MovesDictionary.Keys.ToList();
            FlagListBS.DataSource = Global.ItemFlags.ToList();
            Flags_CheckedListBox.DataSource = FlagListBS;
            if (thisList.Count > 0)
            {
                Items_ListBox.SelectedIndex = 0;
                UpdateMainList();
            }
        }

        private void Items_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Items_ListBox.Focused == true)
            {
                UpdateMainList();
            }
        }

        private void UpdateMainList()
        {
            thisItem = (PBS_Items)this.Items_ListBox.SelectedItem;
            InternalName_TextBox.Text = thisItem.ID;
            Name_TextBox.Text = thisItem.Name;
            PluralName_TextBox.Text = thisItem.NamePlural;
            Pocket_ComboBox.Text = Global.PocketsDictionary[thisItem.Pocket];
            Price_Numeric.Value = thisItem.Price;
            UsabilityOut_ComboBox.Text = thisItem.FieldUse;
            UsabilityIn_ComboBox.Text = thisItem.BattleUse;
            LoadTM();
            Description_TextBox.Text = thisItem.Description;
            textBox_Consumable.Text = thisItem.Consumable;
            ID_Numeric.Value = thisItem.SellPrice;
            UpdateFlagListBox();
        }

        private void UpdateFlagListBox()
        {
            for (int i = 0; i < Flags_CheckedListBox.Items.Count; i++)
            {
                bool state = false;
                string thisFlag = (string)Flags_CheckedListBox.Items[i];
                if (thisItem.Flags.Contains(thisFlag))
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

        private void LoadTM()
        {
            if (thisItem.Move == null || thisItem.Move == "")
            {
                TM_CheckBox.Checked = false;
                TM_ComboBox.Visible = false;
            }
            if (thisItem.Move != null && thisItem.Move != "")
            {
                TM_CheckBox.Checked = true;
                TM_ComboBox.Visible = true;
                TM_ComboBox.Text = thisItem.Move;
            }
        }

        private void InternalName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisItem.ID = InternalName_TextBox.Text;
            ItemsListBS.ResetBindings(false);
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisItem.Name = Name_TextBox.Text;
        }

        private void PluralName_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisItem.NamePlural = PluralName_TextBox.Text;
        }

        private void Pocket_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisItem.Pocket = Global.PocketsDictionary.FirstOrDefault(x => x.Value == Pocket_ComboBox.Text).Key;
        }

        private void Price_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisItem.Price = Convert.ToInt32(Price_Numeric.Value);
        }

        private void UsabilityOut_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisItem.FieldUse = UsabilityOut_ComboBox.Text;
        }

        private void UsabilityIn_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thisItem.BattleUse = UsabilityIn_ComboBox.Text;
        }

        private void TM_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTMEvent();
        }

        private void TM_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TM_CheckBox.Focused == false)
            {
                return;
            }
            if (TM_CheckBox.Checked == false)
            {
                TM_ComboBox.Visible = false;
                thisItem.Move = null;
                return;
            }
            TM_ComboBox.Visible = true;
            UpdateTMEvent();
        }

        private void UpdateTMEvent()
        {
            thisItem.Move = TM_ComboBox.Text;
        }

        private void Description_TextBox_TextChanged(object sender, EventArgs e)
        {
            thisItem.Description = Description_TextBox.Text;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            PBS_Items newItem = new();
            newItem.ID = "New Item";
            thisList.Add(newItem);
            ItemsListBS.ResetBindings(false);
            Items_ListBox.SelectedIndex = Items_ListBox.Items.Count - 1;
            UpdateMainList();
            UpdateFlagListBox();
        }

        private void Del_Button_Click(object sender, EventArgs e)
        {
            if (thisList.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this Item?", "Delete Item", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                thisList.RemoveAt(Items_ListBox.SelectedIndex);
                ItemsListBS.ResetBindings(false);
                UpdateMainList();
            }
        }

        private void GenerateItem_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Item.txt";
            using StreamWriter writetext = new(filepath);
            GenerateItem(thisItem, writetext);
            writetext.Close();
        }

        private void GeneratePBS_Menu_Click(object sender, EventArgs e)
        {
            string filepath = $"{Global.ExecutableURL}\\PBSE\\Generated\\items.txt";
            using StreamWriter writetext = new(filepath);
            writetext.WriteLine($"# See the documentation on the wiki to learn how to edit this file.");
            foreach (PBS_Items item in thisList)
            {
                writetext.WriteLine($"#-------------------------------");
                GenerateItem(item, writetext);
            }
            writetext.Close();
        }
        private static void GenerateItem(PBS_Items currentItem, StreamWriter writetext)
        {
            writetext.WriteLine($"[{currentItem.ID}]");
            writetext.WriteLine($"Name = {currentItem.Name}");
            writetext.WriteLine($"NamePlural = {currentItem.NamePlural}");
            writetext.WriteLine($"Pocket = {currentItem.Pocket}");
            writetext.WriteLine($"Price = {currentItem.Price}");
            if (currentItem.SellPrice >= 0)
            {
                writetext.WriteLine($"SellPrice = {currentItem.SellPrice}");
            }
            if (currentItem.FieldUse != null && currentItem.FieldUse != "")
            {
                writetext.WriteLine($"FieldUse = {currentItem.FieldUse}");
            }
            if (currentItem.BattleUse != null && currentItem.BattleUse != "")
            {
                writetext.WriteLine($"BattleUse = {currentItem.BattleUse}");
            }
            if (currentItem.Consumable == "false")
            {
                writetext.WriteLine($"Consumable = {currentItem.Consumable}");
            }
            if (currentItem.Flags != null && currentItem.Flags != "")
            {
                writetext.WriteLine($"Flags = {currentItem.Flags}");
            }
            if (currentItem.Move != null)
            {
                writetext.WriteLine($"Move = {currentItem.Move}");
            }
            writetext.WriteLine($"Description = {currentItem.Description}");
            if (currentItem.HeldDescription != null)
            {
                writetext.WriteLine($"HeldDescription = {currentItem.HeldDescription}");
            }
        }

        private void OpenItem_Menu_Click(object sender, EventArgs e)
        {

            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\Gen_Item.txt");
        }

        private void OpenPBS_Menu_Click(object sender, EventArgs e)
        {
            Process.Start(Global.TextOpener, $"{Global.ExecutableURL}\\PBSE\\Generated\\items.txt");
        }

        private void CompileChanges_Menu_Click(object sender, EventArgs e)
        {
            Dictionary<string, PBS_Items> tempDic = new();
            bool errorfound = false;
            foreach (PBS_Items item in thisList)
            {
                if (tempDic.ContainsKey(item.ID))
                {
                    errorfound = true;
                }
                if (!tempDic.ContainsKey(item.ID))
                {
                    tempDic.Add(item.ID, item);
                }
            }
            if (!errorfound)
            {
                Global.ItemsDictionary = tempDic;
                return;
            }
            MessageBox.Show("Compilation wasn't possible. There's a repeated Internal Name.");
        }

        private void Form_Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                "Progress may be lost if you close this window, proceed?",
                "Close Items",
                MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }

        private void UsabilityIn_ComboBox_DropDown(object sender, EventArgs e)
        {
            Graphics g = UsabilityIn_ComboBox.CreateGraphics();
            float largestSize = 0;

            for (int i = 0; i < UsabilityIn_ComboBox.Items.Count; i++)
            {
                SizeF textSize = g.MeasureString(UsabilityIn_ComboBox.Items[i].ToString(), UsabilityIn_ComboBox.Font);
                if (textSize.Width > largestSize)
                {
                    largestSize = textSize.Width;
                }
            }

            if (largestSize > 0)
            {
                UsabilityIn_ComboBox.DropDownWidth = (int)largestSize;
            }
        }

        private void UsabilityOut_ComboBox_DropDown(object sender, EventArgs e)
        {
            Graphics g = UsabilityOut_ComboBox.CreateGraphics();
            float largestSize = 0;

            for (int i = 0; i < UsabilityOut_ComboBox.Items.Count; i++)
            {
                SizeF textSize = g.MeasureString(UsabilityOut_ComboBox.Items[i].ToString(), UsabilityOut_ComboBox.Font);
                if (textSize.Width > largestSize)
                {
                    largestSize = textSize.Width;
                }
            }
            if (largestSize > 0)
            {
                UsabilityOut_ComboBox.DropDownWidth = (int)largestSize;
            }
        }

        private void TextBox_Consumable_TextChanged(object sender, EventArgs e)
        {
            thisItem.Consumable = textBox_Consumable.Text;
        }

        private void ID_Numeric_ValueChanged(object sender, EventArgs e)
        {
            thisItem.SellPrice = (int)ID_Numeric.Value;
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
            thisItem.Flags = flags;
            UpdateFlagListBox();
        }
    }
}
