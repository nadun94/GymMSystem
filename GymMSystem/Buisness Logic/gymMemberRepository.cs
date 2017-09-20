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

            SqlTransaction trans = newdbcon.getConnection().BeginTransaction(IsolationLevel.ReadCommitted);

            bool status = false ;
            try
            {
                
              

                SqlCommand cmdt = null;


                // query 1
                string query1 = "INSERT INTO tbl_member (name, dob, address,nic,gender, phone) VALUES (@name,@dob,@address,@nic,@gender,@phone)";
                //////////
                cmdt = new SqlCommand(query1, newdbcon.getConnection(),trans);
                cmdt.Parameters.AddWithValue("@name", mem.name);
                cmdt.Parameters.AddWithValue("@dob", mem.dob);
                cmdt.Parameters.AddWithValue("@address", mem.addresss);
                cmdt.Parameters.AddWithValue("@gender", mem.gender);
                cmdt.Parameters.AddWithValue("@phone", mem.phone);
                cmdt.Parameters.AddWithValue("@nic", mem.nic);

                cmdt.ExecuteNonQuery();
                trans.Commit();
                cmdt.Dispose();



                //newdbcon.addParameters("@name", mem.name);
                //newdbcon.addParameters("@dob", mem.dob);
                //newdbcon.addParameters("@address", mem.addresss);
                //newdbcon.addParameters("@gender", mem.gender);
                //newdbcon.addParameters("@phone", mem.phone);
                //newdbcon.addParameters("@nic", mem.nic);
                //newdbcon.ExecuteQueries(query1);

                string query2 = "SELECT regNo from tbl_member where name=@memName";
                SqlCommand cmdt1 = new SqlCommand(query2, newdbcon.getConnection());
                
                
                
                //newdbcon.addParameters("@memName", mem.name);
                cmdt1.Parameters.AddWithValue("@memName", mem.name);
                SqlDataReader dr = cmdt1.ExecuteReader();

                //var dr = newdbcon.dataReader(query2);

                while (dr.Read())
                {
                    mem.MemberID = (int)dr["regNo"];
                }

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
                cmdt2.ExecuteNonQuery();
                //trans.Commit();
                //cmdt.Dispose();

                //newdbcon.addParameters("@regno", mem.MemberID);
                // newdbcon.addParameters("@email", mem.email);
                // newdbcon.addParameters("@joinedDate", mem.joinedDate);
                //newdbcon.addParameters("@bmi", mem.BMIratio);
                //newdbcon.addParameters("@height", mem.height);
                //newdbcon.addParameters("@weight", mem.weight);
                //newdbcon.addParameters("@payplan", mem.paymentPlan);
                //newdbcon.addParameters("@photo", mem.photo);
                //newdbcon.addParameters("@fatLevel", mem.fatLevel);

                //newdbcon.ExecuteQueries(query3);



                status = true;

            }

            catch(Exception ep)
            {
                trans.Rollback();
                Console.WriteLine(ep.Message);
                Console.ReadLine();
            }


            if (status == true)
                return true;
            else
                return false;


        }




    }
}
