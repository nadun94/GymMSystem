using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GymMSystem.Buisness_Logic
{
    class productRepository
    {

        public bool save_Product(product prod)
        {


            try
            {
                DataLayer.dbConnect dbp = new DataLayer.dbConnect();
                dbp.openConnection();
                string query1 = "INSERT INTO tbl_product (name,make ,p_type, qty,price,photo) VALUES  (@name, @make, @type, @qty,@price, @photo)";

                SqlCommand cmd = new SqlCommand(query1, dbp.getConnection());
                cmd.Parameters.AddWithValue("@name", prod.name);
                cmd.Parameters.AddWithValue("@qty", prod.qty);


                cmd.ExecuteNonQuery();

            }
            catch (Exception exprep)
            {

                throw;
            }
            
           



        }
    }
}
