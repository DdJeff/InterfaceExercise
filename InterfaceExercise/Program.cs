using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            //My Car
            var myCar = new Car();
                myCar.Doors = 4;
                myCar.Engine = "4 cylinder";
                myCar.HeadLights = "Bright";
                myCar.IsCompack = true;
                myCar.LicensePlateNum = "478JH894";
                myCar.Logo = "H";
                myCar.Name = "GTR";
                myCar.TruckSize = "Small";

            Console.WriteLine($"I got the best birthday present ever. I got a " +
                $"{myCar.Doors} door {myCar.Logo} {myCar.Name} with a {myCar.Engine}. I asked the dealer, so is it true its compack? he said its {myCar.IsCompack}." +
                $"engine. The only issue i have is that the truck is {myCar.TruckSize}, but the headlights are very " +
                $"{myCar.HeadLights}. It also has my favortie numbers in the tag number = {myCar.LicensePlateNum}.");

            //My Truck

            var myTruck = new Truck()
            {
                BedSize = 8,
                Doors = 2,
                Engine = "8 cylinder",
                HasHitch = false,
                HeadLights = "Bright",
                LicensePlateNum = "JDS84N03",
                Logo = "GKC",
                Name = "Openback"
                
            };

            Console.WriteLine($"I got the best birthday present ever. I got a " +
                $"{myTruck.Doors} door {myTruck.Logo} {myTruck.Name} with a {myTruck.Engine} I asked the dealer, so is it true its comes with a hitch ? he said its { myTruck.HasHitch}." + 
                $"The headlights are very {myTruck.HeadLights}" +
                $"It also has my favortie numbers in the tag number = {myTruck.LicensePlateNum} and a bedsize of {myTruck.BedSize}ft.");


            SUV mySUV = new SUV()
            {
                Engine = "6 cylinder",
                CargoSize = 4,
                Doors = 4,
                HasRack = true,
                HeadLights = "Bright",
                LicensePlateNum = "98JMDFOI",
                Logo = "Cat",
                Name = "Family Pictu"

            };
            Console.WriteLine($"I got the best birthday present ever. I got a " +
               $"{mySUV.Doors} door {mySUV.Logo} {mySUV.Name} with a {mySUV.Engine} I asked the dealer, so is it true its comes with a rack ? he said its { !mySUV.HasRack}." +
               $"The headlights are very {mySUV.HeadLights}" +
               $"It also has my favortie numbers in the tag number = {mySUV.LicensePlateNum} and a cargo of {mySUV.CargoSize}ft.");

        }
    }
}
