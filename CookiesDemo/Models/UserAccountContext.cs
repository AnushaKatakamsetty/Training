using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiesDemo.Models
{
    public class UserAccountContext
    {

        public IEnumerable<object> UserAccount { get; internal set; }

        internal void Add(UserAccount uc)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
