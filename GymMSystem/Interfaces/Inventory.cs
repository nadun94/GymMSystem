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
    }
}
