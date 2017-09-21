using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMSystem.Buisness_Logic
{
    class AreobicMember : member
    {
        private string stype;

        public string service_type
        {
            get
            {
                return stype;
            }
            set
            {
                stype = value;
            }
        }

       


    }
}
