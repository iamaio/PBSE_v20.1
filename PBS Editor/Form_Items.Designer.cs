
namespace PBS_Editor
{
    partial class Form_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem OpenItem_Menu;
            this.BaseMenu_Menu = new System.Windows.Forms.MenuStrip();
            this.Generate_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateItem_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Compile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileChanges_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.TM_CheckBox = new System.Windows.Forms.CheckBox();
            this.TM_ComboBox = new System.Windows.Forms.ComboBox();
            this.UsabilityIn_ComboBox = new System.Windows.Forms.ComboBox();
            this.UsabilityOut_ComboBox = new System.Windows.Forms.ComboBox();
            this.Price_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Pocket_ComboBox = new System.Windows.Forms.ComboBox();
            this.PluralName_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.InternalName_TextBox = new System.Windows.Forms.TextBox();
            this.ID_Numeric = new System.Windows.Forms.NumericUpDown();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TMLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UsabilityOutBattle = new System.Windows.Forms.Label();
            this.PocketLabel = new System.Windows.Forms.Label();
            this.UsabilityInBattleLabel = new System.Windows.Forms.Label();
            this.PluralNameLabel = new System.Windows.Forms.Label();
            this.InternalNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Del_Button = new System.Windows.Forms.Button();
            this.Items_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Consumable = new System.Windows.Forms.TextBox();
            this.UpdateFlag_Button = new System.Windows.Forms.Button();
            this.Flags_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FlagsLabel = new System.Windows.Forms.Label();
            OpenItem_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseMenu_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenItem_Menu
            // 
            OpenItem_Menu.Name = "OpenItem_Menu";
            OpenItem_Menu.Size = new System.Drawing.Size(187, 22);
            OpenItem_Menu.Text = "Open Generated Item";
            OpenItem_Menu.Click += new System.EventHandler(this.OpenItem_Menu_Click);
            // 
            // BaseMenu_Menu
            // 
            this.BaseMenu_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Generate_Menu,
            this.Open_Menu,
            this.Compile_Menu});
            this.BaseMenu_Menu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu_Menu.Name = "BaseMenu_Menu";
            this.BaseMenu_Menu.Size = new System.Drawing.Size(778, 24);
            this.BaseMenu_Menu.TabIndex = 0;
            this.BaseMenu_Menu.Text = "BaseMenu";
            // 
            // Generate_Menu
            // 
            this.Generate_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateItem_Menu,
            this.GeneratePBS_Menu});
            this.Generate_Menu.Name = "Generate_Menu";
            this.Generate_Menu.Size = new System.Drawing.Size(66, 20);
            this.Generate_Menu.Text = "Generate";
            // 
            // GenerateItem_Menu
            // 
            this.GenerateItem_Menu.Name = "GenerateItem_Menu";
            this.GenerateItem_Menu.Size = new System.Drawing.Size(191, 22);
            this.GenerateItem_Menu.Text = "Generate Current Item";
            this.GenerateItem_Menu.Click += new System.EventHandler(this.GenerateItem_Menu_Click);
            // 
            // GeneratePBS_Menu
            // 
            this.GeneratePBS_Menu.Name = "GeneratePBS_Menu";
            this.GeneratePBS_Menu.Size = new System.Drawing.Size(191, 22);
            this.GeneratePBS_Menu.Text = "Generate PBS File";
            this.GeneratePBS_Menu.Click += new System.EventHandler(this.GeneratePBS_Menu_Click);
            // 
            // Open_Menu
            // 
            this.Open_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            OpenItem_Menu,
            this.OpenPBS_Menu});
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(48, 20);
            this.Open_Menu.Text = "Open";
            // 
            // OpenPBS_Menu
            // 
            this.OpenPBS_Menu.Name = "OpenPBS_Menu";
            this.OpenPBS_Menu.Size = new System.Drawing.Size(187, 22);
            this.OpenPBS_Menu.Text = "Open Generated PBS";
            this.OpenPBS_Menu.Click += new System.EventHandler(this.OpenPBS_Menu_Click);
            // 
            // Compile_Menu
            // 
            this.Compile_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompileChanges_Menu});
            this.Compile_Menu.Name = "Compile_Menu";
            this.Compile_Menu.Size = new System.Drawing.Size(64, 20);
            this.Compile_Menu.Text = "Compile";
            // 
            // CompileChanges_Menu
            // 
            this.CompileChanges_Menu.Name = "CompileChanges_Menu";
            this.CompileChanges_Menu.Size = new System.Drawing.Size(168, 22);
            this.CompileChanges_Menu.Text = "Compile Changes";
            this.CompileChanges_Menu.Click += new System.EventHandler(this.CompileChanges_Menu_Click);
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.Location = new System.Drawing.Point(227, 338);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(304, 57);
            this.Description_TextBox.TabIndex = 15;
            this.Description_TextBox.TextChanged += new System.EventHandler(this.Description_TextBox_TextChanged);
            // 
            // TM_CheckBox
            // 
            this.TM_CheckBox.AutoSize = true;
            this.TM_CheckBox.Location = new System.Drawing.Point(269, 265);
            this.TM_CheckBox.Name = "TM_CheckBox";
            this.TM_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.TM_CheckBox.TabIndex = 12;
            this.TM_CheckBox.UseVisualStyleBackColor = true;
            this.TM_CheckBox.CheckedChanged += new System.EventHandler(this.TM_CheckBox_CheckedChanged);
            // 
            // TM_ComboBox
            // 
            this.TM_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TM_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TM_ComboBox.FormattingEnabled = true;
            this.TM_ComboBox.Location = new System.Drawing.Point(312, 261);
            this.TM_ComboBox.Name = "TM_ComboBox";
            this.TM_ComboBox.Size = new System.Drawing.Size(219, 23);
            this.TM_ComboBox.TabIndex = 13;
            this.TM_ComboBox.Visible = false;
            this.TM_ComboBox.SelectedIndexChanged += new System.EventHandler(this.TM_ComboBox_SelectedIndexChanged);
            // 
            // UsabilityIn_ComboBox
            // 
            this.UsabilityIn_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsabilityIn_ComboBox.DropDownWidth = 188;
            this.UsabilityIn_ComboBox.FormattingEnabled = true;
            this.UsabilityIn_ComboBox.Location = new System.Drawing.Point(312, 232);
            this.UsabilityIn_ComboBox.Name = "UsabilityIn_ComboBox";
            this.UsabilityIn_ComboBox.Size = new System.Drawing.Size(219, 23);
            this.UsabilityIn_ComboBox.TabIndex = 11;
            this.UsabilityIn_ComboBox.DropDown += new System.EventHandler(this.UsabilityIn_ComboBox_DropDown);
            this.UsabilityIn_ComboBox.SelectedIndexChanged += new System.EventHandler(this.UsabilityIn_ComboBox_SelectedIndexChanged);
            // 
            // UsabilityOut_ComboBox
            // 
            this.UsabilityOut_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsabilityOut_ComboBox.FormattingEnabled = true;
            this.UsabilityOut_ComboBox.Location = new System.Drawing.Point(312, 203);
            this.UsabilityOut_ComboBox.Name = "UsabilityOut_ComboBox";
            this.UsabilityOut_ComboBox.Size = new System.Drawing.Size(219, 23);
            this.UsabilityOut_ComboBox.TabIndex = 10;
            this.UsabilityOut_ComboBox.DropDown += new System.EventHandler(this.UsabilityOut_ComboBox_DropDown);
            this.UsabilityOut_ComboBox.SelectedIndexChanged += new System.EventHandler(this.UsabilityOut_ComboBox_SelectedIndexChanged);
            // 
            // Price_Numeric
            // 
            this.Price_Numeric.Location = new System.Drawing.Point(312, 145);
            this.Price_Numeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Price_Numeric.Name = "Price_Numeric";
            this.Price_Numeric.Size = new System.Drawing.Size(77, 23);
            this.Price_Numeric.TabIndex = 8;
            this.Price_Numeric.ValueChanged += new System.EventHandler(this.Price_Numeric_ValueChanged);
            // 
            // Pocket_ComboBox
            // 
            this.Pocket_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pocket_ComboBox.FormattingEnabled = true;
            this.Pocket_ComboBox.Location = new System.Drawing.Point(312, 116);
            this.Pocket_ComboBox.Name = "Pocket_ComboBox";
            this.Pocket_ComboBox.Size = new System.Drawing.Size(219, 23);
            this.Pocket_ComboBox.TabIndex = 7;
            this.Pocket_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Pocket_ComboBox_SelectedIndexChanged);
            // 
            // PluralName_TextBox
            // 
            this.PluralName_TextBox.Location = new System.Drawing.Point(312, 87);
            this.PluralName_TextBox.Name = "PluralName_TextBox";
            this.PluralName_TextBox.Size = new System.Drawing.Size(219, 23);
            this.PluralName_TextBox.TabIndex = 6;
            this.PluralName_TextBox.TextChanged += new System.EventHandler(this.PluralName_TextBox_TextChanged);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(312, 58);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(219, 23);
            this.Name_TextBox.TabIndex = 5;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // InternalName_TextBox
            // 
            this.InternalName_TextBox.Location = new System.Drawing.Point(312, 28);
            this.InternalName_TextBox.Name = "InternalName_TextBox";
            this.InternalName_TextBox.Size = new System.Drawing.Size(219, 23);
            this.InternalName_TextBox.TabIndex = 4;
            this.InternalName_TextBox.TextChanged += new System.EventHandler(this.InternalName_TextBox_TextChanged);
            // 
            // ID_Numeric
            // 
            this.ID_Numeric.Location = new System.Drawing.Point(312, 174);
            this.ID_Numeric.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ID_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ID_Numeric.Name = "ID_Numeric";
            this.ID_Numeric.Size = new System.Drawing.Size(77, 23);
            this.ID_Numeric.TabIndex = 9;
            this.ID_Numeric.ValueChanged += new System.EventHandler(this.ID_Numeric_ValueChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(228, 147);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 15);
            this.PriceLabel.TabIndex = 175;
            this.PriceLabel.Text = "Price";
            // 
            // TMLabel
            // 
            this.TMLabel.AutoSize = true;
            this.TMLabel.Location = new System.Drawing.Point(227, 264);
            this.TMLabel.Name = "TMLabel";
            this.TMLabel.Size = new System.Drawing.Size(37, 15);
            this.TMLabel.TabIndex = 174;
            this.TMLabel.Text = "Move";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(227, 320);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 173;
            this.DescriptionLabel.Text = "Description";
            // 
            // UsabilityOutBattle
            // 
            this.UsabilityOutBattle.AutoSize = true;
            this.UsabilityOutBattle.Location = new System.Drawing.Point(227, 206);
            this.UsabilityOutBattle.Name = "UsabilityOutBattle";
            this.UsabilityOutBattle.Size = new System.Drawing.Size(51, 15);
            this.UsabilityOutBattle.TabIndex = 171;
            this.UsabilityOutBattle.Text = "FieldUse";
            // 
            // PocketLabel
            // 
            this.PocketLabel.AutoSize = true;
            this.PocketLabel.Location = new System.Drawing.Point(228, 119);
            this.PocketLabel.Name = "PocketLabel";
            this.PocketLabel.Size = new System.Drawing.Size(43, 15);
            this.PocketLabel.TabIndex = 170;
            this.PocketLabel.Text = "Pocket";
            // 
            // UsabilityInBattleLabel
            // 
            this.UsabilityInBattleLabel.AutoSize = true;
            this.UsabilityInBattleLabel.Location = new System.Drawing.Point(227, 235);
            this.UsabilityInBattleLabel.Name = "UsabilityInBattleLabel";
            this.UsabilityInBattleLabel.Size = new System.Drawing.Size(56, 15);
            this.UsabilityInBattleLabel.TabIndex = 169;
            this.UsabilityInBattleLabel.Text = "BattleUse";
            // 
            // PluralNameLabel
            // 
            this.PluralNameLabel.AutoSize = true;
            this.PluralNameLabel.Location = new System.Drawing.Point(228, 90);
            this.PluralNameLabel.Name = "PluralNameLabel";
            this.PluralNameLabel.Size = new System.Drawing.Size(69, 15);
            this.PluralNameLabel.TabIndex = 168;
            this.PluralNameLabel.Text = "PluralName";
            // 
            // InternalNameLabel
            // 
            this.InternalNameLabel.AutoSize = true;
            this.InternalNameLabel.Location = new System.Drawing.Point(228, 31);
            this.InternalNameLabel.Name = "InternalNameLabel";
            this.InternalNameLabel.Size = new System.Drawing.Size(79, 15);
            this.InternalNameLabel.TabIndex = 167;
            this.InternalNameLabel.Text = "InternalName";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(228, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 166;
            this.NameLabel.Text = "Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(228, 176);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(51, 15);
            this.IDLabel.TabIndex = 165;
            this.IDLabel.Text = "SellPrice";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(12, 367);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(86, 28);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Del_Button
            // 
            this.Del_Button.Location = new System.Drawing.Point(125, 367);
            this.Del_Button.Name = "Del_Button";
            this.Del_Button.Size = new System.Drawing.Size(86, 28);
            this.Del_Button.TabIndex = 3;
            this.Del_Button.Text = "Del";
            this.Del_Button.UseVisualStyleBackColor = true;
            this.Del_Button.Click += new System.EventHandler(this.Del_Button_Click);
            // 
            // Items_ListBox
            // 
            this.Items_ListBox.FormattingEnabled = true;
            this.Items_ListBox.ItemHeight = 15;
            this.Items_ListBox.Location = new System.Drawing.Point(12, 27);
            this.Items_ListBox.Name = "Items_ListBox";
            this.Items_ListBox.Size = new System.Drawing.Size(199, 334);
            this.Items_ListBox.TabIndex = 1;
            this.Items_ListBox.SelectedIndexChanged += new System.EventHandler(this.Items_ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 189;
            this.label1.Text = "Consumable";
            // 
            // textBox_Consumable
            // 
            this.textBox_Consumable.Location = new System.Drawing.Point(312, 290);
            this.textBox_Consumable.Name = "textBox_Consumable";
            this.textBox_Consumable.Size = new System.Drawing.Size(219, 23);
            this.textBox_Consumable.TabIndex = 14;
            this.textBox_Consumable.TextChanged += new System.EventHandler(this.TextBox_Consumable_TextChanged);
            // 
            // UpdateFlag_Button
            // 
            this.UpdateFlag_Button.Location = new System.Drawing.Point(537, 253);
            this.UpdateFlag_Button.Name = "UpdateFlag_Button";
            this.UpdateFlag_Button.Size = new System.Drawing.Size(86, 28);
            this.UpdateFlag_Button.TabIndex = 17;
            this.UpdateFlag_Button.Text = "Update Flag";
            this.UpdateFlag_Button.UseVisualStyleBackColor = true;
            this.UpdateFlag_Button.Click += new System.EventHandler(this.UpdateFlag_Button_Click);
            // 
            // Flags_CheckedListBox
            // 
            this.Flags_CheckedListBox.FormattingEnabled = true;
            this.Flags_CheckedListBox.Location = new System.Drawing.Point(537, 45);
            this.Flags_CheckedListBox.Name = "Flags_CheckedListBox";
            this.Flags_CheckedListBox.Size = new System.Drawing.Size(233, 202);
            this.Flags_CheckedListBox.TabIndex = 16;
            // 
            // FlagsLabel
            // 
            this.FlagsLabel.AutoSize = true;
            this.FlagsLabel.Location = new System.Drawing.Point(537, 27);
            this.FlagsLabel.Name = "FlagsLabel";
            this.FlagsLabel.Size = new System.Drawing.Size(34, 15);
            this.FlagsLabel.TabIndex = 211;
            this.FlagsLabel.Text = "Flags";
            // 
            // Form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 416);
            this.Controls.Add(this.UpdateFlag_Button);
            this.Controls.Add(this.Flags_CheckedListBox);
            this.Controls.Add(this.FlagsLabel);
            this.Controls.Add(this.textBox_Consumable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.TM_CheckBox);
            this.Controls.Add(this.TM_ComboBox);
            this.Controls.Add(this.UsabilityIn_ComboBox);
            this.Controls.Add(this.UsabilityOut_ComboBox);
            this.Controls.Add(this.Price_Numeric);
            this.Controls.Add(this.Pocket_ComboBox);
            this.Controls.Add(this.PluralName_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.InternalName_TextBox);
            this.Controls.Add(this.ID_Numeric);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TMLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.UsabilityOutBattle);
            this.Controls.Add(this.PocketLabel);
            this.Controls.Add(this.UsabilityInBattleLabel);
            this.Controls.Add(this.PluralNameLabel);
            this.Controls.Add(this.InternalNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Del_Button);
            this.Controls.Add(this.Items_ListBox);
            this.Controls.Add(this.BaseMenu_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.BaseMenu_Menu;
            this.MaximizeBox = false;
            this.Name = "Form_Items";
            this.ShowIcon = false;
            this.Text = "Edit Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Items_FormClosing);
            this.BaseMenu_Menu.ResumeLayout(false);
            this.BaseMenu_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseMenu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Generate_Menu;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.CheckBox TM_CheckBox;
        private System.Windows.Forms.ComboBox TM_ComboBox;
        private System.Windows.Forms.ComboBox UsabilityIn_ComboBox;
        private System.Windows.Forms.ComboBox UsabilityOut_ComboBox;
        private System.Windows.Forms.NumericUpDown Price_Numeric;
        private System.Windows.Forms.ComboBox Pocket_ComboBox;
        private System.Windows.Forms.TextBox PluralName_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox InternalName_TextBox;
        private System.Windows.Forms.NumericUpDown ID_Numeric;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TMLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label UsabilityOutBattle;
        private System.Windows.Forms.Label PocketLabel;
        private System.Windows.Forms.Label UsabilityInBattleLabel;
        private System.Windows.Forms.Label PluralNameLabel;
        private System.Windows.Forms.Label InternalNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Del_Button;
        private System.Windows.Forms.ListBox Items_ListBox;
        private System.Windows.Forms.ToolStripMenuItem GenerateItem_Menu;
        private System.Windows.Forms.ToolStripMenuItem GeneratePBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_Menu;
        private System.Windows.Forms.ToolStripMenuItem Compile_Menu;
        private System.Windows.Forms.ToolStripMenuItem CompileChanges_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenPBS_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Consumable;
        private System.Windows.Forms.Button UpdateFlag_Button;
        private System.Windows.Forms.CheckedListBox Flags_CheckedListBox;
        private System.Windows.Forms.Label FlagsLabel;
    }
}