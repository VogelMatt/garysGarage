using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

        void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}