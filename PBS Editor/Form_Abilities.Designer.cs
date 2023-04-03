
namespace PBS_Editor
{
    partial class Form_Abilities
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
            this.menu_BaseMenu = new System.Windows.Forms.MenuStrip();
            this.menu_Generate = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_GenerateAbility = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_GeneratePBS = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenAbility = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OpenPBS = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CompileChanges = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Abilities = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_InternalName = new System.Windows.Forms.TextBox();
            this.label_InternalName = new System.Windows.Forms.Label();
            this.label_Flags = new System.Windows.Forms.Label();
            this.textBox_Flags = new System.Windows.Forms.TextBox();
            this.menu_BaseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_BaseMenu
            // 
            this.menu_BaseMenu.BackColor = System.Drawing.Color.White;
            this.menu_BaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Generate,
            this.menu_Open,
            this.menu_Compile});
            this.menu_BaseMenu.Location = new System.Drawing.Point(0, 0);
            this.menu_BaseMenu.Name = "menu_BaseMenu";
            this.menu_BaseMenu.Size = new System.Drawing.Size(429, 24);
            this.menu_BaseMenu.TabIndex = 0;
            this.menu_BaseMenu.Text = "menuStrip1";
            // 
            // menu_Generate
            // 
            this.menu_Generate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_GenerateAbility,
            this.menu_GeneratePBS});
            this.menu_Generate.Name = "menu_Generate";
            this.menu_Generate.Size = new System.Drawing.Size(66, 20);
            this.menu_Generate.Text = "Generate";
            // 
            // menu_GenerateAbility
            // 
            this.menu_GenerateAbility.Name = "menu_GenerateAbility";
            this.menu_GenerateAbility.Size = new System.Drawing.Size(201, 22);
            this.menu_GenerateAbility.Text = "Generate Current Ability";
            this.menu_GenerateAbility.Click += new System.EventHandler(this.GenerateAbility_Menu_Click);
            // 
            // menu_GeneratePBS
            // 
            this.menu_GeneratePBS.Name = "menu_GeneratePBS";
            this.menu_GeneratePBS.Size = new System.Drawing.Size(201, 22);
            this.menu_GeneratePBS.Text = "Generate PBS File";
            this.menu_GeneratePBS.Click += new System.EventHandler(this.GeneratePBS_Menu_Click);
            // 
            // menu_Open
            // 
            this.menu_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_OpenAbility,
            this.menu_OpenPBS});
            this.menu_Open.Name = "menu_Open";
            this.menu_Open.Size = new System.Drawing.Size(48, 20);
            this.menu_Open.Text = "Open";
            // 
            // menu_OpenAbility
            // 
            this.menu_OpenAbility.Name = "menu_OpenAbility";
            this.menu_OpenAbility.Size = new System.Drawing.Size(197, 22);
            this.menu_OpenAbility.Text = "Open Generated Ability";
            this.menu_OpenAbility.Click += new System.EventHandler(this.OpenAbility_Menu_Click);
            // 
            // menu_OpenPBS
            // 
            this.menu_OpenPBS.Name = "menu_OpenPBS";
            this.menu_OpenPBS.Size = new System.Drawing.Size(197, 22);
            this.menu_OpenPBS.Text = "Open Generated PBS";
            this.menu_OpenPBS.Click += new System.EventHandler(this.OpenPBS_Menu_Click);
            // 
            // menu_Compile
            // 
            this.menu_Compile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_CompileChanges});
            this.menu_Compile.Name = "menu_Compile";
            this.menu_Compile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu_Compile.Size = new System.Drawing.Size(64, 20);
            this.menu_Compile.Text = "Compile";
            // 
            // menu_CompileChanges
            // 
            this.menu_CompileChanges.Name = "menu_CompileChanges";
            this.menu_CompileChanges.Size = new System.Drawing.Size(180, 22);
            this.menu_CompileChanges.Text = "Compile Changes";
            this.menu_CompileChanges.Click += new System.EventHandler(this.CompileChanges_Menu_Click);
            // 
            // listBox_Abilities
            // 
            this.listBox_Abilities.FormattingEnabled = true;
            this.listBox_Abilities.ItemHeight = 15;
            this.listBox_Abilities.Location = new System.Drawing.Point(12, 27);
            this.listBox_Abilities.Name = "listBox_Abilities";
            this.listBox_Abilities.Size = new System.Drawing.Size(199, 244);
            this.listBox_Abilities.TabIndex = 1;
            this.listBox_Abilities.SelectedIndexChanged += new System.EventHandler(this.Abilities_ListBox_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 277);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(86, 28);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(125, 277);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 28);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Del";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(227, 177);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(188, 94);
            this.textBox_Description.TabIndex = 7;
            this.textBox_Description.TextChanged += new System.EventHandler(this.Description_TextBox_TextChanged);
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(227, 159);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(67, 15);
            this.label_Description.TabIndex = 149;
            this.label_Description.Text = "Description";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(227, 89);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(188, 23);
            this.textBox_Name.TabIndex = 5;
            this.textBox_Name.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(227, 71);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 15);
            this.label_Name.TabIndex = 147;
            this.label_Name.Text = "Name";
            // 
            // textBox_InternalName
            // 
            this.textBox_InternalName.Location = new System.Drawing.Point(227, 45);
            this.textBox_InternalName.Name = "textBox_InternalName";
            this.textBox_InternalName.Size = new System.Drawing.Size(188, 23);
            this.textBox_InternalName.TabIndex = 4;
            this.textBox_InternalName.TextChanged += new System.EventHandler(this.InternalName_TextBox_TextChanged);
            // 
            // label_InternalName
            // 
            this.label_InternalName.AutoSize = true;
            this.label_InternalName.Location = new System.Drawing.Point(227, 27);
            this.label_InternalName.Name = "label_InternalName";
            this.label_InternalName.Size = new System.Drawing.Size(18, 15);
            this.label_InternalName.TabIndex = 145;
            this.label_InternalName.Text = "ID";
            // 
            // label_Flags
            // 
            this.label_Flags.AutoSize = true;
            this.label_Flags.Location = new System.Drawing.Point(228, 115);
            this.label_Flags.Name = "label_Flags";
            this.label_Flags.Size = new System.Drawing.Size(34, 15);
            this.label_Flags.TabIndex = 151;
            this.label_Flags.Text = "Flags";
            // 
            // textBox_Flags
            // 
            this.textBox_Flags.Location = new System.Drawing.Point(227, 133);
            this.textBox_Flags.Name = "textBox_Flags";
            this.textBox_Flags.Size = new System.Drawing.Size(188, 23);
            this.textBox_Flags.TabIndex = 6;
            this.textBox_Flags.TextChanged += new System.EventHandler(this.TextBox_Flags_TextChanged);
            // 
            // Form_Abilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 309);
            this.Controls.Add(this.textBox_Flags);
            this.Controls.Add(this.label_Flags);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_InternalName);
            this.Controls.Add(this.label_InternalName);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.listBox_Abilities);
            this.Controls.Add(this.menu_BaseMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu_BaseMenu;
            this.MaximizeBox = false;
            this.Name = "Form_Abilities";
            this.ShowIcon = false;
            this.Text = "Edit Abilities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Abilities_FormClosing);
            this.menu_BaseMenu.ResumeLayout(false);
            this.menu_BaseMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_BaseMenu;
        private System.Windows.Forms.ToolStripMenuItem menu_Generate;
        private System.Windows.Forms.ListBox listBox_Abilities;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_InternalName;
        private System.Windows.Forms.Label label_InternalName;
        private System.Windows.Forms.ToolStripMenuItem menu_GenerateAbility;
        private System.Windows.Forms.ToolStripMenuItem menu_GeneratePBS;
        private System.Windows.Forms.ToolStripMenuItem menu_Open;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenAbility;
        private System.Windows.Forms.ToolStripMenuItem menu_OpenPBS;
        private System.Windows.Forms.ToolStripMenuItem menu_Compile;
        private System.Windows.Forms.ToolStripMenuItem menu_CompileChanges;
        private System.Windows.Forms.Label label_Flags;
        private System.Windows.Forms.TextBox textBox_Flags;
    }
}