using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerMvc.Models
{
    public interface InterfaceSeller
    {
        Seller GetSeller(int id);
        List<Seller> DiaplayDetails();
    }
}
