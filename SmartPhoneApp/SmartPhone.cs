using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneApp
{
    public class SmartPhone : ICamera, IGPS, ITelephone
    {
        ICamera _camera;
        IGPS _gps;
        ITelephone _telephone;
        public void _Camera(ICamera camera)
        {
            this._camera = camera;
        }
        public void _GPS(IGPS gps)
        {
            this._gps = gps;
        }
        public void _Telephone(ITelephone telephone)
        {
            this._telephone = telephone;
        }
        public void Click()
        {
            this._camera.Click();
        }
        public void Navigate()
        {
            this._gps.Navigate();
        }
        public void Call()
        {
            this._telephone.Call();
        }
        public void Hang_Up()
        {
            this._telephone.Hang_Up();
        }
    }
}
