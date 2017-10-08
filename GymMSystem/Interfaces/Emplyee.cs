﻿using System;
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
    public partial class Emplyee : MetroForm
    {
        public Emplyee()
        {
            InitializeComponent();


        }

        private void Emplyee_Load(object sender, EventArgs e)
        {

            txtEmp1_jdate.Text = DateTime.Today.ToShortDateString();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
        private bool validateEmp()
        {
            Buisness_Logic.validation vemp = new Buisness_Logic.validation();

            if (vemp.IsWord(txtEmp1_name.Text, "Name"))
            {
                if (vemp.IsWord(txtEmp1_address.Text, "Address")){

                    if (vemp.IsNIC(txtEmp_nic.Text))
                    {
                        if (picuturebox_emp1.Image != null)
                            return true;
                        else
                        {
                            MessageBox.Show("Please fill all text feilds and save.", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    return false;
                }
                else return false;

            }
            else return false;
        }

        private void btnEmp1_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (validateEmp())
                {
                    Buisness_Logic.employee emp = new Buisness_Logic.employee();

                    emp.name = txtEmp1_name.Text;
                    emp.address = txtEmp1_address.Text;
                    emp.dob = dateTimePickeremp.Value.ToShortDateString();

                    //initialize image

                    MemoryStream memt1p1 = new MemoryStream();
                    picuturebox_emp1.Image.Save(memt1p1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] photo_memt1 = memt1p1.ToArray();
                    emp.phone = int.Parse(txtEmp1_phone.Text);
                    emp.photo = photo_memt1;
                    emp.nic = txtEmp_nic.Text;
                    emp.position = cmbEmp1_post.SelectedItem.ToString();
                    emp.joinedDate = txtEmp1_jdate.Text;
                    emp.gender = cmbEmp1_gender.SelectedItem.ToString();
                    emp.email = txtEmp1_email.Text;
                    emp.profile = txtEmp1_resume.Text;

                    Buisness_Logic.EmployeeRepository empr = new Buisness_Logic.EmployeeRepository();


                    if (empr.addEmployee(emp))
                    {
                        MessageBox.Show("Success", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception exb)
            {
                MessageBox.Show(exb.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btn_emp1_browse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogEmp.Filter = "Image files | *.jpg; *.PNG; *.gif; *.BMP";
                DialogResult drMem1 = openFileDialogEmp.ShowDialog();

                if (drMem1 == DialogResult.OK)
                {
                    picuturebox_emp1.SizeMode = PictureBoxSizeMode.StretchImage;
                    picuturebox_emp1.Image = Image.FromFile(openFileDialogEmp.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEmp1Search_Click(object sender, EventArgs e)
        {
        }

        private void btnEMP2_browse_Click(object sender, EventArgs e)
        {

        }

        private void btnEMP2_search_Click(object sender, EventArgs e)
        {

        }

        private void btnEMP2_clear_Click(object sender, EventArgs e)
        {

        }

        private void btnEmp1_clear_Click(object sender, EventArgs e)
        {

        }

        private void btnAtAdStrtTime_Click(object sender, EventArgs e)
        {

        }
        private Buisness_Logic.empAttendence transport1  = null;
        private void btnAtSerchM_Click(object sender, EventArgs e)
        {

        }

        private void btnAtAdEndTime_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcHours_Click(object sender, EventArgs e)
        {

        }

        private void btnAtSerchM_Click_1(object sender, EventArgs e)
        {
            try
            {
                Buisness_Logic.empAttendence ea1 = new Buisness_Logic.empAttendence();

                ea1.empID = int.Parse(txtEmpIDatte.Text);
                ea1.theDay = DateTime.Today.ToShortDateString();

                Buisness_Logic.empAttendence_repository emarep2 = new Buisness_Logic.empAttendence_repository();

                if (emarep2.searchMemAt(ea1))
                {
                    MessageBox.Show("Member attendence record found in that employee id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStartTime.Text = ea1.startTime;
                    txtempAT_theday.Text = ea1.theDay;


                }
                else
                {
                    MessageBox.Show("No record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                transport1 = ea1;
            }
            catch (Exception es)
            {

                throw;
            }
        }

        private void btnAtAdStrtTime_Click_1(object sender, EventArgs e)
        {

            try
            {
                txtempAT_theday.Text = DateTime.Today.ToShortDateString();
                txtStartTime.Text = DateTime.Now.ToShortTimeString();
                Buisness_Logic.empAttendence em = new Buisness_Logic.empAttendence();

                em.empID = int.Parse(txtEmpIDatte.Text);
                em.theDay = txtempAT_theday.Text;
                em.startTime = txtStartTime.Text;

                Buisness_Logic.empAttendence_repository emprep = new Buisness_Logic.empAttendence_repository();

                if (emprep.addStartTime(em))
                {
                    MessageBox.Show("Success", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Failed.", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }









            }
            catch (Exception ew)
            {

                throw;
            }
        }

        private void btnCalcHours_Click_1(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception etu)
            {

                throw;
            }
        }

        private void btnAtAdEndTime_Click_1(object sender, EventArgs e)
        {

            try
            {


                Buisness_Logic.empAttendence em1 = new Buisness_Logic.empAttendence();

                em1.empID = int.Parse(txtEmpIDatte.Text);
                em1.theDay = txtempAT_theday.Text;
                em1.startTime = txtStartTime.Text;
                em1.endTime = textAtEndTime.Text;

                Buisness_Logic.empAttendence_repository emprep1 = new Buisness_Logic.empAttendence_repository();

                if (emprep1.addEndTime(em1))
                {
                    MessageBox.Show("Success", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Failed.", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }









            }
            catch (Exception ew)
            {

                throw;
            }
        }

        private void btnEMP2_search_Click_1(object sender, EventArgs e)
        {
            try
            {
                Buisness_Logic.employee emp = new Buisness_Logic.employee();

                emp.empID = (string.IsNullOrEmpty(txtEmp2_empid.Text) ? 0 : int.Parse(txtEmp2_empid.Text));
                emp.name = txtEmp2_name.Text;
                emp.nic = txtEmp2_nic.Text;


                Buisness_Logic.EmployeeRepository emprt = new Buisness_Logic.EmployeeRepository();

                if (emprt.searchEMP(emp))
                {
                    txtEmp2_address.Text = emp.address;
                    txtEmp2_dob.Text = emp.dob;
                    txtEmp2_email.Text = emp.email;
                    txtEmp2_empid.Text = emp.empID.ToString();
                    txtEmp2_jDate.Text = emp.joinedDate;
                    txtEmp2_name.Text = emp.name;
                    txtEmp2_nic.Text = emp.nic;
                    txtEmp2_phone.Text = emp.phone.ToString();
                    txtEmp2_profile.Text = emp.profile;
                    cmbEMP2_gender.SelectedItem = emp.gender;
                    cmbEMP2_post.SelectedItem = emp.position;
                    pictureBoxEmp2.SizeMode = PictureBoxSizeMode.Zoom;

                    MemoryStream ms2 = new MemoryStream(emp.photo);
                    // ms1.ToArray();
                    ms2.Position = 0;

                    ms2.Read(emp.photo, 0, emp.photo.Length);
                    pictureBoxEmp2.Image = Image.FromStream(ms2);


                    MessageBox.Show("Success", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed.", "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exy)
            {
                MessageBox.Show(exy.Message, "Data Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnEMP2_clear_Click_1(object sender, EventArgs e)
        {

            txtEmp2_address.Text = "";
            txtEmp2_dob.Text = "";
            txtEmp2_email.Text = "";
            txtEmp2_empid.Text = "";
            txtEmp2_jDate.Text = "";
            txtEmp2_name.Text = "";
            txtEmp2_nic.Text = "";
            txtEmp2_phone.Text = "";
            txtEmp2_profile.Text = "";
            cmbEMP2_gender.SelectedItem = null;
            cmbEMP2_post.SelectedItem = null;
            pictureBoxEmp2.Image = null; 
        }

        private void btnEmp1_clear_Click_1(object sender, EventArgs e)
        {
            txtEmp1_name.Clear();
            txtEmp1_address.Clear();
            txtEmp1_email.Clear();
            txtEmp1_phone.Clear();
            txtEmp1_resume.Clear();
        }
    }
}
