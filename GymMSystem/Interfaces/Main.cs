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

namespace GymMSystem
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {

            //window changing
            Interfaces.OtherServices ot = new Interfaces.OtherServices();

            this.Hide();
            ot.Show();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
