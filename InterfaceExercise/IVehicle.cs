using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        public string LicensePlateNum { get; set; }

        public string Engine { get; set; }

        public int Doors { get; set; }
        public string HeadLights { get; set; }
    }
}
