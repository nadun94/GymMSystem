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
using System.IO;


namespace GymMSystem.Interfaces
{
    public partial class inventory : MetroForm
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            if (radio_nonRep.Checked)
            {
                lblQty.Visible = true;
                lblWeight.Visible = true;
                lblWeight.Refresh();
                lblQty.Refresh();

            }
            else if (radio_repItems.Checked)
            {
                lblQty.Visible = false;
                lblWeight.Visible = false;
                lblWeight.Refresh();
                lblQty.Refresh();

            }
        }

        private void radio_repItems_CheckedChanged(object sender, EventArgs e)
        {
            lblQty.Visible = false;
            lblWeight.Visible = false;
            txtInv1Weight.Visible = false;
            txtInv_1qty.Visible = false;
            txtInv1Weight.Refresh();
            txtInv_1qty.Refresh();
            lblWeight.Refresh();
            lblQty.Refresh();

        }

        private void radio_nonRep_CheckedChanged(object sender, EventArgs e)
        {
            lblQty.Visible = true;
            lblWeight.Visible = true;
            txtInv1Weight.Visible = true;
            txtInv_1qty.Visible = true;
            txtInv1Weight.Refresh();
            txtInv_1qty.Refresh();
            lblWeight.Refresh();
            lblQty.Refresh();
        }

        private void btnInvHome_Click(object sender, EventArgs e)
        {
            Main tt = new Main();
            this.Hide();
            tt.Show();
        }

        private void btnsave_i2_Click(object sender, EventArgs e)
        {
            try
            {
                Buisness_Logic.inventory inv = new Buisness_Logic.inventory();

                if (radio_nonRep.Checked)
                {
                    Buisness_Logic.nonRepairable_Item nr = new Buisness_Logic.nonRepairable_Item();

                    nr.name = txtI1_iname.Text;
                    nr.make = txtI1_imake.Text;
                    nr.model = txtI1_imodel.Text;
                    nr.price = double.Parse(txtI1_iprice.Text);
                    nr.qty = int.Parse(txtInv_1qty.Text);
                    nr.weight = double.Parse(txtInv1Weight.Text);

                }
            }
            catch (Exception EX)
            {

                throw;
            }
        }
        private void btnI_save_Click(object sender, EventArgs e)
        {


        }

        private void btnclear_i3_Click(object sender, EventArgs e)
        {
            txtI1_iname.Text = "";
            txtI1_icode.Text = "";
            txtI1_imake.Text = "";
            txtInv1Weight.Text = "";
            txtI1_imodel.Text = "";
            txtI1_iprice.Text = "";
            txtInv_1qty.Text = "";
            pictureBox_i2.Image = null;

        }

        private void btncle_i5_Click(object sender, EventArgs e)
        {
            txtI1_iproduct.Text = "";
            txtI1_iid.Text = "";
            txtI1_ipri.Text = "";
            txtI1_iquantity.Text = "";
            txtI1_isub.Text = "";
            txtI1_itotal.Text = "";
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            txtI1_imachine.Text = "";
            txtI1_irepair.Text = "";
            txtI1_istatus.Text = "";
            txtI1_icost.Text = "";
            txtI1_icod.Text = "";
            txtI1_istart.Text = "";
            txtI1_ifinish.Text = "";
            txtI1_idescription.Text = "";
        }

        private void btnclea_i7_Click(object sender, EventArgs e)
        {
            metroComboBox_i1.SelectedItem = null;
            pictureBox_i2.Image = null;
        }

        private void btnBrowse_i1_Click(object sender, EventArgs e)
        {
            try
            {
                openfinv.Filter = "Image files | *.jpg; *.PNG; *.gif; *.BMP";
                DialogResult drMem1 = openfinv.ShowDialog();

                if (drMem1 == DialogResult.OK)
                {
                    pictureBox_i2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_i2.Image = Image.FromFile(openfinv.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
