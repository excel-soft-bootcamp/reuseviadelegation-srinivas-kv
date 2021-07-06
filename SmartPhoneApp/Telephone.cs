using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class Telephone :  ITelephone
    {
        public void Call()
        {
            Console.WriteLine("Calling from Telephone...");
        }
        public void Hang_Up()
        {
            Console.WriteLine("Hang up from Telephone...");
        }
    }
}
