using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class GPS : IGPS
    {
        public void Navigate()
        {
            Console.WriteLine("Navigate from GPS...");
        }
    }
}
