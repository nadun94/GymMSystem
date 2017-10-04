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
    class nonRepairableItem_repository
    {

        public bool addNonRepairabItems(nonRepairable_Item nri)
        {
            bool test = false;
            DataLayer.dbConnect dbinv = new DataLayer.dbConnect();
            dbinv.openConnection();
            SqlTransaction trn1 = dbinv.getConnection().BeginTransaction();
            try
            {
                
                

                string q1 = "INSERT INTO tbl_inventory (name,make,model,price,photo) values (@name,@make,@model,@price,@photo) ";
                SqlCommand cmd1 = new SqlCommand(q1, dbinv.getConnection());

                cmd1.Parameters.AddWithValue("@name", nri.name);
                cmd1.Parameters.AddWithValue("@make", nri.make);
                cmd1.Parameters.AddWithValue("@model", nri.model);
                cmd1.Parameters.AddWithValue("@price", nri.price);
                cmd1.Parameters.AddWithValue("@photo", nri.photo);

                cmd1.Transaction = trn1;
                cmd1.ExecuteNonQuery();


                string q2 = "SELECT invID FROM tbl_inventory where name=@name";
                SqlCommand cmd2 = new SqlCommand(q2, dbinv.getConnection());

                cmd2.Parameters.AddWithValue("@name", nri.name);

                cmd2.Transaction = trn1;

                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    
                    nri.invID = int.Parse(dt1.Rows[0]["invID"].ToString());

                }


                string q3 = "INSERT INTO tbl_non_repairable values (@invid, @qty, @weight)";

                SqlCommand cmd3 = new SqlCommand(q3, dbinv.getConnection());

                cmd3.Parameters.AddWithValue("@invid", nri.invID);
                cmd3.Parameters.AddWithValue("@qty", nri.qty);
                cmd3.Parameters.AddWithValue("@weight", nri.weight);

                cmd3.Transaction = trn1;
                cmd3.ExecuteNonQuery();
                trn1.Commit();
                dbinv.closeConnection();
              
                test = true;

            }
            catch (Exception exinv)
            {
                trn1.Rollback();
                MessageBox.Show(exinv.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }


            if (test == true) return true;

            else return false;

        }
    }
}
