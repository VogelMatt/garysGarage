public interface IElectricVehicle
{
    int CurrentChargePercentage { get; set; }
    
     void ChargeBattery();
}
