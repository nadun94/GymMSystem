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

            bool status = false ,temp= true;
            try
            {
                string qt1 = "select * from tbl_member where name=@name and nic=@nic";

                SqlCommand qt = new SqlCommand(qt1, newdbcon.getConnection());

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qt);

                qt.Parameters.AddWithValue("@name", mem.name);
                qt.Parameters.AddWithValue("@nic", mem.nic);

                qt.Transaction = trans;
                da.Fill(dt);

                if (dt.Rows.Count > 0 )
                {
                    temp = false;
                }
                
                if(temp == true)
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
                else
                    MessageBox.Show("This member already exists.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);






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


            try
            {
                DataLayer.dbConnect dbmem_seach = new DataLayer.dbConnect();
                dbmem_seach.openConnection();
                bool temp = false;
                string query1 = "SELECT * FROM tbl_member WHERE regNo=@reg OR name=@name OR nic=@nic";

                SqlCommand cmd1 = new SqlCommand(query1, dbmem_seach.getConnection());

                cmd1.Parameters.AddWithValue("@reg", reNo);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@nic", nic);

                //  SqlDataReader dr1 = cmd1.ExecuteReader();
                DataTable dtq = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                gymMember gm = new gymMember();
                da1.Fill(dtq);
                //while (dr1.Read())
                //{
                //    gm.MemberID = (int)dr1["regNo"];
                //    gm.name =  dr1["name"].ToString();
                //    gm.nic = dr1["nic"].ToString();
                //    gm.dob = dr1["dob"].ToString();
                //    gm.gender = dr1["gender"].ToString();
                //    gm.addresss = dr1["address"].ToString();
                //    gm.phone = (int)dr1["phone"];




                //}
                if (dtq.Rows.Count > 0)
                {

                    gm.MemberID = int.Parse(dtq.Rows[0]["regNo"].ToString());
                    gm.name = dtq.Rows[0]["name"].ToString();
                    gm.nic = dtq.Rows[0]["nic"].ToString();
                    gm.dob = dtq.Rows[0]["dob"].ToString();
                    gm.gender = dtq.Rows[0]["gender"].ToString();
                    gm.addresss = dtq.Rows[0]["address"].ToString();
                    gm.phone = int.Parse(dtq.Rows[0]["phone"].ToString());

                    temp = true;
                }
                //  dr1.Close();

                string query2 = "SELECT * FROM tbl_gymMember WHERE  memberID=@id";


                SqlCommand cmd2 = new SqlCommand(query2, dbmem_seach.getConnection());
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();


                cmd2.Parameters.AddWithValue("@id", gm.MemberID);
                da2.Fill(dt2);
                bool temp1 = false;
                // SqlDataReader dr2 = cmd2.ExecuteReader();

                //while (dr2.Read())
                //{
                //    gm.email = dr2["email"].ToString();
                //    gm.paymentPlan = dr2["payment_plan"].ToString();
                //    gm.joinedDate = dr2["joined_date"].ToString();
                //    gm.height = (double)dr2["height"];
                //    gm.weight = (double)dr2["weight"];
                //    gm.BMIratio = (double)dr2["BMI"];
                //    gm.fatLevel = (double)dr2["fat_level"];
                //    gm.photo = (byte[])dr2["photo"];

                if (dt2.Rows.Count > 0)
                {
                    // gm.MemberID = int.Parse(dt2.Rows[0]["regNo"].ToString());
                    gm.email = dt2.Rows[0]["email"].ToString();
                    gm.paymentPlan = dt2.Rows[0]["payment_plan"].ToString();
                    gm.joinedDate = dt2.Rows[0]["joined_date"].ToString();
                    gm.height = double.Parse(dt2.Rows[0]["height"].ToString());
                    gm.weight = double.Parse(dt2.Rows[0]["weight"].ToString());
                    gm.BMIratio = double.Parse(dt2.Rows[0]["BMI"].ToString());
                    gm.fatLevel = double.Parse(dt2.Rows[0]["fat_level"].ToString());
                    gm.photo = (byte[])dt2.Rows[0]["photo"];

                    temp1 = true;
                }




                //dr1.Close();
           //     dbmem_seach.closeConnection();

                if (temp == true && temp1 == true)
                {
                    MessageBox.Show("Record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No record found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return gm;

            }
            catch (Exception er)
            {

                throw;
            }
            
            //gm.joinedDate = (string)dr1["joined_date"];
        }




    }
}
