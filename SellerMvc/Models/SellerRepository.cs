using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerMvc.Models
{
    public class SellerRepository:InterfaceSeller
    {
        private List<Seller> slist;
        public SellerRepository()
        {
            slist = new List<Seller>(){ new Seller(1,"SK","123","CTS","YES","NoTHing","Chennai","cts.com","cts@gmail.com",7989209071),
            new Seller(2,"SK1","213","CTS","YES","NoTHing","Chennai","cts.com","cts@gmail.com",7989071),
            new Seller(3,"SK2","321","CTS","YES","NoTHing","Chennai","cts.com","cts@gmail.com",7989209)};
        }
        public Seller GetSeller(int id)
        {
            Seller s = slist.FirstOrDefault(e => e.sid == id);
            return s;
        }
        public List<Seller> DiaplayDetails()
        {
            return slist;
        }
    }
}
