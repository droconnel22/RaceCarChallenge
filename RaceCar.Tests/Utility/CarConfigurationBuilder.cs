using System;
using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Tests.Utility
{
    internal static class CarConfigurationBuilder
    {
        internal static ICarConfigurations Build()
        {
            //Use array for known fixed set. 
            //Use of Dynamic List here is uneeded.
            var carConfigurationList = new ICarConfiguration[4]
            {
                new CarConfiguration(17, new TimeSpan(0, 0, 15, 30), 1),
                new CarConfiguration(16, new TimeSpan(0, 0, 17, 50), 2),
                new CarConfiguration(18, new TimeSpan(0, 0, 18, 1), 2),
                new CarConfiguration(10, new TimeSpan(0, 0, 14, 20), 3)
            };

            return new CarConfigurations(carConfigurationList);
        }

    }
}
