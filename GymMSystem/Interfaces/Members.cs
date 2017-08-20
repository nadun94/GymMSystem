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
            txtM_name.Focus();
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void memadd_Click(object sender, EventArgs e)
        {

        }

        private void btn_mem_browse_Click(object sender, EventArgs e)
        {
            try
            {
                openFIleDialog_mem.Filter = "Image files | *.jpg; *.PNG; *.gif; *.BMP";
                DialogResult drMem1 = openFIleDialog_mem.ShowDialog();

                if(drMem1 == DialogResult.OK)
                {
                    picuturebox_member.SizeMode = PictureBoxSizeMode.StretchImage;
                    picuturebox_member.Image = Image.FromFile(openFIleDialog_mem.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            

        }

        private void btnMemHme_Click(object sender, EventArgs e)
        {
            Main hm = new Main();
            this.Hide();
            hm.Show();

        }

       

        private void metroTile1_Click(object sender, EventArgs e)
        {
            txtM_height.Text = "";
            txtM_name.Text = "";
            txtM_nic.Text = "";
            txtM_phone.Text = "";
            txtM_weight.Text = "";
            cmbM_gender.SelectedItem = null;
            cmbM_paymentPlan.SelectedItem = null;
            picuturebox_member.Image = null;
            txtM_name.Focus();

            
        }

        private void btnM_save_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbM_paymentPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        // this.Theme = MetroFramework.MetroThemeStyle.Light;



    }
}
