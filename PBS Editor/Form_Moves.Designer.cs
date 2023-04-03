
namespace PBS_Editor
{
    partial class Form_Moves
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
            this.BaseMenu_Menu = new System.Windows.Forms.MenuStrip();
            this.Generate_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateMove_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMove_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Compile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileChanges_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateFlag_Button = new System.Windows.Forms.Button();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InternalNameLabel = new System.Windows.Forms.Label();
            this.InternalName_TextBox = new System.Windows.Forms.TextBox();
            this.Flags_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.FlagsLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Target_ComboBox = new System.Windows.Forms.ComboBox();
            this.EffectChance_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Priority_Numeric = new System.Windows.Forms.NumericUpDown();
            this.PP_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Accuracy_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Category_ComboBox = new System.Windows.Forms.ComboBox();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.Damage_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Code_TextBox = new System.Windows.Forms.TextBox();
            this.EffectChanceLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PPLabel = new System.Windows.Forms.Label();
            this.DamageLabel = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Del_Button = new System.Windows.Forms.Button();
            this.Moves_ListBox = new System.Windows.Forms.ListBox();
            this.BaseMenu_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EffectChance_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priority_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PP_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accuracy_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Damage_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseMenu_Menu
            // 
            this.BaseMenu_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Generate_Menu,
            this.Open_Menu,
            this.Compile_Menu});
            this.BaseMenu_Menu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu_Menu.Name = "BaseMenu_Menu";
            this.BaseMenu_Menu.Size = new System.Drawing.Size(750, 24);
            this.BaseMenu_Menu.TabIndex = 0;
            this.BaseMenu_Menu.Text = "menuStrip1";
            // 
            // Generate_Menu
            // 
            this.Generate_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateMove_Menu,
            this.GeneratePBS_Menu});
            this.Generate_Menu.Name = "Generate_Menu";
            this.Generate_Menu.Size = new System.Drawing.Size(66, 20);
            this.Generate_Menu.Text = "Generate";
            // 
            // GenerateMove_Menu
            // 
            this.GenerateMove_Menu.Name = "GenerateMove_Menu";
            this.GenerateMove_Menu.Size = new System.Drawing.Size(197, 22);
            this.GenerateMove_Menu.Text = "Generate Current Move";
            this.GenerateMove_Menu.Click += new System.EventHandler(this.GenerateMove_Menu_Click);
            // 
            // GeneratePBS_Menu
            // 
            this.GeneratePBS_Menu.Name = "GeneratePBS_Menu";
            this.GeneratePBS_Menu.Size = new System.Drawing.Size(197, 22);
            this.GeneratePBS_Menu.Text = "Generate PBS File";
            this.GeneratePBS_Menu.Click += new System.EventHandler(this.GeneratePBS_Menu_Click);
            // 
            // Open_Menu
            // 
            this.Open_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMove_Menu,
            this.OpenPBS_Menu});
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(48, 20);
            this.Open_Menu.Text = "Open";
            // 
            // OpenMove_Menu
            // 
            this.OpenMove_Menu.Name = "OpenMove_Menu";
            this.OpenMove_Menu.Size = new System.Drawing.Size(193, 22);
            this.OpenMove_Menu.Text = "Open Generated Move";
            this.OpenMove_Menu.Click += new System.EventHandler(this.OpenMove_Menu_Click);
            // 
            // OpenPBS_Menu
            // 
            this.OpenPBS_Menu.Name = "OpenPBS_Menu";
            this.OpenPBS_Menu.Size = new System.Drawing.Size(193, 22);
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
            // UpdateFlag_Button
            // 
            this.UpdateFlag_Button.Location = new System.Drawing.Point(470, 255);
            this.UpdateFlag_Button.Name = "UpdateFlag_Button";
            this.UpdateFlag_Button.Size = new System.Drawing.Size(86, 28);
            this.UpdateFlag_Button.TabIndex = 16;
            this.UpdateFlag_Button.Text = "Update Flag";
            this.UpdateFlag_Button.UseVisualStyleBackColor = true;
            this.UpdateFlag_Button.Click += new System.EventHandler(this.UpdateFlag_Button_Click);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(312, 85);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(142, 23);
            this.Name_TextBox.TabIndex = 5;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(227, 88);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 207;
            this.NameLabel.Text = "Name";
            // 
            // InternalNameLabel
            // 
            this.InternalNameLabel.AutoSize = true;
            this.InternalNameLabel.Location = new System.Drawing.Point(227, 59);
            this.InternalNameLabel.Name = "InternalNameLabel";
            this.InternalNameLabel.Size = new System.Drawing.Size(18, 15);
            this.InternalNameLabel.TabIndex = 206;
            this.InternalNameLabel.Text = "ID";
            // 
            // InternalName_TextBox
            // 
            this.InternalName_TextBox.Location = new System.Drawing.Point(312, 56);
            this.InternalName_TextBox.Name = "InternalName_TextBox";
            this.InternalName_TextBox.Size = new System.Drawing.Size(142, 23);
            this.InternalName_TextBox.TabIndex = 4;
            this.InternalName_TextBox.TextChanged += new System.EventHandler(this.InternalName_TextBox_TextChanged);
            // 
            // Flags_CheckedListBox
            // 
            this.Flags_CheckedListBox.FormattingEnabled = true;
            this.Flags_CheckedListBox.Location = new System.Drawing.Point(470, 47);
            this.Flags_CheckedListBox.Name = "Flags_CheckedListBox";
            this.Flags_CheckedListBox.Size = new System.Drawing.Size(267, 202);
            this.Flags_CheckedListBox.TabIndex = 15;
            this.Flags_CheckedListBox.SelectedIndexChanged += new System.EventHandler(this.Flags_CheckedListBox_SelectedIndexChanged);
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.Location = new System.Drawing.Point(470, 304);
            this.Description_TextBox.Multiline = true;
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(267, 69);
            this.Description_TextBox.TabIndex = 17;
            this.Description_TextBox.TextChanged += new System.EventHandler(this.Description_TextBox_TextChanged);
            // 
            // FlagsLabel
            // 
            this.FlagsLabel.AutoSize = true;
            this.FlagsLabel.Location = new System.Drawing.Point(470, 29);
            this.FlagsLabel.Name = "FlagsLabel";
            this.FlagsLabel.Size = new System.Drawing.Size(34, 15);
            this.FlagsLabel.TabIndex = 202;
            this.FlagsLabel.Text = "Flags";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(470, 286);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.DescriptionLabel.TabIndex = 201;
            this.DescriptionLabel.Text = "Description";
            // 
            // Target_ComboBox
            // 
            this.Target_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Target_ComboBox.FormattingEnabled = true;
            this.Target_ComboBox.Location = new System.Drawing.Point(312, 317);
            this.Target_ComboBox.Name = "Target_ComboBox";
            this.Target_ComboBox.Size = new System.Drawing.Size(142, 23);
            this.Target_ComboBox.TabIndex = 13;
            this.Target_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Target_ComboBox_SelectedIndexChanged);
            // 
            // EffectChance_Numeric
            // 
            this.EffectChance_Numeric.Location = new System.Drawing.Point(312, 288);
            this.EffectChance_Numeric.Name = "EffectChance_Numeric";
            this.EffectChance_Numeric.Size = new System.Drawing.Size(56, 23);
            this.EffectChance_Numeric.TabIndex = 12;
            this.EffectChance_Numeric.ValueChanged += new System.EventHandler(this.EffectChance_Numeric_ValueChanged);
            // 
            // Priority_Numeric
            // 
            this.Priority_Numeric.Location = new System.Drawing.Point(312, 346);
            this.Priority_Numeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Priority_Numeric.Name = "Priority_Numeric";
            this.Priority_Numeric.Size = new System.Drawing.Size(56, 23);
            this.Priority_Numeric.TabIndex = 14;
            this.Priority_Numeric.ValueChanged += new System.EventHandler(this.Priority_Numeric_ValueChanged);
            // 
            // PP_Numeric
            // 
            this.PP_Numeric.Location = new System.Drawing.Point(312, 259);
            this.PP_Numeric.Name = "PP_Numeric";
            this.PP_Numeric.Size = new System.Drawing.Size(56, 23);
            this.PP_Numeric.TabIndex = 11;
            this.PP_Numeric.ValueChanged += new System.EventHandler(this.PP_Numeric_ValueChanged);
            // 
            // Accuracy_Numeric
            // 
            this.Accuracy_Numeric.Location = new System.Drawing.Point(312, 230);
            this.Accuracy_Numeric.Name = "Accuracy_Numeric";
            this.Accuracy_Numeric.Size = new System.Drawing.Size(56, 23);
            this.Accuracy_Numeric.TabIndex = 10;
            this.Accuracy_Numeric.ValueChanged += new System.EventHandler(this.Accuracy_Numeric_ValueChanged);
            // 
            // Category_ComboBox
            // 
            this.Category_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_ComboBox.FormattingEnabled = true;
            this.Category_ComboBox.Items.AddRange(new object[] {
            "Physical",
            "Special",
            "Status"});
            this.Category_ComboBox.Location = new System.Drawing.Point(312, 201);
            this.Category_ComboBox.Name = "Category_ComboBox";
            this.Category_ComboBox.Size = new System.Drawing.Size(142, 23);
            this.Category_ComboBox.TabIndex = 9;
            this.Category_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Category_ComboBox_SelectedIndexChanged);
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Type_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Type_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(312, 172);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(142, 23);
            this.Type_ComboBox.TabIndex = 8;
            this.Type_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Type_ComboBox_SelectedIndexChanged);
            // 
            // Damage_Numeric
            // 
            this.Damage_Numeric.Location = new System.Drawing.Point(312, 143);
            this.Damage_Numeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Damage_Numeric.Name = "Damage_Numeric";
            this.Damage_Numeric.Size = new System.Drawing.Size(56, 23);
            this.Damage_Numeric.TabIndex = 7;
            this.Damage_Numeric.ValueChanged += new System.EventHandler(this.Damage_Numeric_ValueChanged);
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.Location = new System.Drawing.Point(312, 114);
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.Size = new System.Drawing.Size(56, 23);
            this.Code_TextBox.TabIndex = 6;
            this.Code_TextBox.TextChanged += new System.EventHandler(this.Code_TextBox_TextChanged);
            // 
            // EffectChanceLabel
            // 
            this.EffectChanceLabel.AutoSize = true;
            this.EffectChanceLabel.Location = new System.Drawing.Point(227, 290);
            this.EffectChanceLabel.Name = "EffectChanceLabel";
            this.EffectChanceLabel.Size = new System.Drawing.Size(77, 15);
            this.EffectChanceLabel.TabIndex = 190;
            this.EffectChanceLabel.Text = "EffectChance";
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.Location = new System.Drawing.Point(227, 320);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(39, 15);
            this.TargetLabel.TabIndex = 189;
            this.TargetLabel.Text = "Target";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(227, 204);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(55, 15);
            this.CategoryLabel.TabIndex = 188;
            this.CategoryLabel.Text = "Category";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(227, 348);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(45, 15);
            this.PriorityLabel.TabIndex = 187;
            this.PriorityLabel.Text = "Priority";
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Location = new System.Drawing.Point(227, 232);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(56, 15);
            this.AccuracyLabel.TabIndex = 186;
            this.AccuracyLabel.Text = "Accuracy";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(227, 117);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(82, 15);
            this.CodeLabel.TabIndex = 185;
            this.CodeLabel.Text = "FunctionCode";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(227, 175);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 15);
            this.TypeLabel.TabIndex = 184;
            this.TypeLabel.Text = "Type";
            // 
            // PPLabel
            // 
            this.PPLabel.AutoSize = true;
            this.PPLabel.Location = new System.Drawing.Point(227, 261);
            this.PPLabel.Name = "PPLabel";
            this.PPLabel.Size = new System.Drawing.Size(46, 15);
            this.PPLabel.TabIndex = 183;
            this.PPLabel.Text = "TotalPP";
            // 
            // DamageLabel
            // 
            this.DamageLabel.AutoSize = true;
            this.DamageLabel.Location = new System.Drawing.Point(227, 145);
            this.DamageLabel.Name = "DamageLabel";
            this.DamageLabel.Size = new System.Drawing.Size(75, 15);
            this.DamageLabel.TabIndex = 182;
            this.DamageLabel.Text = "BaseDamage";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(12, 352);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(86, 28);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Del_Button
            // 
            this.Del_Button.Location = new System.Drawing.Point(125, 352);
            this.Del_Button.Name = "Del_Button";
            this.Del_Button.Size = new System.Drawing.Size(86, 28);
            this.Del_Button.TabIndex = 3;
            this.Del_Button.Text = "Del";
            this.Del_Button.UseVisualStyleBackColor = true;
            this.Del_Button.Click += new System.EventHandler(this.Del_Button_Click);
            // 
            // Moves_ListBox
            // 
            this.Moves_ListBox.FormattingEnabled = true;
            this.Moves_ListBox.ItemHeight = 15;
            this.Moves_ListBox.Location = new System.Drawing.Point(12, 27);
            this.Moves_ListBox.Name = "Moves_ListBox";
            this.Moves_ListBox.Size = new System.Drawing.Size(199, 319);
            this.Moves_ListBox.TabIndex = 1;
            this.Moves_ListBox.SelectedIndexChanged += new System.EventHandler(this.Moves_ListBox_SelectedIndexChanged);
            // 
            // Form_Moves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 389);
            this.Controls.Add(this.UpdateFlag_Button);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InternalNameLabel);
            this.Controls.Add(this.InternalName_TextBox);
            this.Controls.Add(this.Flags_CheckedListBox);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.FlagsLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Target_ComboBox);
            this.Controls.Add(this.EffectChance_Numeric);
            this.Controls.Add(this.Priority_Numeric);
            this.Controls.Add(this.PP_Numeric);
            this.Controls.Add(this.Accuracy_Numeric);
            this.Controls.Add(this.Category_ComboBox);
            this.Controls.Add(this.Type_ComboBox);
            this.Controls.Add(this.Damage_Numeric);
            this.Controls.Add(this.Code_TextBox);
            this.Controls.Add(this.EffectChanceLabel);
            this.Controls.Add(this.TargetLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.AccuracyLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.PPLabel);
            this.Controls.Add(this.DamageLabel);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Del_Button);
            this.Controls.Add(this.Moves_ListBox);
            this.Controls.Add(this.BaseMenu_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.BaseMenu_Menu;
            this.MaximizeBox = false;
            this.Name = "Form_Moves";
            this.ShowIcon = false;
            this.Text = "Edit Moves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Moves_FormClosing);
            this.BaseMenu_Menu.ResumeLayout(false);
            this.BaseMenu_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EffectChance_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Priority_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PP_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accuracy_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Damage_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseMenu_Menu;
        private System.Windows.Forms.Button UpdateFlag_Button;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label InternalNameLabel;
        private System.Windows.Forms.TextBox InternalName_TextBox;
        private System.Windows.Forms.CheckedListBox Flags_CheckedListBox;
        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.Label FlagsLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.ComboBox Target_ComboBox;
        private System.Windows.Forms.NumericUpDown EffectChance_Numeric;
        private System.Windows.Forms.NumericUpDown Priority_Numeric;
        private System.Windows.Forms.NumericUpDown PP_Numeric;
        private System.Windows.Forms.NumericUpDown Accuracy_Numeric;
        private System.Windows.Forms.ComboBox Category_ComboBox;
        private System.Windows.Forms.ComboBox Type_ComboBox;
        private System.Windows.Forms.NumericUpDown Damage_Numeric;
        private System.Windows.Forms.TextBox Code_TextBox;
        private System.Windows.Forms.Label EffectChanceLabel;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label AccuracyLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label PPLabel;
        private System.Windows.Forms.Label DamageLabel;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Del_Button;
        private System.Windows.Forms.ListBox Moves_ListBox;
        private System.Windows.Forms.ToolStripMenuItem Generate_Menu;
        private System.Windows.Forms.ToolStripMenuItem GenerateMove_Menu;
        private System.Windows.Forms.ToolStripMenuItem GeneratePBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenMove_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenPBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Compile_Menu;
        private System.Windows.Forms.ToolStripMenuItem CompileChanges_Menu;
    }
}