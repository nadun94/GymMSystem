using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GymMSystem.Buisness_Logic
{
    class workout_repository
    {

        public bool addWorkouts(Buisness_Logic.workout wo)
        {
            bool temp = false;
            try
            {
                DataLayer.dbConnect con1 = new DataLayer.dbConnect();

                con1.openConnection();

                string q1 = "INSERT INTO tbl_workout (w_name,type, BMI_rate,fat_level,repeats,interval_days) values (@name,@type,@bmi,@fat,@rep,@interval)";

                SqlCommand cmd1 = new SqlCommand(q1, con1.getConnection());

                cmd1.Parameters.AddWithValue("@name", wo.workout_name);
                cmd1.Parameters.AddWithValue("@type",wo.type);
                cmd1.Parameters.AddWithValue("@bmi",wo.BMI_rate);
                cmd1.Parameters.AddWithValue("@fat",wo.fat_level);
                cmd1.Parameters.AddWithValue("@rep",wo.repeats);
                cmd1.Parameters.AddWithValue("@interval",wo.interval_days);

                cmd1.ExecuteNonQuery();


                temp = true;

            }
            catch (Exception exr)
            {

                throw;
            }

            if (temp == true) return true;
            else return false;

        }


        public bool updateWorkouts(Buisness_Logic.workout wo1)
        {

            bool temp = false;

            try
            {
                DataLayer.dbConnect mydb = new DataLayer.dbConnect();
                mydb.openConnection();

                SqlCommand cmd = null;
                string qry = "UPDATE tbl_workout SET type=@type, BMI_rate=@BMI, fat_level=@fat, repeats=@repeat, interval_days=@interval WHERE w_name=@wname";

                cmd = new SqlCommand(qry, mydb.getConnection());

                cmd.Parameters.AddWithValue("@type",wo1.type);
                cmd.Parameters.AddWithValue("@BMI",wo1.BMI_rate);
                cmd.Parameters.AddWithValue("@fat",wo1.fat_level);
                cmd.Parameters.AddWithValue("@repeat",wo1.repeats);
                cmd.Parameters.AddWithValue("@interval",wo1.interval_days);

                cmd.ExecuteNonQuery();

                temp = true;

                return temp;

            }
            catch (Exception exr)
            {
                
                throw;
            }

            if (temp == true) return true;
            else return false;
        }

        public bool searchWorkouts(Buisness_Logic.workout wrk)
        {
            bool temp = false;

            try
            {
                DataLayer.dbConnect workoutSearch= new DataLayer.dbConnect();
                workoutSearch.openConnection();
                
                string query1 = "SELECT * FROM tbl_workout WHERE w_name=@workout";

                SqlCommand cmd1 = new SqlCommand(query1, workoutSearch.getConnection());

                cmd1.Parameters.AddWithValue("@workout", wrk.workout_name);
                DataTable dtq = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
              //  workout wrk = new workout();
                da1.Fill(dtq);

                if (dtq.Rows.Count > 0)
                {
                    wrk.id = int.Parse(dtq.Rows[0]["w_id"].ToString());
                    wrk.workout_name = dtq.Rows[0]["w_name"].ToString();
                    wrk.type = dtq.Rows[0]["type"].ToString();
                    wrk.BMI_rate = double.Parse(dtq.Rows[0]["BMI_rate"].ToString());
                    wrk.fat_level = double.Parse(dtq.Rows[0]["fat_level"].ToString());
                    wrk.repeats = int.Parse(dtq.Rows[0]["repeats"].ToString());
                    wrk.interval_days = dtq.Rows[0]["interval_days"].ToString();
                    

                    temp = true;
                }
                workoutSearch.closeConnection();

               
            }
            catch (Exception exp)
            {

                throw;
            }

            if (temp == true) return true;
            else return false;


        }
    }
}
