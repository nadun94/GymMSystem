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
    public partial class Members : MetroForm
    {
        public Members()
        {
            InitializeComponent();

            this.StyleManager = msmMember;
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        


        // this.Theme = MetroFramework.MetroThemeStyle.Light;



    }
}
