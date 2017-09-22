using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace GymMSystem.Buisness_Logic
{
    class gymMemberRepository
    {
        

        //public bool validateMemeber (gymMember mem1)
        //{
        //    validation val = new validation();
        //    // bool status = false;


        //    if (val.IsEmail(mem1.email)) return true;

        //    else if (val.IsAddress(mem1.addresss)) return true;

        //    else if (val.IsName(mem1.name)) return true;

        //    else if (val.IsPhone(mem1.phone)) return true;

        //    else if (val.IsHeight(mem1.height)) return true;

        //    else if (val.IsWeight(mem1.weight)) return true;

        //    else
        //        return false;

        //}

        public bool save(gymMember mem)
        {
            DataLayer.dbConnect newdbcon = new DataLayer.dbConnect();
            newdbcon.openConnection();

         SqlTransaction trans = newdbcon.getConnection().BeginTransaction();

            bool status = false ;
            try
            {
                
              
                
                SqlCommand cmdt = null;


                // query 1
                string query1 = "INSERT INTO tbl_member (name, dob, address,nic,gender, phone) VALUES (@name,@dob,@address,@nic,@gender,@phone)";
               
                //initialize sqlCommand
                cmdt = new SqlCommand(query1, newdbcon.getConnection());

                // add values to command using parameters
                cmdt.Parameters.AddWithValue("@name", mem.name);
                cmdt.Parameters.AddWithValue("@dob", mem.dob);
                cmdt.Parameters.AddWithValue("@address", mem.addresss);
                cmdt.Parameters.AddWithValue("@gender", mem.gender);
                cmdt.Parameters.AddWithValue("@phone", mem.phone);
                cmdt.Parameters.AddWithValue("@nic", mem.nic);

                cmdt.Transaction = trans;
                cmdt.ExecuteNonQuery();
               



                string query2 = "SELECT regNo from tbl_member where name=@memName and nic=@nic";
                SqlCommand cmdt1 = new SqlCommand(query2, newdbcon.getConnection());
                
                
                
              
                cmdt1.Parameters.AddWithValue("@memName", mem.name);
                cmdt1.Parameters.AddWithValue("@nic", mem.nic);
                cmdt1.Transaction = trans;
                SqlDataReader dr = cmdt1.ExecuteReader();

             

                while (dr.Read())
                {
                    mem.MemberID = (int)dr["regNo"];
                }

                dr.Close();
                string query3 = "INSERT INTO tbl_gymMember values (@regno,@email,@joinedDate,@bmi,@height,@weight,@payplan,@photo,@fatLevel)";
                SqlCommand cmdt2 = new SqlCommand(query3, newdbcon.getConnection());

                
              
                cmdt2.Parameters.AddWithValue("@regno", mem.MemberID);
                cmdt2.Parameters.AddWithValue("@email", mem.email);
                cmdt2.Parameters.AddWithValue("@joinedDate", mem.joinedDate);
                cmdt2.Parameters.AddWithValue("@bmi", mem.BMIratio);
                cmdt2.Parameters.AddWithValue("@height", mem.height);
                cmdt2.Parameters.AddWithValue("@weight", mem.weight);
                cmdt2.Parameters.AddWithValue("@payplan", mem.paymentPlan);
                cmdt2.Parameters.AddWithValue("@photo", mem.photo);
                cmdt2.Parameters.AddWithValue("@fatLevel", mem.fatLevel);
                cmdt2.Transaction = trans;
                cmdt2.ExecuteNonQuery();
                trans.Commit();
                newdbcon.closeConnection();

                status = true;
               




            }

            catch(Exception ep)
            {
             trans.Rollback();
                MessageBox.Show(ep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (status == true)
                return true;
            else
                return false;


        }

        public gymMember search(int reNo, string name, string nic)
        {
            DataLayer.dbConnect dbmem_seach = new DataLayer.dbConnect();
            dbmem_seach.openConnection();

            string query1 = "SELECT * FROM tbl_member WHERE regNo=@reg OR name=@name OR nic=@nic";

            SqlCommand cmd1 = new SqlCommand(query1, dbmem_seach.getConnection());

            cmd1.Parameters.AddWithValue("@reg", reNo);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@nic", nic);

            SqlDataReader dr1 = cmd1.ExecuteReader();

            gymMember gm = new gymMember();
            while (dr1.Read())
            {
                gm.MemberID = (int)dr1["regNo"];
                gm.name = (string) dr1["name"];
                gm.nic = (string)dr1["nic"];
                gm.gender = (string)dr1["gender"];
                gm.addresss = (string)dr1["address"];
                gm.phone = (int)dr1["phone"];
                gm.dob = (string)dr1["dob"];
             


            }

            return gm;


            //gm.joinedDate = (string)dr1["joined_date"];
        }




    }
}
