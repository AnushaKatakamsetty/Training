using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCModelValidations.Models;
namespace HandsOnMVCModelValidations.Repositories
{
    public class UserRepository
    {
        public static List<User> list = new List<User>()
        {new User(){
            Name = "Anusha",
            UserName = "anu",
            Password = "anu" }  };
        
        public UserRepository()
        {
 
        }
        public void Add(User item)
        {
            list.Add(item);
        }
        public User Validate(string uname,string pswd)
        {
            foreach(var item in list)
            {
                if (item.UserName == uname && item.Password == pswd)
                {
                    return item;
                }
            }
            return null;
        }
    }

}
