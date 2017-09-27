using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMSystem.Buisness_Logic
{
    class fee
    {
       
      
        private string memberType;
        private string _paymetPlan;
        private double packageFee;
        private string validDate;
        public int feeId { get; set; }
        public int memberID { get; set; }
        public double amount { get; set; }
        public string service { get; set; }
      
        public string paidDate { get; set; }
        public string lastVPaymentDate { get; set; }

      //  public List<gymMember> gymMemberList { get; set; }

        
        public double feeForPackage {

            get
            {                                   // this is taken from seperate table which stored package information 
                return packageFee;
            }

            set
            {       //get value from database
                packageFee = value;
            }
        }

        public string paymentPlan
        {
            get
            {
                //get from gym member table
                return _paymetPlan;
            }
            set
            {
                _paymetPlan = value;
            }
        }

        public string calculateValidDate()
        {
            int year, month, date;

            year = DateTime.Parse(lastVPaymentDate).Year;
            month = DateTime.Parse(lastVPaymentDate).Month;
            date = DateTime.Parse(lastVPaymentDate).Day;
            var dat = new DateTime(year, month, date);

            if(paymentPlan == "Monthly")
            {
                validDate = dat.AddMonths(1).ToShortDateString();
            }
            else if(paymentPlan == "Half Year")
            {
                validDate = dat.AddMonths(6).ToShortDateString();
            }
            else if (paymentPlan == "Full Year")
            {
                validDate = dat.AddMonths(12).ToShortDateString();
            }

            return validDate;
        }



        public double calculateFee()
        {
            amount = packageFee; // + other relevent values
                return amount;

        }
       
        // paymentDate = DateTime.Today.ToShortTimeString();
      

        public string MemberType
        {

            get
            {
                // get memeber type from eg: gym member or areobic member
                return memberType;
            }
            set
            {
                memberType = value;
            }
        }

       

        public string PaymentvalidDate
        {
            get
            {
                return validDate;
            }
            set
            {

            }

        }


    }
    
}
