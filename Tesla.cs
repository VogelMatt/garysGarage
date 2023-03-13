namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

       
    }
}