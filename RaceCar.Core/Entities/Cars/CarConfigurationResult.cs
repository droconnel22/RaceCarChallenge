using System;

namespace RaceCar.Core.Entities.Cars
{
    public class CarConfigurationResult : ICarConfigurationResult
    {

        public CarConfigurationResult(double TotalRaceTime, ICarConfiguration carConfiguration)
        {
            if (TotalRaceTime <= 0)
                throw new ArgumentOutOfRangeException(nameof(TotalRaceTime));

            if (carConfiguration == null)
                this.CarConfiguration = EmptyCarConfiguration.GetInstance();

            this.TotalRaceTime = TotalRaceTime;
            this.CarConfiguration = carConfiguration;
        }

        public double TotalRaceTime { get; }
        public ICarConfiguration CarConfiguration { get; }
    }
}