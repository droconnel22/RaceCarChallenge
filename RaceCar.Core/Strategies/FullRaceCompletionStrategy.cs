using System;
using System.Linq;
using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.Cars;
using RaceCar.Core.Entities.RaceTracks;
using RaceCar.Core.Strategies.Calculators;

namespace RaceCar.Core.Strategies
{
    public class FullRaceCompletionStrategy : IRaceStrategy
    {
        private readonly IRaceCalculator fullRaceCalculator;

        public FullRaceCompletionStrategy(IRaceCalculator fullRaceCalculator)
        {
            if(fullRaceCalculator == null)
                throw  new ArgumentNullException(nameof(fullRaceCalculator));
            this.fullRaceCalculator = fullRaceCalculator;
        }


       public ICarConfigurations Execute(ICarConfigurations carConfigurations, IRaceTrack raceTrack)
        {
             if (carConfigurations is EmptyCarConfigurations || raceTrack is EmptyRaceTrack)
                    throw new ArgumentException("You must specify correct values for car configurations or the race track");

                var results =
                    carConfigurations
                        .GetAllCarConfigurations()
                        .Select(cc => new CarConfigurationResult(this.fullRaceCalculator.CalculateCompletionTime(cc, raceTrack),cc));

                return new CarConfigurationResults(results);
        }
    }
}