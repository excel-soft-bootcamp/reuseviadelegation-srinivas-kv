using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class Traveller
    {
        public void Travel(IGPS gPS)
        {
            gPS.Navigate();
        }
    }
}
