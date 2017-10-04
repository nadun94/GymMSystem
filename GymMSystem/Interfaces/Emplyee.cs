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
    }
}
