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
    public partial class workouts : MetroForm
    {
        public workouts()
        {
            InitializeComponent();
        }

        private void workouts_Load(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnWorvHome_Click(object sender, EventArgs e)
        {
            Main gh = new Main();
            this.Hide();
            gh.Show();
        }

        private void btnexercise_save_Click(object sender, EventArgs e)
        {

          
        }
    }
}
