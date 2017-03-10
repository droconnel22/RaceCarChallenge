using System;
using System.Linq;
using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.Cars;
using RaceCar.Core.Entities.RaceTracks;

// OrderBy is stable (preserves duplicaltes) quick sorts O(N log N) under the covers.
namespace RaceCar.Core.Strategies
{
    public class FullRaceCompletionStrategy : IRaceStrategy
    {
       public ICarConfigurations Execute(ICarConfigurations carConfigurations, IRaceTrack raceTrack)
        {
           if (carConfigurations is EmptyCarConfigurations || raceTrack is EmptyRaceTrack)
                    throw new ArgumentException("You must specify correct values for car configurations or the race track");

           var results =
               carConfigurations
                   .GetAllCarConfigurations()
                   .ToDictionary(cc => CalculateCompletionTime(cc, raceTrack), cc => cc);

            return new CarConfigurationResults(results);
        }

        private double CalculateCompletionTime(ICarConfiguration car, IRaceTrack raceTrack) => 
            car.LapTime.TotalMinutes * raceTrack.LapsToComplete + CalculateRequiredPitStops(car, raceTrack) * raceTrack.PitStopTimeSpan.TotalMinutes;

        private int CalculateRequiredPitStops(ICarConfiguration car, IRaceTrack raceTrack) =>
         (int)(raceTrack.LapsToComplete / (car.FuelCapacity / car.AverageFuelConsumptionPerLap));
    }
}