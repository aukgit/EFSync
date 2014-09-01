using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSyncWithDatabase
{
    public partial class SpecificProjectSetting : Form
    {
        public SpecificProjectSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = locationPathText.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                locationPathText.Text = fbd.SelectedPath;

            }
        }
    }
}
