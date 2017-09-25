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
    public partial class OtherServices : MetroForm
    {
        public OtherServices()
        {
            InitializeComponent();
           
        }

        private void OtherServices_Load(object sender, EventArgs e)
        {
            radio_hc.Checked = true;

            lbl_monthlyRate.Visible = false;
            lbl_hr.Refresh();
            metroLabel1.Visible = false;
            txtOS1_EndingTime.Visible = false;
            txtOS1_statingTime.Visible = false;
            txt_cordinator.Visible = false;
            cmbOS1_day.Visible = false;
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;

            metroLabel2.Refresh();
            metroLabel3.Refresh();
            metroLabel4.Refresh();
            txt_cordinator.Refresh();
            txtOS1_statingTime.Refresh();
            txtOS1_EndingTime.Refresh();
            cmbOS1_day.Refresh();
            metroLabel1.Refresh();


        }

        private void servicesTabPage_Click(object sender, EventArgs e)
        {
          
        }

        private void radio_hc_CheckedChanged(object sender, EventArgs e)
        {
          // radio button initialization

            if (radio_mc.Checked == true)
            {
                lbl_monthlyRate.Visible = true;
                lbl_monthlyRate.Refresh();
                lbl_hr.Visible = false;
                lbl_hr.Refresh();

            }
            else if (radio_hc.Checked == true)
            {
                lbl_monthlyRate.Visible = false;
                lbl_monthlyRate.Refresh();
                lbl_hr.Visible = true;
                lbl_hr.Refresh();
            }

            // check button initialization
            
           if( checkOS2Mem.Checked == false)
            {
                lblHint1.Visible = false;
                lblHint2.Visible = false;
                btnOS2_searchMember.Visible = false;

                lblHint1.Refresh();
                lblHint2.Refresh();
                btnOS2_searchMember.Refresh();
            }
           else if(checkOS2Mem.Checked == true)
            {

                lblHint1.Visible = true;
                lblHint2.Visible = true;
                btnOS2_searchMember.Visible = true;

                lblHint1.Refresh();
                lblHint2.Refresh();
                btnOS2_searchMember.Refresh();

            }
            
        }

        private void radio_mc_CheckedChanged(object sender, EventArgs e)
        {

            if (radio_mc.Checked == true)
            {
                lbl_monthlyRate.Visible = true;
                lbl_monthlyRate.Refresh();
                lbl_hr.Visible = false;
                lbl_hr.Refresh();

                metroLabel1.Visible = true;
                txtOS1_EndingTime.Visible = true;
                txtOS1_statingTime.Visible = true;
                txt_cordinator.Visible = true;
                cmbOS1_day.Visible = true;
                metroLabel2.Visible = true;
                metroLabel3.Visible = true;
                metroLabel4.Visible = true;

                metroLabel2.Refresh();
                metroLabel3.Refresh();
                metroLabel4.Refresh();
                txt_cordinator.Refresh();
                txtOS1_statingTime.Refresh();
                txtOS1_EndingTime.Refresh();
                cmbOS1_day.Refresh();
                metroLabel1.Refresh();


            }
            else if (radio_hc.Checked == true)
            {
                lbl_monthlyRate.Visible = false;
                lbl_monthlyRate.Refresh();
                lbl_hr.Visible = true;
                lbl_hr.Refresh();

                metroLabel1.Visible = false;
                txtOS1_EndingTime.Visible = false;
                txtOS1_statingTime.Visible = false;
                txt_cordinator.Visible = false;
                cmbOS1_day.Visible = false;
                metroLabel2.Visible = false;
                metroLabel3.Visible = false;
                metroLabel4.Visible = false;

                metroLabel2.Refresh();
                metroLabel3.Refresh();
                metroLabel4.Refresh();
                txt_cordinator.Refresh();
                txtOS1_statingTime.Refresh();
                txtOS1_EndingTime.Refresh();
                cmbOS1_day.Refresh();
                metroLabel1.Refresh();





            }

        }

        private void lbl_monthlyRate_Click(object sender, EventArgs e)
        {

        }

        private void btnOS1_Save_Click(object sender, EventArgs e)
        {

        }

        private void tab_addMemOS2_Click(object sender, EventArgs e)
        {

        }

        private void btnOS1_update_Click(object sender, EventArgs e)
        {

        }

        private void btnOS2_Save_Click(object sender, EventArgs e)
        {
            //create areobicmember object
            Buisness_Logic.AreobicMember am = new Buisness_Logic.AreobicMember();

            am.name = txtOS2_memName.Text;
            am.dob = dateTime_OS2Mem.Value.ToShortDateString();
            am.nic = txtOS2_nic.Text;
            am.phone = int.Parse(txtOS2_phone.Text);
            am.service_type = cmbOS2_serviceType.SelectedItem.ToString();


            Buisness_Logic.otherServiceRepository rep1 = new Buisness_Logic.otherServiceRepository();

          if(rep1.addOtherMembers(am))
            {
                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void btnOS_home_Click(object sender, EventArgs e)
        {
            Main home = new Main();
            this.Hide();
            home.Show();



        }

        private void cmbOS2_serviceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkOS2Mem_CheckedChanged(object sender, EventArgs e)
        {
            //Already a member or not

            lblHint1.Visible = true;
            lblHint2.Visible = true;
            btnOS2_searchMember.Visible = true;

            lblHint1.Refresh();
            lblHint2.Refresh();
            btnOS2_searchMember.Refresh();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }
    }
}
