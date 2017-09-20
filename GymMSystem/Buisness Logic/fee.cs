using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMSystem.Buisness_Logic
{
    class fee
    {
        private DateTime paymentDate;
        private int memberID;
        public int feeId { get; set; }
        private string memberType;
        private string _paymetPlan;
        private double packageFee;
        public double amount { get; set; }
        public string service { get; set; }
        public DateTime validDate { get; set; }
        public DateTime paidDate { get; set; }


        public List<gymMember> gymMemberList { get; set; }

        
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

        public double calculateFee()
        {
            amount = packageFee; // + other relevent values
                return amount;

        }
        public DateTime lastValidPaymentDate
        {

            get
            {
                return paymentDate;
            }

            set
            {
                paymentDate = DateTime.Today;
            }
        }

        public int memberId {

            get {

                return memberID;
            }

            set { }
        }

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


    }
    
}
