using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Solid_S.Good
{
    internal class UserService
    {
        public void Register(User user)
        {
            user.Register();

            var notif = new NotifService();
            notif.Notif($"Hi : {user.Name},Register is success, FROM USER SERVICE");
        }
    }
}
