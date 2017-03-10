using System.Collections.Generic;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Core.Entities.CarCollections
{
    public interface ICarConfigurations
    {
        IEnumerable<ICarConfiguration> GetAllCarConfigurations();
        void AddCarConfiguration(ICarConfiguration carConfiguration);
    }
}
