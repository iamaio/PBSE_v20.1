
namespace PBS_Editor
{
    partial class Form_Encounters
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
            this.GenerateEncounter_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratePBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenEncounter_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPBS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Compile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CompileChanges_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SortMap_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMap_Button = new System.Windows.Forms.Button();
            this.AddMap_Button = new System.Windows.Forms.Button();
            this.Map_ListBox = new System.Windows.Forms.ListBox();
            this.MapNumber_Numeric = new System.Windows.Forms.NumericUpDown();
            this.MapName_TextBox = new System.Windows.Forms.TextBox();
            this.MapNameLabel = new System.Windows.Forms.Label();
            this.MapIDLabel = new System.Windows.Forms.Label();
            this.MapNumberLabel = new System.Windows.Forms.Label();
            this.MapID_Numeric = new System.Windows.Forms.NumericUpDown();
            this.EncounterType_ComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteEncType_Button = new System.Windows.Forms.Button();
            this.AddEncType_Button = new System.Windows.Forms.Button();
            this.EncTypes_ListBox = new System.Windows.Forms.ListBox();
            this.EncounterTypesLabel = new System.Windows.Forms.Label();
            this.Density_Numeric = new System.Windows.Forms.NumericUpDown();
            this.EncounterDensityLabel = new System.Windows.Forms.Label();
            this.Encounters_ListBox = new System.Windows.Forms.ListBox();
            this.EncountersLabel = new System.Windows.Forms.Label();
            this.MaxLvlCheckBox = new System.Windows.Forms.CheckBox();
            this.minLvlCheckBox = new System.Windows.Forms.CheckBox();
            this.MaxLv_Numeric = new System.Windows.Forms.NumericUpDown();
            this.MinLv_Numeric = new System.Windows.Forms.NumericUpDown();
            this.maxLvlLabel = new System.Windows.Forms.Label();
            this.minLvlLabel = new System.Windows.Forms.Label();
            this.Form_Numeric = new System.Windows.Forms.NumericUpDown();
            this.FormLabel = new System.Windows.Forms.Label();
            this.Pokemon_ComboBox = new System.Windows.Forms.ComboBox();
            this.PokemonLabel = new System.Windows.Forms.Label();
            this.ChanceLabel = new System.Windows.Forms.Label();
            this.EncounterChance_Numeric = new System.Windows.Forms.NumericUpDown();
            this.ValidChancesLabel = new System.Windows.Forms.Label();
            this.ValidInvalidLabel = new System.Windows.Forms.Label();
            this.AddPokemon_Button = new System.Windows.Forms.Button();
            this.DelPokemon_Button = new System.Windows.Forms.Button();
            this.BaseMenu_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapNumber_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapID_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Density_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLv_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinLv_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncounterChance_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseMenu_Menu
            // 
            this.BaseMenu_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Generate_Menu,
            this.Open_Menu,
            this.Compile_Menu,
            this.Sort_Menu});
            this.BaseMenu_Menu.Location = new System.Drawing.Point(0, 0);
            this.BaseMenu_Menu.Name = "BaseMenu_Menu";
            this.BaseMenu_Menu.Size = new System.Drawing.Size(615, 24);
            this.BaseMenu_Menu.TabIndex = 0;
            this.BaseMenu_Menu.Text = "menuStrip1";
            // 
            // Generate_Menu
            // 
            this.Generate_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateEncounter_Menu,
            this.GeneratePBS_Menu});
            this.Generate_Menu.Name = "Generate_Menu";
            this.Generate_Menu.Size = new System.Drawing.Size(66, 20);
            this.Generate_Menu.Text = "Generate";
            // 
            // GenerateEncounter_Menu
            // 
            this.GenerateEncounter_Menu.Name = "GenerateEncounter_Menu";
            this.GenerateEncounter_Menu.Size = new System.Drawing.Size(221, 22);
            this.GenerateEncounter_Menu.Text = "Generate Current Encounter";
            this.GenerateEncounter_Menu.Click += new System.EventHandler(this.GenerateEncounter_Menu_Click);
            // 
            // GeneratePBS_Menu
            // 
            this.GeneratePBS_Menu.Name = "GeneratePBS_Menu";
            this.GeneratePBS_Menu.Size = new System.Drawing.Size(221, 22);
            this.GeneratePBS_Menu.Text = "Generate PBS F ile";
            this.GeneratePBS_Menu.Click += new System.EventHandler(this.GeneratePBS_Menu_Click);
            // 
            // Open_Menu
            // 
            this.Open_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenEncounter_Menu,
            this.OpenPBS_Menu});
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(48, 20);
            this.Open_Menu.Text = "Open";
            // 
            // OpenEncounter_Menu
            // 
            this.OpenEncounter_Menu.Name = "OpenEncounter_Menu";
            this.OpenEncounter_Menu.Size = new System.Drawing.Size(217, 22);
            this.OpenEncounter_Menu.Text = "Open Generated Encounter";
            this.OpenEncounter_Menu.Click += new System.EventHandler(this.OpenEncounter_Menu_Click);
            // 
            // OpenPBS_Menu
            // 
            this.OpenPBS_Menu.Name = "OpenPBS_Menu";
            this.OpenPBS_Menu.Size = new System.Drawing.Size(217, 22);
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
            // Sort_Menu
            // 
            this.Sort_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortMap_Menu});
            this.Sort_Menu.Name = "Sort_Menu";
            this.Sort_Menu.Size = new System.Drawing.Size(40, 20);
            this.Sort_Menu.Text = "Sort";
            // 
            // SortMap_Menu
            // 
            this.SortMap_Menu.Name = "SortMap_Menu";
            this.SortMap_Menu.Size = new System.Drawing.Size(180, 22);
            this.SortMap_Menu.Text = "Sort By Map";
            this.SortMap_Menu.Click += new System.EventHandler(this.SortMap_Menu_Click);
            // 
            // DelMap_Button
            // 
            this.DelMap_Button.Location = new System.Drawing.Point(125, 397);
            this.DelMap_Button.Name = "DelMap_Button";
            this.DelMap_Button.Size = new System.Drawing.Size(86, 28);
            this.DelMap_Button.TabIndex = 3;
            this.DelMap_Button.Text = "Del";
            this.DelMap_Button.UseVisualStyleBackColor = true;
            this.DelMap_Button.Click += new System.EventHandler(this.DelMap_Button_Click);
            // 
            // AddMap_Button
            // 
            this.AddMap_Button.Location = new System.Drawing.Point(12, 397);
            this.AddMap_Button.Name = "AddMap_Button";
            this.AddMap_Button.Size = new System.Drawing.Size(86, 28);
            this.AddMap_Button.TabIndex = 2;
            this.AddMap_Button.Text = "Add";
            this.AddMap_Button.UseVisualStyleBackColor = true;
            this.AddMap_Button.Click += new System.EventHandler(this.AddMap_Button_Click);
            // 
            // Map_ListBox
            // 
            this.Map_ListBox.FormattingEnabled = true;
            this.Map_ListBox.ItemHeight = 15;
            this.Map_ListBox.Location = new System.Drawing.Point(12, 27);
            this.Map_ListBox.Name = "Map_ListBox";
            this.Map_ListBox.Size = new System.Drawing.Size(199, 364);
            this.Map_ListBox.TabIndex = 1;
            this.Map_ListBox.SelectedIndexChanged += new System.EventHandler(this.Map_ListBox_SelectedIndexChanged);
            // 
            // MapNumber_Numeric
            // 
            this.MapNumber_Numeric.Location = new System.Drawing.Point(351, 74);
            this.MapNumber_Numeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MapNumber_Numeric.Name = "MapNumber_Numeric";
            this.MapNumber_Numeric.Size = new System.Drawing.Size(56, 23);
            this.MapNumber_Numeric.TabIndex = 5;
            this.MapNumber_Numeric.ValueChanged += new System.EventHandler(this.MapNumber_Numeric_ValueChanged);
            // 
            // MapName_TextBox
            // 
            this.MapName_TextBox.Location = new System.Drawing.Point(227, 45);
            this.MapName_TextBox.Name = "MapName_TextBox";
            this.MapName_TextBox.Size = new System.Drawing.Size(180, 23);
            this.MapName_TextBox.TabIndex = 4;
            this.MapName_TextBox.TextChanged += new System.EventHandler(this.MapName_TextBox_TextChanged);
            // 
            // MapNameLabel
            // 
            this.MapNameLabel.AutoSize = true;
            this.MapNameLabel.Location = new System.Drawing.Point(227, 27);
            this.MapNameLabel.Name = "MapNameLabel";
            this.MapNameLabel.Size = new System.Drawing.Size(66, 15);
            this.MapNameLabel.TabIndex = 88;
            this.MapNameLabel.Text = "Map Name";
            // 
            // MapIDLabel
            // 
            this.MapIDLabel.AutoSize = true;
            this.MapIDLabel.Location = new System.Drawing.Point(227, 105);
            this.MapIDLabel.Name = "MapIDLabel";
            this.MapIDLabel.Size = new System.Drawing.Size(45, 15);
            this.MapIDLabel.TabIndex = 87;
            this.MapIDLabel.Text = "Map ID";
            // 
            // MapNumberLabel
            // 
            this.MapNumberLabel.AutoSize = true;
            this.MapNumberLabel.Location = new System.Drawing.Point(227, 76);
            this.MapNumberLabel.Name = "MapNumberLabel";
            this.MapNumberLabel.Size = new System.Drawing.Size(78, 15);
            this.MapNumberLabel.TabIndex = 91;
            this.MapNumberLabel.Text = "Map Number";
            // 
            // MapID_Numeric
            // 
            this.MapID_Numeric.Location = new System.Drawing.Point(351, 103);
            this.MapID_Numeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.MapID_Numeric.Name = "MapID_Numeric";
            this.MapID_Numeric.Size = new System.Drawing.Size(56, 23);
            this.MapID_Numeric.TabIndex = 6;
            this.MapID_Numeric.ValueChanged += new System.EventHandler(this.MapID_Numeric_ValueChanged);
            // 
            // EncounterType_ComboBox
            // 
            this.EncounterType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncounterType_ComboBox.FormattingEnabled = true;
            this.EncounterType_ComboBox.Location = new System.Drawing.Point(227, 368);
            this.EncounterType_ComboBox.Name = "EncounterType_ComboBox";
            this.EncounterType_ComboBox.Size = new System.Drawing.Size(180, 23);
            this.EncounterType_ComboBox.TabIndex = 10;
            // 
            // DeleteEncType_Button
            // 
            this.DeleteEncType_Button.Location = new System.Drawing.Point(321, 334);
            this.DeleteEncType_Button.Name = "DeleteEncType_Button";
            this.DeleteEncType_Button.Size = new System.Drawing.Size(86, 28);
            this.DeleteEncType_Button.TabIndex = 9;
            this.DeleteEncType_Button.Text = "Del";
            this.DeleteEncType_Button.UseVisualStyleBackColor = true;
            this.DeleteEncType_Button.Click += new System.EventHandler(this.DeleteEncType_Button_Click);
            // 
            // AddEncType_Button
            // 
            this.AddEncType_Button.Location = new System.Drawing.Point(227, 334);
            this.AddEncType_Button.Name = "AddEncType_Button";
            this.AddEncType_Button.Size = new System.Drawing.Size(86, 28);
            this.AddEncType_Button.TabIndex = 8;
            this.AddEncType_Button.Text = "Add";
            this.AddEncType_Button.UseVisualStyleBackColor = true;
            this.AddEncType_Button.Click += new System.EventHandler(this.AddEncType_Button_Click);
            // 
            // EncTypes_ListBox
            // 
            this.EncTypes_ListBox.FormattingEnabled = true;
            this.EncTypes_ListBox.ItemHeight = 15;
            this.EncTypes_ListBox.Location = new System.Drawing.Point(227, 159);
            this.EncTypes_ListBox.Name = "EncTypes_ListBox";
            this.EncTypes_ListBox.Size = new System.Drawing.Size(180, 169);
            this.EncTypes_ListBox.TabIndex = 7;
            this.EncTypes_ListBox.SelectedIndexChanged += new System.EventHandler(this.EncTypes_ListBox_SelectedIndexChanged);
            // 
            // EncounterTypesLabel
            // 
            this.EncounterTypesLabel.AutoSize = true;
            this.EncounterTypesLabel.Location = new System.Drawing.Point(227, 141);
            this.EncounterTypesLabel.Name = "EncounterTypesLabel";
            this.EncounterTypesLabel.Size = new System.Drawing.Size(93, 15);
            this.EncounterTypesLabel.TabIndex = 93;
            this.EncounterTypesLabel.Text = "Encounter Types";
            // 
            // Density_Numeric
            // 
            this.Density_Numeric.Location = new System.Drawing.Point(351, 402);
            this.Density_Numeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.Density_Numeric.Name = "Density_Numeric";
            this.Density_Numeric.Size = new System.Drawing.Size(56, 23);
            this.Density_Numeric.TabIndex = 11;
            this.Density_Numeric.ValueChanged += new System.EventHandler(this.Density_Numeric_ValueChanged);
            // 
            // EncounterDensityLabel
            // 
            this.EncounterDensityLabel.AutoSize = true;
            this.EncounterDensityLabel.Location = new System.Drawing.Point(227, 404);
            this.EncounterDensityLabel.Name = "EncounterDensityLabel";
            this.EncounterDensityLabel.Size = new System.Drawing.Size(103, 15);
            this.EncounterDensityLabel.TabIndex = 99;
            this.EncounterDensityLabel.Text = "Encounter Density";
            // 
            // Encounters_ListBox
            // 
            this.Encounters_ListBox.FormattingEnabled = true;
            this.Encounters_ListBox.ItemHeight = 15;
            this.Encounters_ListBox.Location = new System.Drawing.Point(423, 79);
            this.Encounters_ListBox.Name = "Encounters_ListBox";
            this.Encounters_ListBox.Size = new System.Drawing.Size(180, 154);
            this.Encounters_ListBox.TabIndex = 14;
            this.Encounters_ListBox.SelectedIndexChanged += new System.EventHandler(this.Encounters_ListBox_SelectedIndexChanged);
            // 
            // EncountersLabel
            // 
            this.EncountersLabel.AutoSize = true;
            this.EncountersLabel.Location = new System.Drawing.Point(423, 27);
            this.EncountersLabel.Name = "EncountersLabel";
            this.EncountersLabel.Size = new System.Drawing.Size(66, 15);
            this.EncountersLabel.TabIndex = 100;
            this.EncountersLabel.Text = "Encounters";
            // 
            // MaxLvlCheckBox
            // 
            this.MaxLvlCheckBox.AutoSize = true;
            this.MaxLvlCheckBox.Location = new System.Drawing.Point(501, 342);
            this.MaxLvlCheckBox.Name = "MaxLvlCheckBox";
            this.MaxLvlCheckBox.Size = new System.Drawing.Size(40, 19);
            this.MaxLvlCheckBox.TabIndex = 19;
            this.MaxLvlCheckBox.Text = "All";
            this.MaxLvlCheckBox.UseVisualStyleBackColor = true;
            // 
            // minLvlCheckBox
            // 
            this.minLvlCheckBox.AutoSize = true;
            this.minLvlCheckBox.Location = new System.Drawing.Point(501, 313);
            this.minLvlCheckBox.Name = "minLvlCheckBox";
            this.minLvlCheckBox.Size = new System.Drawing.Size(40, 19);
            this.minLvlCheckBox.TabIndex = 17;
            this.minLvlCheckBox.Text = "All";
            this.minLvlCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaxLv_Numeric
            // 
            this.MaxLv_Numeric.Location = new System.Drawing.Point(547, 341);
            this.MaxLv_Numeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MaxLv_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxLv_Numeric.Name = "MaxLv_Numeric";
            this.MaxLv_Numeric.Size = new System.Drawing.Size(56, 23);
            this.MaxLv_Numeric.TabIndex = 20;
            this.MaxLv_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxLv_Numeric.ValueChanged += new System.EventHandler(this.MaxLv_Numeric_ValueChanged);
            // 
            // MinLv_Numeric
            // 
            this.MinLv_Numeric.Location = new System.Drawing.Point(547, 312);
            this.MinLv_Numeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MinLv_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinLv_Numeric.Name = "MinLv_Numeric";
            this.MinLv_Numeric.Size = new System.Drawing.Size(56, 23);
            this.MinLv_Numeric.TabIndex = 18;
            this.MinLv_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinLv_Numeric.ValueChanged += new System.EventHandler(this.MinLv_Numeric_ValueChanged);
            // 
            // maxLvlLabel
            // 
            this.maxLvlLabel.AutoSize = true;
            this.maxLvlLabel.Location = new System.Drawing.Point(423, 343);
            this.maxLvlLabel.Name = "maxLvlLabel";
            this.maxLvlLabel.Size = new System.Drawing.Size(44, 15);
            this.maxLvlLabel.TabIndex = 108;
            this.maxLvlLabel.Text = "MaxLvl";
            // 
            // minLvlLabel
            // 
            this.minLvlLabel.AutoSize = true;
            this.minLvlLabel.Location = new System.Drawing.Point(423, 314);
            this.minLvlLabel.Name = "minLvlLabel";
            this.minLvlLabel.Size = new System.Drawing.Size(42, 15);
            this.minLvlLabel.TabIndex = 107;
            this.minLvlLabel.Text = "MinLvl";
            // 
            // Form_Numeric
            // 
            this.Form_Numeric.Location = new System.Drawing.Point(547, 283);
            this.Form_Numeric.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Form_Numeric.Name = "Form_Numeric";
            this.Form_Numeric.Size = new System.Drawing.Size(56, 23);
            this.Form_Numeric.TabIndex = 16;
            this.Form_Numeric.ValueChanged += new System.EventHandler(this.Form_Numeric_ValueChanged);
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Location = new System.Drawing.Point(423, 285);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(35, 15);
            this.FormLabel.TabIndex = 105;
            this.FormLabel.Text = "Form";
            // 
            // Pokemon_ComboBox
            // 
            this.Pokemon_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Pokemon_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Pokemon_ComboBox.FormattingEnabled = true;
            this.Pokemon_ComboBox.Location = new System.Drawing.Point(423, 254);
            this.Pokemon_ComboBox.Name = "Pokemon_ComboBox";
            this.Pokemon_ComboBox.Size = new System.Drawing.Size(180, 23);
            this.Pokemon_ComboBox.TabIndex = 15;
            this.Pokemon_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Pokemon_ComboBox_SelectedIndexChanged);
            // 
            // PokemonLabel
            // 
            this.PokemonLabel.AutoSize = true;
            this.PokemonLabel.Location = new System.Drawing.Point(423, 236);
            this.PokemonLabel.Name = "PokemonLabel";
            this.PokemonLabel.Size = new System.Drawing.Size(58, 15);
            this.PokemonLabel.TabIndex = 103;
            this.PokemonLabel.Text = "Pokemon";
            // 
            // ChanceLabel
            // 
            this.ChanceLabel.AutoSize = true;
            this.ChanceLabel.Location = new System.Drawing.Point(423, 372);
            this.ChanceLabel.Name = "ChanceLabel";
            this.ChanceLabel.Size = new System.Drawing.Size(47, 15);
            this.ChanceLabel.TabIndex = 113;
            this.ChanceLabel.Text = "Chance";
            // 
            // EncounterChance_Numeric
            // 
            this.EncounterChance_Numeric.Location = new System.Drawing.Point(547, 370);
            this.EncounterChance_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EncounterChance_Numeric.Name = "EncounterChance_Numeric";
            this.EncounterChance_Numeric.Size = new System.Drawing.Size(56, 23);
            this.EncounterChance_Numeric.TabIndex = 21;
            this.EncounterChance_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EncounterChance_Numeric.ValueChanged += new System.EventHandler(this.EncounterChance_Numeric_ValueChanged);
            // 
            // ValidChancesLabel
            // 
            this.ValidChancesLabel.AutoSize = true;
            this.ValidChancesLabel.Location = new System.Drawing.Point(423, 405);
            this.ValidChancesLabel.Name = "ValidChancesLabel";
            this.ValidChancesLabel.Size = new System.Drawing.Size(96, 15);
            this.ValidChancesLabel.TabIndex = 115;
            this.ValidChancesLabel.Text = "% Chances Total:";
            // 
            // ValidInvalidLabel
            // 
            this.ValidInvalidLabel.AutoSize = true;
            this.ValidInvalidLabel.Location = new System.Drawing.Point(525, 404);
            this.ValidInvalidLabel.Name = "ValidInvalidLabel";
            this.ValidInvalidLabel.Size = new System.Drawing.Size(32, 15);
            this.ValidInvalidLabel.TabIndex = 116;
            this.ValidInvalidLabel.Text = "Valid";
            // 
            // AddPokemon_Button
            // 
            this.AddPokemon_Button.Location = new System.Drawing.Point(423, 45);
            this.AddPokemon_Button.Name = "AddPokemon_Button";
            this.AddPokemon_Button.Size = new System.Drawing.Size(86, 28);
            this.AddPokemon_Button.TabIndex = 12;
            this.AddPokemon_Button.Text = "Add";
            this.AddPokemon_Button.UseVisualStyleBackColor = true;
            this.AddPokemon_Button.Click += new System.EventHandler(this.AddPokemon_Button_Click);
            // 
            // DelPokemon_Button
            // 
            this.DelPokemon_Button.Location = new System.Drawing.Point(517, 45);
            this.DelPokemon_Button.Name = "DelPokemon_Button";
            this.DelPokemon_Button.Size = new System.Drawing.Size(86, 28);
            this.DelPokemon_Button.TabIndex = 13;
            this.DelPokemon_Button.Text = "Del";
            this.DelPokemon_Button.UseVisualStyleBackColor = true;
            this.DelPokemon_Button.Click += new System.EventHandler(this.DelPokemon_Button_Click);
            // 
            // Form_Encounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 436);
            this.Controls.Add(this.DelPokemon_Button);
            this.Controls.Add(this.AddPokemon_Button);
            this.Controls.Add(this.ValidInvalidLabel);
            this.Controls.Add(this.ValidChancesLabel);
            this.Controls.Add(this.EncounterChance_Numeric);
            this.Controls.Add(this.ChanceLabel);
            this.Controls.Add(this.MaxLvlCheckBox);
            this.Controls.Add(this.minLvlCheckBox);
            this.Controls.Add(this.MaxLv_Numeric);
            this.Controls.Add(this.MinLv_Numeric);
            this.Controls.Add(this.maxLvlLabel);
            this.Controls.Add(this.minLvlLabel);
            this.Controls.Add(this.Form_Numeric);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.Pokemon_ComboBox);
            this.Controls.Add(this.PokemonLabel);
            this.Controls.Add(this.Encounters_ListBox);
            this.Controls.Add(this.EncountersLabel);
            this.Controls.Add(this.EncounterDensityLabel);
            this.Controls.Add(this.Density_Numeric);
            this.Controls.Add(this.EncounterType_ComboBox);
            this.Controls.Add(this.DeleteEncType_Button);
            this.Controls.Add(this.AddEncType_Button);
            this.Controls.Add(this.EncTypes_ListBox);
            this.Controls.Add(this.EncounterTypesLabel);
            this.Controls.Add(this.MapID_Numeric);
            this.Controls.Add(this.MapNumberLabel);
            this.Controls.Add(this.MapNumber_Numeric);
            this.Controls.Add(this.MapName_TextBox);
            this.Controls.Add(this.MapNameLabel);
            this.Controls.Add(this.MapIDLabel);
            this.Controls.Add(this.DelMap_Button);
            this.Controls.Add(this.AddMap_Button);
            this.Controls.Add(this.Map_ListBox);
            this.Controls.Add(this.BaseMenu_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.BaseMenu_Menu;
            this.MaximizeBox = false;
            this.Name = "Form_Encounters";
            this.ShowIcon = false;
            this.Text = "Edit Encounters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Encounters_FormClosing);
            this.BaseMenu_Menu.ResumeLayout(false);
            this.BaseMenu_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapNumber_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapID_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Density_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLv_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinLv_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncounterChance_Numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseMenu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Generate_Menu;
        private System.Windows.Forms.Button DelMap_Button;
        private System.Windows.Forms.Button AddMap_Button;
        private System.Windows.Forms.ListBox Map_ListBox;
        private System.Windows.Forms.NumericUpDown MapNumber_Numeric;
        private System.Windows.Forms.TextBox MapName_TextBox;
        private System.Windows.Forms.Label MapNameLabel;
        private System.Windows.Forms.Label MapIDLabel;
        private System.Windows.Forms.Label MapNumberLabel;
        private System.Windows.Forms.NumericUpDown MapID_Numeric;
        private System.Windows.Forms.ComboBox EncounterType_ComboBox;
        private System.Windows.Forms.Button DeleteEncType_Button;
        private System.Windows.Forms.Button AddEncType_Button;
        private System.Windows.Forms.ListBox EncTypes_ListBox;
        private System.Windows.Forms.Label EncounterTypesLabel;
        private System.Windows.Forms.NumericUpDown Density_Numeric;
        private System.Windows.Forms.Label EncounterDensityLabel;
        private System.Windows.Forms.ListBox Encounters_ListBox;
        private System.Windows.Forms.Label EncountersLabel;
        private System.Windows.Forms.CheckBox MaxLvlCheckBox;
        private System.Windows.Forms.CheckBox minLvlCheckBox;
        private System.Windows.Forms.NumericUpDown MaxLv_Numeric;
        private System.Windows.Forms.NumericUpDown MinLv_Numeric;
        private System.Windows.Forms.Label maxLvlLabel;
        private System.Windows.Forms.Label minLvlLabel;
        private System.Windows.Forms.NumericUpDown Form_Numeric;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.ComboBox Pokemon_ComboBox;
        private System.Windows.Forms.Label PokemonLabel;
        private System.Windows.Forms.Label ChanceLabel;
        private System.Windows.Forms.NumericUpDown EncounterChance_Numeric;
        private System.Windows.Forms.Label ValidChancesLabel;
        private System.Windows.Forms.Label ValidInvalidLabel;
        private System.Windows.Forms.Button AddPokemon_Button;
        private System.Windows.Forms.Button DelPokemon_Button;
        private System.Windows.Forms.ToolStripMenuItem GenerateEncounter_Menu;
        private System.Windows.Forms.ToolStripMenuItem GeneratePBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Open_Menu;
        private System.Windows.Forms.ToolStripMenuItem Compile_Menu;
        private System.Windows.Forms.ToolStripMenuItem CompileChanges_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenEncounter_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenPBS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Sort_Menu;
        private System.Windows.Forms.ToolStripMenuItem SortMap_Menu;
    }
}