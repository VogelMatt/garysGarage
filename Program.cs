using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                CurrentChargePercentage = 68,
                BatteryKWh = 1700,
                MainColor = "Red"
            };

            Zero fx = new Zero()
            {
                CurrentChargePercentage = 69
            };
            Tesla modelS = new Tesla() { CurrentChargePercentage = 79 };



            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"the {ev} battery's current charge is {ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"the {ev} battery has been charged to {ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram()
            {
                CurrentTankPercentage = 18
            };
            Cessna cessna150 = new Cessna();

            List <???> gasVehicles = new List<???> () {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (??? gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
