using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public class Truck : IVehicle, ICompany
    {
        public int BedSize { get; set; }
        public bool HasHitch { get; set; }
        public string LicensePlateNum { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public string HeadLights { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
