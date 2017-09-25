using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GymMSystem.Buisness_Logic
{
    class feeRepository
    {

        public bool addFee(fee f,member m)
        {
            try
            {
                DataLayer.dbConnect dbfee = new DataLayer.dbConnect();
                dbfee.openConnection();

                string qf1 = "insert into tbl_fee values(@feeid,@amount,@service,@valid_date,@paid_date,@memerID)";

                SqlCommand cmd1 = new SqlCommand(qf1, dbfee.getConnection());

                cmd1.Parameters.AddWithValue("@feeid", f.feeForPackage);
                cmd1.Parameters.AddWithValue("@amount", f.amount);
                cmd1.Parameters.AddWithValue("@service", f.service);
                cmd1.Parameters.AddWithValue("@valid_date", f.validDate);
                cmd1.Parameters.AddWithValue("@paid_date", f.paidDate);
                cmd1.Parameters.AddWithValue("@memerID", f.memberId);

                cmd1.ExecuteNonQuery();
                return true;
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
           
        }

    }
}
