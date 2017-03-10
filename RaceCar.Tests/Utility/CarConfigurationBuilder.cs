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
                new CarConfiguration(32, new TimeSpan(0, 0, 15, 0), 2),
                new CarConfiguration(16, new TimeSpan(0, 0, 17, 0), 2),
                new CarConfiguration(24, new TimeSpan(0, 0, 18, 0), 4),
                new CarConfiguration(16, new TimeSpan(0, 0, 14, 0), 3),
            };

            return new CarConfigurations(carConfigurationList);
        }

        internal static ICarConfigurations GetZeroValues()
        {
           var carConfigurationList = new ICarConfiguration[4]
            {
                new CarConfiguration(32, new TimeSpan(0, 0, 0, 0), 0),
                new CarConfiguration(16, new TimeSpan(0, 0, 0, 0), 0),
                new CarConfiguration(24, new TimeSpan(0, 0, 0, 0), 0),
                new CarConfiguration(16, new TimeSpan(0, 0, 0, 0), 0),
            };

            return new CarConfigurations(carConfigurationList);
        }

    }
}
