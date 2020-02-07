using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class Buyer:BuyerBO
    {
        //public int bid { get; set; }
        //public string buser_name { get; set; }
        //public string password { get; set; }
        //string email_id { get; set; }
        //public  double mobile_no { get; set; }
        //public string address { get; set; }
        //public DateTime CreatedDate { get; set; }
        
        public Buyer(int bid, string buser_name,string password, double mobile_no, string email_id,DateTime CreatedDate)
        {
       
            this.bid = bid;
            this.buser_name = buser_name;
            this.password = password;
            this.mobile_no = mobile_no;
            this.email_id = email_id;
            this.address = address;
            this.CreatedDate = CreatedDate;

        }
        
       
    }
}

