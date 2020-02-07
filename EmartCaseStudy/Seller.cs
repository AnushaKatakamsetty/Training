using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmartCaseStudy
{
    class Seller:SellerBO
    {
        //int sid;
        //string suser_name;
        //string password;
        //string company_name;
        //string GST;
        //string Poastal_address;
        //string Website;
        //string email_id;
        //int contact_no;
        public Seller()
        { }
        public Seller(int sid, string suser_name, string password, string company_name, string GST, string Poastal_address, string Website, string email_id, double contact_no) : base(sid, suser_name, password, company_name, GST, Poastal_address, Website, email_id, contact_no)
        {
            this.sid = sid;
            this.suser_name = suser_name;
            this.password = password;
            this.company_name = company_name;
            this.GST = GST;
            this.Poastal_address = Poastal_address;
            this.Website = Website;
            this.email_id = email_id;
            this.contact_no = contact_no;
        }
    }
}

//DateTime CreatedDate = Convert.ToDateTime(DateTime.Now);
