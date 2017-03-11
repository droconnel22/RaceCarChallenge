using RaceCar.Core.Entities.Cars;
using RaceCar.Core.Entities.RaceTracks;

namespace RaceCar.Core.Strategies.Calculators
{
    public interface IRaceCalculator
    {
        double CalculateCompletionTime(ICarConfiguration car, IRaceTrack raceTrack);

        int CalculateRequiredPitStops(ICarConfiguration car, IRaceTrack raceTrack);
    }
}
