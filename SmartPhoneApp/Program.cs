using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera = new Camera();
            GPS gps = new GPS();
            Telephone telephone = new Telephone();
            SmartPhone smartPhone = new SmartPhone();
            smartPhone._Camera(camera);
            smartPhone._GPS(gps);
            smartPhone._Telephone(telephone);
            Photographer photographer = new Photographer();
            Traveller traveller = new Traveller();
            Person person = new Person();
            photographer.Capture(smartPhone);
            traveller.Travel(smartPhone);
            person.Talk(smartPhone);
            Console.ReadLine();

        }
    }
}
