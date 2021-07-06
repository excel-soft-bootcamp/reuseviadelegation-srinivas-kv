using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class Person
    {
        public void Talk(ITelephone telephone)
        {
            telephone.Call();
            telephone.Hang_Up();
        }

    }
}
