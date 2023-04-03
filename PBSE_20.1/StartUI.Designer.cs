
namespace PBSE_2
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
            this.Base_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Main_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Compile_Button = new System.Windows.Forms.Button();
            this.Backup_Button = new System.Windows.Forms.Button();
            this.CompilationStatus_Label = new System.Windows.Forms.Label();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.PBS_ComboBox = new System.Windows.Forms.ComboBox();
            this.OpenBackup_Button = new System.Windows.Forms.Button();
            this.OpenErrorLog_Button = new System.Windows.Forms.Button();
            this.Backup_TextBox = new System.Windows.Forms.TextBox();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.Base_TableLayout.SuspendLayout();
            this.Main_TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Base_TableLayout
            // 
            this.Base_TableLayout.ColumnCount = 1;
            this.Base_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Base_TableLayout.Controls.Add(this.Main_TableLayout, 0, 0);
            this.Base_TableLayout.Controls.Add(this.DisclaimerLabel, 0, 1);
            this.Base_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_TableLayout.Location = new System.Drawing.Point(0, 0);
            this.Base_TableLayout.Name = "Base_TableLayout";
            this.Base_TableLayout.RowCount = 2;
            this.Base_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.Base_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Base_TableLayout.Size = new System.Drawing.Size(574, 214);
            this.Base_TableLayout.TabIndex = 0;
            // 
            // Main_TableLayout
            // 
            this.Main_TableLayout.ColumnCount = 3;
            this.Main_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Main_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Main_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Main_TableLayout.Controls.Add(this.Compile_Button, 0, 0);
            this.Main_TableLayout.Controls.Add(this.Backup_Button, 1, 0);
            this.Main_TableLayout.Controls.Add(this.CompilationStatus_Label, 0, 1);
            this.Main_TableLayout.Controls.Add(this.Edit_Button, 2, 0);
            this.Main_TableLayout.Controls.Add(this.PBS_ComboBox, 2, 1);
            this.Main_TableLayout.Controls.Add(this.OpenBackup_Button, 1, 2);
            this.Main_TableLayout.Controls.Add(this.OpenErrorLog_Button, 0, 2);
            this.Main_TableLayout.Controls.Add(this.Backup_TextBox, 1, 1);
            this.Main_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_TableLayout.Location = new System.Drawing.Point(3, 3);
            this.Main_TableLayout.Name = "Main_TableLayout";
            this.Main_TableLayout.RowCount = 3;
            this.Main_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Main_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Main_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Main_TableLayout.Size = new System.Drawing.Size(568, 159);
            this.Main_TableLayout.TabIndex = 2;
            // 
            // Compile_Button
            // 
            this.Compile_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Compile_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Compile_Button.Location = new System.Drawing.Point(3, 13);
            this.Compile_Button.Name = "Compile_Button";
            this.Compile_Button.Size = new System.Drawing.Size(183, 54);
            this.Compile_Button.TabIndex = 1;
            this.Compile_Button.Text = "Compile";
            this.Compile_Button.UseVisualStyleBackColor = true;
            // 
            // Backup_Button
            // 
            this.Backup_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Backup_Button.Enabled = false;
            this.Backup_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backup_Button.Location = new System.Drawing.Point(192, 13);
            this.Backup_Button.Name = "Backup_Button";
            this.Backup_Button.Size = new System.Drawing.Size(183, 54);
            this.Backup_Button.TabIndex = 2;
            this.Backup_Button.Text = "Backup";
            this.Backup_Button.UseVisualStyleBackColor = true;
            // 
            // CompilationStatus_Label
            // 
            this.CompilationStatus_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CompilationStatus_Label.AutoSize = true;
            this.CompilationStatus_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompilationStatus_Label.Location = new System.Drawing.Point(3, 89);
            this.CompilationStatus_Label.Name = "CompilationStatus_Label";
            this.CompilationStatus_Label.Size = new System.Drawing.Size(183, 21);
            this.CompilationStatus_Label.TabIndex = 7;
            this.CompilationStatus_Label.Text = "Status - Pending";
            // 
            // Edit_Button
            // 
            this.Edit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_Button.Enabled = false;
            this.Edit_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_Button.Location = new System.Drawing.Point(381, 13);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(184, 54);
            this.Edit_Button.TabIndex = 10;
            this.Edit_Button.Text = "Edit PBS";
            this.Edit_Button.UseVisualStyleBackColor = true;
            // 
            // PBS_ComboBox
            // 
            this.PBS_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBS_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PBS_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PBS_ComboBox.FormattingEnabled = true;
            this.PBS_ComboBox.IntegralHeight = false;
            this.PBS_ComboBox.Items.AddRange(new object[] {
            "Pokemon",
            "Pokemon Forms",
            "Types",
            "Abilities",
            "Moves",
            "Items",
            "Trainer Types",
            "Trainers",
            "Encounters"});
            this.PBS_ComboBox.Location = new System.Drawing.Point(381, 83);
            this.PBS_ComboBox.Name = "PBS_ComboBox";
            this.PBS_ComboBox.Size = new System.Drawing.Size(184, 29);
            this.PBS_ComboBox.TabIndex = 11;
            this.PBS_ComboBox.Visible = false;
            // 
            // OpenBackup_Button
            // 
            this.OpenBackup_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenBackup_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenBackup_Button.Location = new System.Drawing.Point(192, 123);
            this.OpenBackup_Button.Name = "OpenBackup_Button";
            this.OpenBackup_Button.Size = new System.Drawing.Size(183, 29);
            this.OpenBackup_Button.TabIndex = 6;
            this.OpenBackup_Button.Text = "Open Backup Folder";
            this.OpenBackup_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenBackup_Button.UseVisualStyleBackColor = true;
            this.OpenBackup_Button.Visible = false;
            // 
            // OpenErrorLog_Button
            // 
            this.OpenErrorLog_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenErrorLog_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenErrorLog_Button.Location = new System.Drawing.Point(3, 123);
            this.OpenErrorLog_Button.Name = "OpenErrorLog_Button";
            this.OpenErrorLog_Button.Size = new System.Drawing.Size(183, 29);
            this.OpenErrorLog_Button.TabIndex = 8;
            this.OpenErrorLog_Button.Text = "Open Error Log";
            this.OpenErrorLog_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenErrorLog_Button.UseVisualStyleBackColor = true;
            this.OpenErrorLog_Button.Visible = false;
            // 
            // Backup_TextBox
            // 
            this.Backup_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backup_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Backup_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Backup_TextBox.Location = new System.Drawing.Point(192, 83);
            this.Backup_TextBox.Name = "Backup_TextBox";
            this.Backup_TextBox.Size = new System.Drawing.Size(183, 29);
            this.Backup_TextBox.TabIndex = 9;
            this.Backup_TextBox.Visible = false;
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisclaimerLabel.Location = new System.Drawing.Point(3, 165);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(568, 34);
            this.DisclaimerLabel.TabIndex = 3;
            this.DisclaimerLabel.Text = "After compiling, any change you make will stay active even if you don\'t replace t" +
    "he PBS file, if you want to revert any changes make sure you close this window a" +
    "nd restart the PBS Editor.";
            // 
            // StartUI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 214);
            this.Controls.Add(this.Base_TableLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartUI";
            this.Text = "PBS Editor";
            this.Base_TableLayout.ResumeLayout(false);
            this.Base_TableLayout.PerformLayout();
            this.Main_TableLayout.ResumeLayout(false);
            this.Main_TableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel Base_TableLayout;
        private System.Windows.Forms.TableLayoutPanel Main_TableLayout;
        private System.Windows.Forms.Button Compile_Button;
        private System.Windows.Forms.Button Backup_Button;
        private System.Windows.Forms.Label CompilationStatus_Label;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.ComboBox PBS_ComboBox;
        private System.Windows.Forms.Button OpenBackup_Button;
        private System.Windows.Forms.Button OpenErrorLog_Button;
        private System.Windows.Forms.TextBox Backup_TextBox;
        private System.Windows.Forms.Label DisclaimerLabel;
    }
}

