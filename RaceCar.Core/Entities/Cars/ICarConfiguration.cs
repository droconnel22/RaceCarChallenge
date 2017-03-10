using System;

namespace RaceCar.Core.Entities.Cars
{
    public interface ICarConfiguration
    {
        double FuelCapacity { get; }

        TimeSpan LapTime { get; }

        double AverageFuelConsumptionPerLap { get; }
    }
}
