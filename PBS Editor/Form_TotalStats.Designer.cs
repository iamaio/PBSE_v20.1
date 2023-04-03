
namespace PBS_Editor
{
    partial class Form_TotalStats
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
            this.Pokemon_ListBox = new System.Windows.Forms.ListBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pokemon_ListBox
            // 
            this.Pokemon_ListBox.FormattingEnabled = true;
            this.Pokemon_ListBox.ItemHeight = 15;
            this.Pokemon_ListBox.Location = new System.Drawing.Point(12, 12);
            this.Pokemon_ListBox.Name = "Pokemon_ListBox";
            this.Pokemon_ListBox.Size = new System.Drawing.Size(198, 244);
            this.Pokemon_ListBox.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 259);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(198, 38);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // Form_TotalStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(223, 302);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Pokemon_ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_TotalStats";
            this.ShowIcon = false;
            this.Text = "Total Stats";
            this.Load += new System.EventHandler(this.Form_TotalStats_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Pokemon_ListBox;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}