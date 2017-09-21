using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace GymMSystem.Buisness_Logic
{
    class gymMemberRepository
    {
        

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

                status = true;
               




            }

            catch(Exception ep)
            {
             trans.Rollback();
              
            }


            if (status == true)
                return true;
            else
                return false;


        }




    }
}
