
namespace PBS_Editor
{
    partial class Form_TrainerTypes
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
            this.GenerateTrainerType_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTType_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Compile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileChanges_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Del_Button = new System.Windows.Forms.Button();
            this.TrainerType_ListBox = new System.Windows.Forms.ListBox();
            this.Skill_Numeric = new System.Windows.Forms.NumericUpDown();
            this.SkillCode_TextBox = new System.Windows.Forms.TextBox();
            this.Gender_ComboBox = new System.Windows.Forms.ComboBox();
            this.BattleBGM_TextBox = new System.Windows.Forms.TextBox();
            this.VictoryBGM_TextBox = new System.Windows.Forms.TextBox();
            this.introBGM_TextBox = new System.Windows.Forms.TextBox();
            this.BaseMoney_Numeric = new System.Windows.Forms.NumericUpDown();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.InternalName_TextBox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BGMLabel = new System.Windows.Forms.Label();
            this.Victorylabel = new System.Windows.Forms.Label();
            this.SkillCodesLabel = new System.Windows.Forms.Label();
            this.BaseMoneyLabel = new System.Windows.Forms.Label();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.InternalNameLabel = new System.Windows.Forms.Label();
            this.IntroMELabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BaseMenu_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skill_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseMoney_Numeric)).BeginInit();
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
            this.BaseMenu_Menu.Size = new System.Drawing.Size(525, 24);
            this.BaseMenu_Menu.TabIndex = 0;
            this.BaseMenu_Menu.Text = "menuStrip1";
            // 
            // Generate_Menu
            // 
            this.Generate_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateTrainerType_Menu,
            this.GeneratePBS_Menu});
            this.Generate_Menu.Name = "Generate_Menu";
            this.Generate_Menu.Size = new System.Drawing.Size(66, 20);
            this.Generate_Menu.Text = "Generate";
            // 
            // GenerateTrainerType_Menu
            // 
            this.GenerateTrainerType_Menu.Name = "GenerateTrainerType_Menu";
            this.GenerateTrainerType_Menu.Size = new System.Drawing.Size(226, 22);
            this.GenerateTrainerType_Menu.Text = "Generate Current TrainerType";
            this.GenerateTrainerType_Menu.Click += new System.EventHandler(this.GenerateTrainerType_Menu_Click);
            // 
            // GeneratePBS_Menu
            // 
            this.GeneratePBS_Menu.Name = "GeneratePBS_Menu";
            this.GeneratePBS_Menu.Size = new System.Drawing.Size(226, 22);
            this.GeneratePBS_Menu.Text = "Generate PBS File";
            this.GeneratePBS_Menu.Click += new System.EventHandler(this.GeneratePBS_Menu_Click);
            // 
            // Open_Menu
            // 
            this.Open_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTType_Menu,
            this.OpenPBS_Menu});
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(48, 20);
            this.Open_Menu.Text = "Open";
            // 
            // OpenTType_Menu
            // 
            this.OpenTType_Menu.Name = "OpenTType_Menu";
            this.OpenTType_Menu.Size = new System.Drawing.Size(222, 22);
            this.OpenTType_Menu.Text = "Open Generated TrainerType";
            this.OpenTType_Menu.Click += new System.EventHandler(this.OpenTType_Menu_Click);
            // 
            // OpenPBS_Menu
            // 
            this.OpenPBS_Menu.Name = "OpenPBS_Menu";
            this.OpenPBS_Menu.Size = new System.Drawing.Size(222, 22);
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
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(12, 277);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(86, 28);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Del_Button
            // 
            this.Del_Button.Location = new System.Drawing.Point(125, 277);
            this.Del_Button.Name = "Del_Button";
            this.Del_Button.Size = new System.Drawing.Size(86, 28);
            this.Del_Button.TabIndex = 3;
            this.Del_Button.Text = "Del";
            this.Del_Button.UseVisualStyleBackColor = true;
            this.Del_Button.Click += new System.EventHandler(this.Del_Button_Click);
            // 
            // TrainerType_ListBox
            // 
            this.TrainerType_ListBox.FormattingEnabled = true;
            this.TrainerType_ListBox.ItemHeight = 15;
            this.TrainerType_ListBox.Location = new System.Drawing.Point(12, 27);
            this.TrainerType_ListBox.Name = "TrainerType_ListBox";
            this.TrainerType_ListBox.Size = new System.Drawing.Size(199, 244);
            this.TrainerType_ListBox.TabIndex = 1;
            this.TrainerType_ListBox.SelectedIndexChanged += new System.EventHandler(this.TrainerType_ListBox_SelectedIndexChanged);
            // 
            // Skill_Numeric
            // 
            this.Skill_Numeric.Location = new System.Drawing.Point(319, 259);
            this.Skill_Numeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Skill_Numeric.Name = "Skill_Numeric";
            this.Skill_Numeric.Size = new System.Drawing.Size(56, 23);
            this.Skill_Numeric.TabIndex = 11;
            this.Skill_Numeric.ValueChanged += new System.EventHandler(this.Skill_Numeric_ValueChanged);
            // 
            // SkillCode_TextBox
            // 
            this.SkillCode_TextBox.Location = new System.Drawing.Point(319, 288);
            this.SkillCode_TextBox.Name = "SkillCode_TextBox";
            this.SkillCode_TextBox.Size = new System.Drawing.Size(188, 23);
            this.SkillCode_TextBox.TabIndex = 12;
            this.SkillCode_TextBox.TextChanged += new System.EventHandler(this.SkillCode_TextBox_TextChanged);
            // 
            // Gender_ComboBox
            // 
            this.Gender_ComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Mixed"});
            this.Gender_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Gender_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_ComboBox.FormattingEnabled = true;
            this.Gender_ComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.Gender_ComboBox.Location = new System.Drawing.Point(319, 230);
            this.Gender_ComboBox.Name = "Gender_ComboBox";
            this.Gender_ComboBox.Size = new System.Drawing.Size(188, 23);
            this.Gender_ComboBox.TabIndex = 10;
            this.Gender_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Gender_ComboBox_SelectedIndexChanged);
            // 
            // BattleBGM_TextBox
            // 
            this.BattleBGM_TextBox.Location = new System.Drawing.Point(319, 172);
            this.BattleBGM_TextBox.Name = "BattleBGM_TextBox";
            this.BattleBGM_TextBox.Size = new System.Drawing.Size(188, 23);
            this.BattleBGM_TextBox.TabIndex = 8;
            this.BattleBGM_TextBox.TextChanged += new System.EventHandler(this.VictoryME_TextBox_TextChanged);
            // 
            // VictoryBGM_TextBox
            // 
            this.VictoryBGM_TextBox.Location = new System.Drawing.Point(319, 201);
            this.VictoryBGM_TextBox.Name = "VictoryBGM_TextBox";
            this.VictoryBGM_TextBox.Size = new System.Drawing.Size(188, 23);
            this.VictoryBGM_TextBox.TabIndex = 9;
            this.VictoryBGM_TextBox.TextChanged += new System.EventHandler(this.IntroME_TextBox_TextChanged);
            // 
            // introBGM_TextBox
            // 
            this.introBGM_TextBox.Location = new System.Drawing.Point(319, 143);
            this.introBGM_TextBox.Name = "introBGM_TextBox";
            this.introBGM_TextBox.Size = new System.Drawing.Size(188, 23);
            this.introBGM_TextBox.TabIndex = 7;
            this.introBGM_TextBox.TextChanged += new System.EventHandler(this.BGM_TextBox_TextChanged);
            // 
            // BaseMoney_Numeric
            // 
            this.BaseMoney_Numeric.Location = new System.Drawing.Point(319, 114);
            this.BaseMoney_Numeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.BaseMoney_Numeric.Name = "BaseMoney_Numeric";
            this.BaseMoney_Numeric.Size = new System.Drawing.Size(56, 23);
            this.BaseMoney_Numeric.TabIndex = 6;
            this.BaseMoney_Numeric.ValueChanged += new System.EventHandler(this.BaseMoney_Numeric_ValueChanged);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(319, 85);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(188, 23);
            this.Name_TextBox.TabIndex = 5;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // InternalName_TextBox
            // 
            this.InternalName_TextBox.Location = new System.Drawing.Point(319, 56);
            this.InternalName_TextBox.Name = "InternalName_TextBox";
            this.InternalName_TextBox.Size = new System.Drawing.Size(188, 23);
            this.InternalName_TextBox.TabIndex = 4;
            this.InternalName_TextBox.TextChanged += new System.EventHandler(this.InternalName_TextBox_TextChanged);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(227, 233);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 15);
            this.GenderLabel.TabIndex = 164;
            this.GenderLabel.Text = "Gender";
            // 
            // BGMLabel
            // 
            this.BGMLabel.AutoSize = true;
            this.BGMLabel.Location = new System.Drawing.Point(227, 146);
            this.BGMLabel.Name = "BGMLabel";
            this.BGMLabel.Size = new System.Drawing.Size(58, 15);
            this.BGMLabel.TabIndex = 163;
            this.BGMLabel.Text = "IntroBGM";
            // 
            // Victorylabel
            // 
            this.Victorylabel.AutoSize = true;
            this.Victorylabel.Location = new System.Drawing.Point(227, 175);
            this.Victorylabel.Name = "Victorylabel";
            this.Victorylabel.Size = new System.Drawing.Size(63, 15);
            this.Victorylabel.TabIndex = 162;
            this.Victorylabel.Text = "BattleBGM";
            // 
            // SkillCodesLabel
            // 
            this.SkillCodesLabel.AutoSize = true;
            this.SkillCodesLabel.Location = new System.Drawing.Point(227, 291);
            this.SkillCodesLabel.Name = "SkillCodesLabel";
            this.SkillCodesLabel.Size = new System.Drawing.Size(34, 15);
            this.SkillCodesLabel.TabIndex = 161;
            this.SkillCodesLabel.Text = "Flags";
            // 
            // BaseMoneyLabel
            // 
            this.BaseMoneyLabel.AutoSize = true;
            this.BaseMoneyLabel.Location = new System.Drawing.Point(227, 116);
            this.BaseMoneyLabel.Name = "BaseMoneyLabel";
            this.BaseMoneyLabel.Size = new System.Drawing.Size(68, 15);
            this.BaseMoneyLabel.TabIndex = 160;
            this.BaseMoneyLabel.Text = "BaseMoney";
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Location = new System.Drawing.Point(227, 261);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(45, 15);
            this.SkillLabel.TabIndex = 159;
            this.SkillLabel.Text = "Skill Lvl";
            // 
            // InternalNameLabel
            // 
            this.InternalNameLabel.AutoSize = true;
            this.InternalNameLabel.Location = new System.Drawing.Point(227, 59);
            this.InternalNameLabel.Name = "InternalNameLabel";
            this.InternalNameLabel.Size = new System.Drawing.Size(18, 15);
            this.InternalNameLabel.TabIndex = 158;
            this.InternalNameLabel.Text = "ID";
            // 
            // IntroMELabel
            // 
            this.IntroMELabel.AutoSize = true;
            this.IntroMELabel.Location = new System.Drawing.Point(227, 204);
            this.IntroMELabel.Name = "IntroMELabel";
            this.IntroMELabel.Size = new System.Drawing.Size(70, 15);
            this.IntroMELabel.TabIndex = 157;
            this.IntroMELabel.Text = "VictoryBGM";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(227, 88);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 156;
            this.NameLabel.Text = "Name";
            // 
            // Form_TrainerTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 320);
            this.Controls.Add(this.Skill_Numeric);
            this.Controls.Add(this.SkillCode_TextBox);
            this.Controls.Add(this.Gender_ComboBox);
            this.Controls.Add(this.BattleBGM_TextBox);
            this.Controls.Add(this.VictoryBGM_TextBox);
            this.Controls.Add(this.introBGM_TextBox);
            this.Controls.Add(this.BaseMoney_Numeric);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.InternalName_TextBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.BGMLabel);
            this.Controls.Add(this.Victorylabel);
            this.Controls.Add(this.SkillCodesLabel);
            this.Controls.Add(this.BaseMoneyLabel);
            this.Controls.Add(this.SkillLabel);
            this.Controls.Add(this.InternalNameLabel);
            this.Controls.Add(this.IntroMELabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Del_Button);
            this.Controls.Add(this.TrainerType_ListBox);
            this.Controls.Add(this.BaseMenu_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.BaseMenu_Menu;
            this.MaximizeBox = false;
            this.Name = "Form_TrainerTypes";
            this.ShowIcon = false;
            this.Text = "Edit TrainerTypes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_TrainerTypes_FormClosing);
            this.BaseMenu_Menu.ResumeLayout(false);
            this.BaseMenu_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skill_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseMoney_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseMenu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Generate_Menu;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Del_Button;
        private System.Windows.Forms.ListBox TrainerType_ListBox;
        private System.Windows.Forms.NumericUpDown Skill_Numeric;
        private System.Windows.Forms.TextBox SkillCode_TextBox;
        private System.Windows.Forms.ComboBox Gender_ComboBox;
        private System.Windows.Forms.TextBox BattleBGM_TextBox;
        private System.Windows.Forms.TextBox VictoryBGM_TextBox;
        private System.Windows.Forms.TextBox introBGM_TextBox;
        private System.Windows.Forms.NumericUpDown BaseMoney_Numeric;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox InternalName_TextBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label BGMLabel;
        private System.Windows.Forms.Label Victorylabel;
        private System.Windows.Forms.Label SkillCodesLabel;
        private System.Windows.Forms.Label BaseMoneyLabel;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.Label InternalNameLabel;
        private System.Windows.Forms.Label IntroMELabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ToolStripMenuItem GenerateTrainerType_Menu;
        private System.Windows.Forms.ToolStripMenuItem GeneratePBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenTType_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenPBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Compile_Menu;
        private System.Windows.Forms.ToolStripMenuItem CompileChanges_Menu;
    }
}