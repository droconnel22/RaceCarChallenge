using System;
using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Tests.Utility
{
    public static class CarConfigurationBuilder
    {
        public static ICarConfigurations Build()
        {
            //Use array for known fixed set. 
            //Use of Dynamic List here is uneeded.
            var carConfigurationList = new ICarConfiguration[4]
            {
                new CarConfiguration(17, new TimeSpan(0, 0, 15, 30), 9),
                new CarConfiguration(16, new TimeSpan(0, 0, 17, 50), 5),
                new CarConfiguration(18, new TimeSpan(0, 0, 18, 1), 10),
                new CarConfiguration(10, new TimeSpan(0, 0, 14, 20), 12),
            };

            return new CarConfigurations(carConfigurationList);
        }

    }
}
