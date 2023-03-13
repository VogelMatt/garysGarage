using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}