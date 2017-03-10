using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.RaceTracks;

namespace RaceCar.Core.Strategies
{
    public interface IRaceStrategy
    {
        ICarConfigurations Execute(ICarConfigurations carConfigurations, IRaceTrack raceTrack);
    }
}
