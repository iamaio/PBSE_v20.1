
namespace PBSE_3
{
    partial class StartUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUI));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_Compile = new System.Windows.Forms.Button();
            this.button_Backup = new System.Windows.Forms.Button();
            this.label_CompilationStatus = new System.Windows.Forms.Label();
            this.button_EditPBS = new System.Windows.Forms.Button();
            this.comboBox_PBS = new System.Windows.Forms.ComboBox();
            this.button_OpenErrorLog = new System.Windows.Forms.Button();
            this.textBox_Backup = new System.Windows.Forms.TextBox();
            this.label_BackupStatus = new System.Windows.Forms.Label();
            this.label_Disclaimer = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_ButtonPanel, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.label_Disclaimer, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 2;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(574, 273);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_ButtonPanel
            // 
            this.tableLayoutPanel_ButtonPanel.ColumnCount = 3;
            this.tableLayoutPanel_ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.button_Compile, 0, 0);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.button_Backup, 1, 0);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.label_CompilationStatus, 0, 1);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.button_EditPBS, 2, 0);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.comboBox_PBS, 2, 1);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.button_OpenErrorLog, 0, 2);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.textBox_Backup, 1, 1);
            this.tableLayoutPanel_ButtonPanel.Controls.Add(this.label_BackupStatus, 1, 2);
            this.tableLayoutPanel_ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ButtonPanel.Name = "tableLayoutPanel_ButtonPanel";
            this.tableLayoutPanel_ButtonPanel.RowCount = 3;
            this.tableLayoutPanel_ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel_ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_ButtonPanel.Size = new System.Drawing.Size(568, 159);
            this.tableLayoutPanel_ButtonPanel.TabIndex = 0;
            // 
            // button_Compile
            // 
            this.button_Compile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Compile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Compile.Location = new System.Drawing.Point(3, 13);
            this.button_Compile.Name = "button_Compile";
            this.button_Compile.Size = new System.Drawing.Size(183, 54);
            this.button_Compile.TabIndex = 1;
            this.button_Compile.Text = "Compile";
            this.button_Compile.UseVisualStyleBackColor = true;
            this.button_Compile.Click += new System.EventHandler(this.Compile_Button_Click);
            // 
            // button_Backup
            // 
            this.button_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Backup.Enabled = false;
            this.button_Backup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Backup.Location = new System.Drawing.Point(192, 13);
            this.button_Backup.Name = "button_Backup";
            this.button_Backup.Size = new System.Drawing.Size(183, 54);
            this.button_Backup.TabIndex = 2;
            this.button_Backup.Text = "Backup";
            this.button_Backup.UseVisualStyleBackColor = true;
            this.button_Backup.Click += new System.EventHandler(this.Backup_Button_Click);
            // 
            // label_CompilationStatus
            // 
            this.label_CompilationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CompilationStatus.AutoSize = true;
            this.label_CompilationStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_CompilationStatus.Location = new System.Drawing.Point(3, 89);
            this.label_CompilationStatus.Name = "label_CompilationStatus";
            this.label_CompilationStatus.Size = new System.Drawing.Size(183, 21);
            this.label_CompilationStatus.TabIndex = 0;
            this.label_CompilationStatus.Text = "Status - Pending";
            // 
            // button_EditPBS
            // 
            this.button_EditPBS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_EditPBS.Enabled = false;
            this.button_EditPBS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_EditPBS.Location = new System.Drawing.Point(381, 13);
            this.button_EditPBS.Name = "button_EditPBS";
            this.button_EditPBS.Size = new System.Drawing.Size(184, 54);
            this.button_EditPBS.TabIndex = 3;
            this.button_EditPBS.Text = "Edit PBS";
            this.button_EditPBS.UseVisualStyleBackColor = true;
            this.button_EditPBS.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // comboBox_PBS
            // 
            this.comboBox_PBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_PBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PBS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_PBS.FormattingEnabled = true;
            this.comboBox_PBS.IntegralHeight = false;
            this.comboBox_PBS.Items.AddRange(new object[] {
            "Pokemon",
            "Pokemon Forms",
            "Types",
            "Abilities",
            "Moves",
            "Items",
            "Trainer Types",
            "Trainers",
            "Encounters"});
            this.comboBox_PBS.Location = new System.Drawing.Point(381, 83);
            this.comboBox_PBS.Name = "comboBox_PBS";
            this.comboBox_PBS.Size = new System.Drawing.Size(184, 29);
            this.comboBox_PBS.TabIndex = 6;
            this.comboBox_PBS.Visible = false;
            // 
            // button_OpenErrorLog
            // 
            this.button_OpenErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OpenErrorLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_OpenErrorLog.Location = new System.Drawing.Point(3, 123);
            this.button_OpenErrorLog.Name = "button_OpenErrorLog";
            this.button_OpenErrorLog.Size = new System.Drawing.Size(183, 29);
            this.button_OpenErrorLog.TabIndex = 5;
            this.button_OpenErrorLog.Text = "Open Error Log";
            this.button_OpenErrorLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OpenErrorLog.UseVisualStyleBackColor = true;
            this.button_OpenErrorLog.Visible = false;
            this.button_OpenErrorLog.Click += new System.EventHandler(this.OpenErrorLog_Button_Click);
            // 
            // textBox_Backup
            // 
            this.textBox_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Backup.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Backup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Backup.Location = new System.Drawing.Point(192, 83);
            this.textBox_Backup.Name = "textBox_Backup";
            this.textBox_Backup.Size = new System.Drawing.Size(183, 29);
            this.textBox_Backup.TabIndex = 4;
            this.textBox_Backup.Visible = false;
            // 
            // label_BackupStatus
            // 
            this.label_BackupStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_BackupStatus.AutoSize = true;
            this.label_BackupStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BackupStatus.Location = new System.Drawing.Point(192, 129);
            this.label_BackupStatus.Name = "label_BackupStatus";
            this.label_BackupStatus.Size = new System.Drawing.Size(183, 21);
            this.label_BackupStatus.TabIndex = 0;
            this.label_BackupStatus.Visible = false;
            // 
            // label_Disclaimer
            // 
            this.label_Disclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Disclaimer.AutoSize = true;
            this.label_Disclaimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Disclaimer.Location = new System.Drawing.Point(3, 165);
            this.label_Disclaimer.Name = "label_Disclaimer";
            this.label_Disclaimer.Size = new System.Drawing.Size(568, 102);
            this.label_Disclaimer.TabIndex = 0;
            this.label_Disclaimer.Text = resources.GetString("label_Disclaimer.Text");
            // 
            // StartUI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 273);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartUI";
            this.ShowIcon = false;
            this.Text = "PBS Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartUI_FormClosing);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.tableLayoutPanel_ButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel_ButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ButtonPanel;
        private System.Windows.Forms.Button button_Compile;
        private System.Windows.Forms.Button button_Backup;
        private System.Windows.Forms.Label label_CompilationStatus;
        private System.Windows.Forms.Button button_EditPBS;
        private System.Windows.Forms.ComboBox comboBox_PBS;
        private System.Windows.Forms.Button button_OpenErrorLog;
        private System.Windows.Forms.TextBox textBox_Backup;
        private System.Windows.Forms.Label label_Disclaimer;
        private System.Windows.Forms.Label label_BackupStatus;
    }
}

