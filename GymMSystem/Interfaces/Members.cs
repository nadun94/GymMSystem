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
using System.Data.Sql;
using System.Data.SqlClient;





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

            this.reportViewer1.RefreshReport();
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
            txtM_fat.Text = "";
            txtM_name.Focus();

            
        }

        private void btnM_save_Click(object sender, EventArgs e)
        {
           
            try
            {
                //initialize image

                MemoryStream memt1p1 = new MemoryStream();
                picuturebox_member.Image.Save(memt1p1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] photo_memt1 = memt1p1.ToArray();

                //******************************************
               
               
               
                // create gymMember object 
                Buisness_Logic.gymMember mem = new Buisness_Logic.gymMember();

                //*******************************************

                // set values to gymMember class
                mem.name = txtM_name.Text;
                mem.dob = dateTimePickerMem.Value.ToShortDateString();
                mem.gender = cmbM_gender.SelectedItem.ToString();
                mem.phone = int.Parse(txtM_phone.Text);
                mem.addresss = txtM_address.Text;
                mem.nic = txtM_nic.Text;

                mem.height = double.Parse(txtM_height.Text);
                mem.weight = double.Parse(txtM_weight.Text);
                mem.email = txtM_email.Text;
                mem.photo = photo_memt1;
                mem.paymentPlan = cmbM_paymentPlan.SelectedItem.ToString();
                mem.fatLevel = double.Parse(txtM_fat.Text);

                //**********************************************
               

               


                Buisness_Logic.gymMemberRepository gr = new Buisness_Logic.gymMemberRepository();


                if (gr.save(mem))
                {
                    MessageBox.Show("Success", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtM_memID.Text = mem.MemberID.ToString();
                    txtM_bmiratio.Text = mem.BMIratio.ToString();
                }




            }

            catch (Exception exm1)
            {
                MessageBox.Show(exm1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cmbM_paymentPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnM3_check_Click(object sender, EventArgs e)
        {

        }

        private void btnM3_clear_Click(object sender, EventArgs e)
        {

        }

        private void btnM3_Search_Click(object sender, EventArgs e)
        {

            try
            {


            }
            catch (Exception expo)
            {

                throw;
            }

        }




        // this.Theme = MetroFramework.MetroThemeStyle.Light;



    }
}
