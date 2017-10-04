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
    class repairableItem_repository
    {
        public bool addRepItems(repairablerable_Items rep)
        {
            DataLayer.dbConnect dbrep = new DataLayer.dbConnect();
            dbrep.openConnection();

            

            bool test = false;
          
            SqlTransaction trn1 = dbrep.getConnection().BeginTransaction();
            try
            { 

                string q1 = "INSERT INTO tbl_inventory (name,make,model,price,photo) values (@name,@make,@model,@price,@photo) ";
                SqlCommand cmd1 = new SqlCommand(q1, dbrep.getConnection());

                cmd1.Parameters.AddWithValue("@name", rep.name);
                cmd1.Parameters.AddWithValue("@make", rep.make);
                cmd1.Parameters.AddWithValue("@model", rep.model);
                cmd1.Parameters.AddWithValue("@price", rep.price);
                cmd1.Parameters.AddWithValue("@photo", rep.photo);

                cmd1.Transaction = trn1;
                cmd1.ExecuteNonQuery();


                string q2 = "SELECT invID FROM tbl_inventory where name=@name";
                SqlCommand cmd2 = new SqlCommand(q2, dbrep.getConnection());

                cmd2.Parameters.AddWithValue("@name", rep.name);

                cmd2.Transaction = trn1;

                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {

                rep.invID = int.Parse(dt1.Rows[0]["invID"].ToString());

                }


                string q3 = "INSERT INTO tbl_repairable_item values (@invid)";

                SqlCommand cmd3 = new SqlCommand(q3, dbrep.getConnection());

                cmd3.Parameters.AddWithValue("@invid", rep.invID);
      

                cmd3.Transaction = trn1;
                cmd3.ExecuteNonQuery();
                trn1.Commit();
            dbrep.closeConnection();

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
