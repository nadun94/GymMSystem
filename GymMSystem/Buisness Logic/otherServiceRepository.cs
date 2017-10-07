using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace GymMSystem.Buisness_Logic
{
    class otherServiceRepository
    {
        public bool addOtherMembers(Buisness_Logic.AreobicMember am)
        {//String name,String dob,String address,String nic,String gender,int phone

            DataLayer.dbConnect con = new DataLayer.dbConnect();
            con.openConnection();


            //qery one 
            string q1 = "Insert into tbl_member(name, dob,address,nic,gender,phone) values (@name, @dob,@address,@nic,@gender,@phone)"; 

            SqlCommand cmd1 = new SqlCommand(q1, con.getConnection());

            cmd1.Parameters.AddWithValue("@name", am.name);
            cmd1.Parameters.AddWithValue("@dob", am.dob);
            cmd1.Parameters.AddWithValue("@address", am.addresss);
            cmd1.Parameters.AddWithValue("@nic", am.nic);
            cmd1.Parameters.AddWithValue("@gender", am.gender);
            cmd1.Parameters.AddWithValue("@phone", am.phone);
           // cmd1.Parameters.AddWithValue("@service", am.service_type);

            cmd1.ExecuteNonQuery();

            return true;


        }


        public bool updateOtherMembers(int regNo, String name, String dob, String address, String nic, String gender, int phone)
        {

            DataLayer.dbConnect con = new DataLayer.dbConnect();
            con.openConnection();


            //qery one 
            string q1 = "update tbl_member set Name=@name,name=@name, dob=@dob,address=@address,nic=@nic,gender=@gender,phone=@phone where regNo=@regNo"; //oya me query eke complete karanna

            SqlCommand cmd1 = new SqlCommand(q1, con.getConnection());

            cmd1.Parameters.AddWithValue("@regNo", regNo);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@dob", dob);
            cmd1.Parameters.AddWithValue("@address", address);
            cmd1.Parameters.AddWithValue("@nic", nic);
            cmd1.Parameters.AddWithValue("@gender", gender);
            cmd1.Parameters.AddWithValue("@phone", phone);

            cmd1.ExecuteNonQuery();

            return true;


        }


        public bool deleteOtherMembers(int regNo)
        {

            DataLayer.dbConnect con = new DataLayer.dbConnect();
            con.openConnection();


            //qery one 
            string q1 = "delete tbl_member where regNo=@regNo"; //oya me query eke complete karanna

            SqlCommand cmd1 = new SqlCommand(q1, con.getConnection());

            cmd1.Parameters.AddWithValue("@regNo", regNo);

            cmd1.ExecuteNonQuery();

            return true;


        }

        public List<member> selectOtherMembers(int regNo)
        {

            List<member> memberList = new List<member>();

            DataLayer.dbConnect con = new DataLayer.dbConnect();
            con.openConnection();


            //qery one 
            string q1 = "select * from tbl_member where regNo=@regNo"; //oya me query eke complete karanna

            SqlCommand cmd = new SqlCommand(q1);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                //Membe m = new Membe();
                // m.Name = reader["name"].toString();
                // m.dob = reader["dob"].toString();
                // m.address = reader["address"].toString();
                // m.nic= reader["nic"].toString();
                // m.gender = reader["gender"].toString();
                // m.phone = reader["phone"].toString();

                //memberList.Add(m);

            }

            return memberList;

        }


    }
}
