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
    public partial class salesManagement : MetroForm
    {
        public salesManagement()
        {
            InitializeComponent();
        }

        private void salesManagement_Load(object sender, EventArgs e)
        {

        }

        private void mtrtil1splmnt_save_Click(object sender, EventArgs e)
        {
            try
            {
                Buisness_Logic.product prd = new Buisness_Logic.product();

                prd.name = txtAddp_name.Text;
                prd.qty = int.Parse(txtadd_qty.Text);
                prd.make = txtAddp_make.Text;
                prd.model = txtAddp_model.Text;

                MemoryStream ms = new MemoryStream();
                picBox1_addproduct.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = ms.ToArray();
                prd.photo = pic;

            }
            catch (Exception expropd)
            {
                MessageBox.Show(expropd.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            } 
            





        }

        private void mtrtil3splmnt_brows_Click(object sender, EventArgs e)
        {
            try
            {
                openfileprod1.Filter = "Image files | *.jpg; *.PNG; *.gif; *.BMP";
                DialogResult drMem1 = openfileprod1.ShowDialog();

                if (drMem1 == DialogResult.OK)
                {
                    picBox1_addproduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox1_addproduct.Image = Image.FromFile(openfileprod1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
