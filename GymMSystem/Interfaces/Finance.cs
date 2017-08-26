using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GymMSystem.Interfaces
{
    public partial class Finance : MetroForm
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void btnFinHome_Click(object sender, EventArgs e)
        {
            Main hmfin = new Main();
            this.Hide();
            hmfin.Show();
        }

        private void txtFin5_amount_Click(object sender, EventArgs e)
        {

        }
    }
}
