using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Solid_S.Bad
{
    internal class User
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public void Register()
        {
            //-> Validation => send notif
            

            //-> SAVE => send notif

            //-> Notification
            var notif = new NotifService();
            notif.Notif($"Hi : {Name}, Register is success");
        }
    }
}
