using CryptoMiner141.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMiner141
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void btn_CPU_Click(object sender, EventArgs e)
        {
            CPU_settings cpu_set = new CPU_settings();
            cpu_set.ShowDialog();
        }

        private void btn_GPU_Click(object sender, EventArgs e)
        {
            GPU_settings gpu_set = new GPU_settings();
            gpu_set.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
