using RaceCar.Core.Entities.Cars;
using RaceCar.Core.Entities.RaceTracks;

namespace RaceCar.Core.Strategies.Calculators
{
    public class FullRaceCalculator : IRaceCalculator
    {
        public double CalculateCompletionTime(ICarConfiguration car, IRaceTrack raceTrack)  =>
             (car.LapTime.Minutes * raceTrack.LapsToComplete) + (CalculateRequiredPitStops(car, raceTrack) * raceTrack.PitStopTimeSpan.Minutes);

        public int CalculateRequiredPitStops(ICarConfiguration car, IRaceTrack raceTrack) =>
              (int)(raceTrack.LapsToComplete / (car.FuelCapacity / car.AverageFuelConsumptionPerLap));
    }
}