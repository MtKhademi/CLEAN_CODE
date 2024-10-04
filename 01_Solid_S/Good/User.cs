using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Solid_S.Good
{
    internal class User
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public bool IsValid()
        {
            return true;
        }

        public void Register()
        {
            //-> Validation
            IsValid();

            //-> SAVE
        }
    }
}
