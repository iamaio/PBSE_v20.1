using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBSELibrary;

namespace PBS_Editor
{
    public partial class Form_TotalStats : Form
    {
        public Form_TotalStats(int TotalStats)
        {
            InitializeComponent();
            UpdateInformation(TotalStats);
        }
        private void UpdateInformation(int TotalStats)
        {
            if (Global.BaseStats_Dictionary.ContainsKey(TotalStats))
            {
                Pokemon_ListBox.DataSource = Global.BaseStats_Dictionary[TotalStats];
                DescriptionLabel.Text = $"There's { Global.BaseStats_Dictionary[TotalStats].Count } Pokemon with { TotalStats } Total Base Stats.";
                return;
            }
            DescriptionLabel.Text = "There's no Pokemon with these Total Base Stats.";
        }
        private void Form_TotalStats_Load(object sender, EventArgs e)
        {

        }
    }
}
