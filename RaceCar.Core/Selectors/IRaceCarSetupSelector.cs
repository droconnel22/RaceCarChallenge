using RaceCar.Core.Entities.CarCollections;

namespace RaceCar.Core.Selectors
{
    //Assume this is run by a controller, console or client library.
    public interface IRaceCarSetupSelector
    {
      ICarConfigurations RunRace();
    }
}
