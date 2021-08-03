using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle,  ICompany
    {
        public string TruckSize { get; set; }
        public bool IsCompack { get; set; }
        public string LicensePlateNum { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public string HeadLights { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
