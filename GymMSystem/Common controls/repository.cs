using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GymMSystem.Common_controls
{
    class repository
    {
        private static string conString;
        SqlConnection con;
        private SqlCommand cmd;

        
           
        

        public void openConnection()
        {
            conString = @"Data Source=DESKTOP-HCHF8AM\NADUN;Initial Catalog=dbGym;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
        }

        public SqlConnection getConnection()
        {
            return con;
        }
        public SqlCommand getCommand()
        {
            return cmd;
        }
        public void closeConnection()
        {
            con.Close();
        }
        public void addParameters(string parameter, object objValue)
        {
            cmd.Parameters.AddWithValue(parameter, objValue);
        }
        public void clearParameters()
        {
            cmd.Parameters.Clear();
        }

        public void ExecuteQueries(string query)
        {
            cmd = new SqlCommand(query, con);


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
            SqlDataAdapter da = new SqlDataAdapter(conString, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            object datanum = ds.Tables[0];
            return datanum;

        }
    }
}
