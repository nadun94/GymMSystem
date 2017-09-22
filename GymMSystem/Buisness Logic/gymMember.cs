using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMSystem.Buisness_Logic
{
    class gymMember : member
    {
        private double BMI_ratio;
        private string jdate;

       
        public string email { get; set; }
        public string paymentPlan { get; set; }
     
        public double height { get; set; }
        public double weight { get; set; }
        public double fatLevel { get; set; }
        public double BMIratio {

            get
            {

                BMI_ratio = (height * height) / weight;
                return BMI_ratio;

            }
           private set
            {
                //if (!string.IsNullOrWhiteSpace(height.ToString()) && string.IsNullOrWhiteSpace(weight.ToString()))
                

                    BMI_ratio = (height * height) / weight;
                
            }
           
        }

        public string joinedDate {

            get
            {
                jdate = DateTime.Today.ToShortDateString();
                return jdate;
            }

            set
            {
                
            }

        }

  



        public byte[] photo { get; set; }

    }

    








}
