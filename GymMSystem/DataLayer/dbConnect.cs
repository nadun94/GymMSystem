using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace GymMSystem.DataLayer
{
    class dbConnect
    {
        private static string conString;
        SqlConnection con;

        public void openConnection()
        {
            con = new SqlConnection(conString);
            con.Open();
        }

        public void closeConnection()
        {
            con.Close();
        }

        public void ExecuteQueries(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader dataReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            return dr;
        }

        public object showDataInGridView(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(conString,con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            object datanum = ds.Tables[0];
            return datanum; 
            
        }
    }
}
