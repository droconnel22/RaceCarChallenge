using System;

namespace RaceCar.Core.Entities.Cars
{
    public class CarConfiguration : ICarConfiguration
    {
        public CarConfiguration(double fuelCapacity, TimeSpan lapTime, double averageFuelConsumptionPerLap)
        {

            if(lapTime == null) throw  new ArgumentNullException(nameof(lapTime));

            FuelCapacity = fuelCapacity;
            LapTime = lapTime;
            AverageFuelConsumptionPerLap = averageFuelConsumptionPerLap;
        }

        public double FuelCapacity { get; }
        public TimeSpan LapTime { get; }
        public double AverageFuelConsumptionPerLap { get; }
    }
}