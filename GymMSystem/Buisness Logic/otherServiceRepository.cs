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
        public bool addOtherMembers(AreobicMember ar)
        {

            DataLayer.dbConnect con = new DataLayer.dbConnect();
            con.openConnection();


            //qery one 
            string q1 = "Insert into table (name, age) values (@name, @age)"; //oya me query eke complete karanna

            SqlCommand cmd1 = new SqlCommand(q1, con.getConnection());

            cmd1.Parameters.AddWithValue("@name", ar.name);
            

            return true;


        }
    }
}
