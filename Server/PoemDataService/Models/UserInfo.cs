using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemDataService.Models
{
   public class UserInfo
    {
        public UserInfo()
        {
        }

        public int id { get; set; }
        public string account { get; set; }
        public string password { get; set; }


        public UserInfo(string account, string password)
        {
            this.account = account;
            this.password = password;
        }

        public override bool Equals(object obj)
        {
            return obj is UserInfo info &&
                   account == info.account &&
                   password == info.password;
        }

        public override int GetHashCode()
        {
            int hashCode = -825239340;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(account);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            return hashCode;
        }
    }
}
