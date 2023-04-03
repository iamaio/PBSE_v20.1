
namespace PBS_Editor
{
    partial class Form_Types
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
            this.Types_ListBox = new System.Windows.Forms.ListBox();
            this.BaseMenu_Menu = new System.Windows.Forms.MenuStrip();
            this.Generate_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateType_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenType_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Compile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileChanges_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeAdd_Button = new System.Windows.Forms.Button();
            this.TypeDel_Button = new System.Windows.Forms.Button();
            this.Pseudo_CheckBox = new System.Windows.Forms.CheckBox();
            this.Special_CheckBox = new System.Windows.Forms.CheckBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.InternalName_TextBox = new System.Windows.Forms.TextBox();
            this.ID_Numeric = new System.Windows.Forms.NumericUpDown();
            this.IsSpecialTypeLabel = new System.Windows.Forms.Label();
            this.IsPseudoTypeLabel = new System.Windows.Forms.Label();
            this.InternalNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.TypesComboBox = new System.Windows.Forms.ComboBox();
            this.SelectTypeLabel = new System.Windows.Forms.Label();
            this.AddImmunities_Button = new System.Windows.Forms.Button();
            this.DelImmunities_Button = new System.Windows.Forms.Button();
            this.Immunities_ListBox = new System.Windows.Forms.ListBox();
            this.AddResistance_Button = new System.Windows.Forms.Button();
            this.DelResistance_Button = new System.Windows.Forms.Button();
            this.Resistances_ListBox = new System.Windows.Forms.ListBox();
            this.AddWeakness_Button = new System.Windows.Forms.Button();
            this.DelWeakness_Button = new System.Windows.Forms.Button();
            this.Weaknesses_LisBox = new System.Windows.Forms.ListBox();
            this.ImmunitiesLabel = new System.Windows.Forms.Label();
            this.ResistancesLabel = new System.Windows.Forms.Label();
            this.WeaknessesLabel = new System.Windows.Forms.Label();
            this.BaseMenu_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Types_ListBox
            // 
            this.Types_ListBox.FormattingEnabled = true;
            this.Types_ListBox.ItemHeight = 15;
            this.Types_ListBox.Location = new System.Drawing.Point(12, 27);
            this.Types_ListBox.Name = "Types_ListBox";
            this.Types_ListBox.Size = new System.Drawing.Size(199, 274);
            this.Types_ListBox.TabIndex = 1;
            this.Types_ListBox.SelectedIndexChanged += new System.EventHandler(this.Types_ListBox_SelectedIndexChanged);
            // 
            // BaseMenu_Menu
            // 
            this.BaseMenu_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Generate_Menu,
            this.Open_Menu,
            this.Compile_Menu});
            this.BaseMenu_Menu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu_Menu.Name = "BaseMenu_Menu";
            this.BaseMenu_Menu.Size = new System.Drawing.Size(642, 24);
            this.BaseMenu_Menu.TabIndex = 3;
            // 
            // Generate_Menu
            // 
            this.Generate_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateType_Menu,
            this.GeneratePBS_Menu});
            this.Generate_Menu.Name = "Generate_Menu";
            this.Generate_Menu.Size = new System.Drawing.Size(66, 20);
            this.Generate_Menu.Text = "Generate";
            // 
            // GenerateType_Menu
            // 
            this.GenerateType_Menu.Name = "GenerateType_Menu";
            this.GenerateType_Menu.Size = new System.Drawing.Size(191, 22);
            this.GenerateType_Menu.Text = "Generate Current Type";
            this.GenerateType_Menu.Click += new System.EventHandler(this.GenerateType_Menu_Click);
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
            this.OpenType_Menu,
            this.OpenPBS_Menu});
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(48, 20);
            this.Open_Menu.Text = "Open";
            // 
            // OpenType_Menu
            // 
            this.OpenType_Menu.Name = "OpenType_Menu";
            this.OpenType_Menu.Size = new System.Drawing.Size(187, 22);
            this.OpenType_Menu.Text = "Open Generated Type";
            this.OpenType_Menu.Click += new System.EventHandler(this.OpenType_Menu_Click);
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
            // TypeAdd_Button
            // 
            this.TypeAdd_Button.Location = new System.Drawing.Point(12, 307);
            this.TypeAdd_Button.Name = "TypeAdd_Button";
            this.TypeAdd_Button.Size = new System.Drawing.Size(86, 28);
            this.TypeAdd_Button.TabIndex = 2;
            this.TypeAdd_Button.Text = "Add";
            this.TypeAdd_Button.UseVisualStyleBackColor = true;
            this.TypeAdd_Button.Click += new System.EventHandler(this.TypeAdd_Button_Click);
            // 
            // TypeDel_Button
            // 
            this.TypeDel_Button.Location = new System.Drawing.Point(125, 307);
            this.TypeDel_Button.Name = "TypeDel_Button";
            this.TypeDel_Button.Size = new System.Drawing.Size(86, 28);
            this.TypeDel_Button.TabIndex = 3;
            this.TypeDel_Button.Text = "Del";
            this.TypeDel_Button.UseVisualStyleBackColor = true;
            this.TypeDel_Button.Click += new System.EventHandler(this.TypeDel_Button_Click);
            // 
            // Pseudo_CheckBox
            // 
            this.Pseudo_CheckBox.AutoSize = true;
            this.Pseudo_CheckBox.Location = new System.Drawing.Point(372, 169);
            this.Pseudo_CheckBox.Name = "Pseudo_CheckBox";
            this.Pseudo_CheckBox.Size = new System.Drawing.Size(43, 19);
            this.Pseudo_CheckBox.TabIndex = 7;
            this.Pseudo_CheckBox.Text = "Yes";
            this.Pseudo_CheckBox.UseVisualStyleBackColor = true;
            this.Pseudo_CheckBox.CheckedChanged += new System.EventHandler(this.Pseudo_CheckBox_CheckedChanged);
            // 
            // Special_CheckBox
            // 
            this.Special_CheckBox.AutoSize = true;
            this.Special_CheckBox.Location = new System.Drawing.Point(372, 144);
            this.Special_CheckBox.Name = "Special_CheckBox";
            this.Special_CheckBox.Size = new System.Drawing.Size(43, 19);
            this.Special_CheckBox.TabIndex = 6;
            this.Special_CheckBox.Text = "Yes";
            this.Special_CheckBox.UseVisualStyleBackColor = true;
            this.Special_CheckBox.CheckedChanged += new System.EventHandler(this.Special_CheckBox_CheckedChanged);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(227, 71);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(188, 23);
            this.Name_TextBox.TabIndex = 4;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // InternalName_TextBox
            // 
            this.InternalName_TextBox.Location = new System.Drawing.Point(227, 115);
            this.InternalName_TextBox.Name = "InternalName_TextBox";
            this.InternalName_TextBox.Size = new System.Drawing.Size(188, 23);
            this.InternalName_TextBox.TabIndex = 5;
            this.InternalName_TextBox.TextChanged += new System.EventHandler(this.InternalName_TextBox_TextChanged);
            // 
            // ID_Numeric
            // 
            this.ID_Numeric.Location = new System.Drawing.Point(359, 193);
            this.ID_Numeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ID_Numeric.Name = "ID_Numeric";
            this.ID_Numeric.Size = new System.Drawing.Size(56, 23);
            this.ID_Numeric.TabIndex = 8;
            this.ID_Numeric.ValueChanged += new System.EventHandler(this.ID_Numeric_ValueChanged);
            // 
            // IsSpecialTypeLabel
            // 
            this.IsSpecialTypeLabel.AutoSize = true;
            this.IsSpecialTypeLabel.Location = new System.Drawing.Point(227, 145);
            this.IsSpecialTypeLabel.Name = "IsSpecialTypeLabel";
            this.IsSpecialTypeLabel.Size = new System.Drawing.Size(76, 15);
            this.IsSpecialTypeLabel.TabIndex = 150;
            this.IsSpecialTypeLabel.Text = "IsSpecialType";
            // 
            // IsPseudoTypeLabel
            // 
            this.IsPseudoTypeLabel.AutoSize = true;
            this.IsPseudoTypeLabel.Location = new System.Drawing.Point(227, 170);
            this.IsPseudoTypeLabel.Name = "IsPseudoTypeLabel";
            this.IsPseudoTypeLabel.Size = new System.Drawing.Size(78, 15);
            this.IsPseudoTypeLabel.TabIndex = 149;
            this.IsPseudoTypeLabel.Text = "IsPseudoType";
            // 
            // InternalNameLabel
            // 
            this.InternalNameLabel.AutoSize = true;
            this.InternalNameLabel.Location = new System.Drawing.Point(227, 97);
            this.InternalNameLabel.Name = "InternalNameLabel";
            this.InternalNameLabel.Size = new System.Drawing.Size(18, 15);
            this.InternalNameLabel.TabIndex = 148;
            this.InternalNameLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(227, 53);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 147;
            this.NameLabel.Text = "Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(227, 195);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(73, 15);
            this.IDLabel.TabIndex = 146;
            this.IDLabel.Text = "IconPosition";
            // 
            // TypesComboBox
            // 
            this.TypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypesComboBox.FormattingEnabled = true;
            this.TypesComboBox.Location = new System.Drawing.Point(227, 278);
            this.TypesComboBox.Name = "TypesComboBox";
            this.TypesComboBox.Size = new System.Drawing.Size(188, 23);
            this.TypesComboBox.TabIndex = 9;
            // 
            // SelectTypeLabel
            // 
            this.SelectTypeLabel.AutoSize = true;
            this.SelectTypeLabel.Location = new System.Drawing.Point(227, 260);
            this.SelectTypeLabel.Name = "SelectTypeLabel";
            this.SelectTypeLabel.Size = new System.Drawing.Size(132, 15);
            this.SelectTypeLabel.TabIndex = 160;
            this.SelectTypeLabel.Text = "Select Type To Add >>>";
            // 
            // AddImmunities_Button
            // 
            this.AddImmunities_Button.Location = new System.Drawing.Point(431, 308);
            this.AddImmunities_Button.Name = "AddImmunities_Button";
            this.AddImmunities_Button.Size = new System.Drawing.Size(86, 28);
            this.AddImmunities_Button.TabIndex = 17;
            this.AddImmunities_Button.Text = "Add";
            this.AddImmunities_Button.UseVisualStyleBackColor = true;
            this.AddImmunities_Button.Click += new System.EventHandler(this.AddImmunities_Button_Click);
            // 
            // DelImmunities_Button
            // 
            this.DelImmunities_Button.Location = new System.Drawing.Point(544, 308);
            this.DelImmunities_Button.Name = "DelImmunities_Button";
            this.DelImmunities_Button.Size = new System.Drawing.Size(86, 28);
            this.DelImmunities_Button.TabIndex = 18;
            this.DelImmunities_Button.Text = "Del";
            this.DelImmunities_Button.UseVisualStyleBackColor = true;
            this.DelImmunities_Button.Click += new System.EventHandler(this.DelImmunities_Button_Click);
            // 
            // Immunities_ListBox
            // 
            this.Immunities_ListBox.FormattingEnabled = true;
            this.Immunities_ListBox.ItemHeight = 15;
            this.Immunities_ListBox.Location = new System.Drawing.Point(431, 253);
            this.Immunities_ListBox.Name = "Immunities_ListBox";
            this.Immunities_ListBox.Size = new System.Drawing.Size(199, 49);
            this.Immunities_ListBox.TabIndex = 16;
            // 
            // AddResistance_Button
            // 
            this.AddResistance_Button.Location = new System.Drawing.Point(431, 204);
            this.AddResistance_Button.Name = "AddResistance_Button";
            this.AddResistance_Button.Size = new System.Drawing.Size(86, 28);
            this.AddResistance_Button.TabIndex = 14;
            this.AddResistance_Button.Text = "Add";
            this.AddResistance_Button.UseVisualStyleBackColor = true;
            this.AddResistance_Button.Click += new System.EventHandler(this.AddResistance_Button_Click);
            // 
            // DelResistance_Button
            // 
            this.DelResistance_Button.Location = new System.Drawing.Point(544, 204);
            this.DelResistance_Button.Name = "DelResistance_Button";
            this.DelResistance_Button.Size = new System.Drawing.Size(86, 28);
            this.DelResistance_Button.TabIndex = 15;
            this.DelResistance_Button.Text = "Del";
            this.DelResistance_Button.UseVisualStyleBackColor = true;
            this.DelResistance_Button.Click += new System.EventHandler(this.DelResistance_Button_Click);
            // 
            // Resistances_ListBox
            // 
            this.Resistances_ListBox.FormattingEnabled = true;
            this.Resistances_ListBox.ItemHeight = 15;
            this.Resistances_ListBox.Location = new System.Drawing.Point(431, 149);
            this.Resistances_ListBox.Name = "Resistances_ListBox";
            this.Resistances_ListBox.Size = new System.Drawing.Size(199, 49);
            this.Resistances_ListBox.TabIndex = 13;
            // 
            // AddWeakness_Button
            // 
            this.AddWeakness_Button.Location = new System.Drawing.Point(431, 100);
            this.AddWeakness_Button.Name = "AddWeakness_Button";
            this.AddWeakness_Button.Size = new System.Drawing.Size(86, 28);
            this.AddWeakness_Button.TabIndex = 11;
            this.AddWeakness_Button.Text = "Add";
            this.AddWeakness_Button.UseVisualStyleBackColor = true;
            this.AddWeakness_Button.Click += new System.EventHandler(this.AddWeakness_Button_Click);
            // 
            // DelWeakness_Button
            // 
            this.DelWeakness_Button.Location = new System.Drawing.Point(544, 100);
            this.DelWeakness_Button.Name = "DelWeakness_Button";
            this.DelWeakness_Button.Size = new System.Drawing.Size(86, 28);
            this.DelWeakness_Button.TabIndex = 12;
            this.DelWeakness_Button.Text = "Del";
            this.DelWeakness_Button.UseVisualStyleBackColor = true;
            this.DelWeakness_Button.Click += new System.EventHandler(this.DelWeakness_Button_Click);
            // 
            // Weaknesses_LisBox
            // 
            this.Weaknesses_LisBox.FormattingEnabled = true;
            this.Weaknesses_LisBox.ItemHeight = 15;
            this.Weaknesses_LisBox.Location = new System.Drawing.Point(431, 45);
            this.Weaknesses_LisBox.Name = "Weaknesses_LisBox";
            this.Weaknesses_LisBox.Size = new System.Drawing.Size(199, 49);
            this.Weaknesses_LisBox.TabIndex = 10;
            // 
            // ImmunitiesLabel
            // 
            this.ImmunitiesLabel.AutoSize = true;
            this.ImmunitiesLabel.Location = new System.Drawing.Point(431, 235);
            this.ImmunitiesLabel.Name = "ImmunitiesLabel";
            this.ImmunitiesLabel.Size = new System.Drawing.Size(67, 15);
            this.ImmunitiesLabel.TabIndex = 164;
            this.ImmunitiesLabel.Text = "Immunities";
            // 
            // ResistancesLabel
            // 
            this.ResistancesLabel.AutoSize = true;
            this.ResistancesLabel.Location = new System.Drawing.Point(431, 131);
            this.ResistancesLabel.Name = "ResistancesLabel";
            this.ResistancesLabel.Size = new System.Drawing.Size(67, 15);
            this.ResistancesLabel.TabIndex = 163;
            this.ResistancesLabel.Text = "Resistances";
            // 
            // WeaknessesLabel
            // 
            this.WeaknessesLabel.AutoSize = true;
            this.WeaknessesLabel.Location = new System.Drawing.Point(431, 27);
            this.WeaknessesLabel.Name = "WeaknessesLabel";
            this.WeaknessesLabel.Size = new System.Drawing.Size(70, 15);
            this.WeaknessesLabel.TabIndex = 162;
            this.WeaknessesLabel.Text = "Weaknesses";
            // 
            // Form_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 346);
            this.Controls.Add(this.AddImmunities_Button);
            this.Controls.Add(this.DelImmunities_Button);
            this.Controls.Add(this.Immunities_ListBox);
            this.Controls.Add(this.AddResistance_Button);
            this.Controls.Add(this.DelResistance_Button);
            this.Controls.Add(this.Resistances_ListBox);
            this.Controls.Add(this.AddWeakness_Button);
            this.Controls.Add(this.DelWeakness_Button);
            this.Controls.Add(this.Weaknesses_LisBox);
            this.Controls.Add(this.ImmunitiesLabel);
            this.Controls.Add(this.ResistancesLabel);
            this.Controls.Add(this.WeaknessesLabel);
            this.Controls.Add(this.TypesComboBox);
            this.Controls.Add(this.SelectTypeLabel);
            this.Controls.Add(this.Pseudo_CheckBox);
            this.Controls.Add(this.Special_CheckBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.InternalName_TextBox);
            this.Controls.Add(this.ID_Numeric);
            this.Controls.Add(this.IsSpecialTypeLabel);
            this.Controls.Add(this.IsPseudoTypeLabel);
            this.Controls.Add(this.InternalNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.TypeAdd_Button);
            this.Controls.Add(this.TypeDel_Button);
            this.Controls.Add(this.Types_ListBox);
            this.Controls.Add(this.BaseMenu_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.BaseMenu_Menu;
            this.MaximizeBox = false;
            this.Name = "Form_Types";
            this.ShowIcon = false;
            this.Text = "Edit Types";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Types_FormClosing);
            this.BaseMenu_Menu.ResumeLayout(false);
            this.BaseMenu_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Types_ListBox;
        private System.Windows.Forms.MenuStrip BaseMenu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Generate_Menu;
        private System.Windows.Forms.Button TypeAdd_Button;
        private System.Windows.Forms.Button TypeDel_Button;
        private System.Windows.Forms.CheckBox Pseudo_CheckBox;
        private System.Windows.Forms.CheckBox Special_CheckBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox InternalName_TextBox;
        private System.Windows.Forms.NumericUpDown ID_Numeric;
        private System.Windows.Forms.Label IsSpecialTypeLabel;
        private System.Windows.Forms.Label IsPseudoTypeLabel;
        private System.Windows.Forms.Label InternalNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ComboBox TypesComboBox;
        private System.Windows.Forms.Label SelectTypeLabel;
        private System.Windows.Forms.Button AddImmunities_Button;
        private System.Windows.Forms.Button DelImmunities_Button;
        private System.Windows.Forms.ListBox Immunities_ListBox;
        private System.Windows.Forms.Button AddResistance_Button;
        private System.Windows.Forms.Button DelResistance_Button;
        private System.Windows.Forms.ListBox Resistances_ListBox;
        private System.Windows.Forms.Button AddWeakness_Button;
        private System.Windows.Forms.Button DelWeakness_Button;
        private System.Windows.Forms.ListBox Weaknesses_LisBox;
        private System.Windows.Forms.Label ImmunitiesLabel;
        private System.Windows.Forms.Label ResistancesLabel;
        private System.Windows.Forms.Label WeaknessesLabel;
        private System.Windows.Forms.ToolStripMenuItem GenerateType_Menu;
        private System.Windows.Forms.ToolStripMenuItem GeneratePBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenType_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenPBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Compile_Menu;
        private System.Windows.Forms.ToolStripMenuItem CompileChanges_Menu;
    }
}