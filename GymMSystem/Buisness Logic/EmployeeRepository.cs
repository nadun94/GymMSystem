using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GymMSystem.Buisness_Logic
{
    class EmployeeRepository
    {

        public bool addEmployee(Buisness_Logic.employee emp)
        {

            bool temp1 = false;
            try
            {
                DataLayer.dbConnect con1 = new DataLayer.dbConnect();
                con1.openConnection();

                string q1 = "insert into tbl_employee (name,dob,nic,address,gender,email,phone,position,profile,joinedDate,photo) values (@name,@dob,@nic,@address,@gender,@email,@phone,@position,@profile,@jdate,@photo)";

                SqlCommand cmd1 = new SqlCommand(q1, con1.getConnection());

                cmd1.Parameters.AddWithValue("@name", emp.name);
                cmd1.Parameters.AddWithValue("@dob", emp.dob);
                cmd1.Parameters.AddWithValue("@nic", emp.nic);
                cmd1.Parameters.AddWithValue("@address", emp.address);
                cmd1.Parameters.AddWithValue("@gender", emp.gender);
                cmd1.Parameters.AddWithValue("@email", emp.email);
                cmd1.Parameters.AddWithValue("@phone", emp.phone);
                cmd1.Parameters.AddWithValue("@position", emp.position);
                cmd1.Parameters.AddWithValue("@profile", emp.profile);
                cmd1.Parameters.AddWithValue("@photo", emp.photo);
                cmd1.Parameters.AddWithValue("@jdate", emp.joinedDate);

                cmd1.ExecuteNonQuery();
                temp1 = true;

            }
            catch (Exception ew)
            {

                throw;
            }


            if (temp1 == true) return true;
            else return false;
            



        }
    }
}
