using System;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Tests.Utility
{
    internal static class TestHelper
    {
        internal static ICarConfiguration[] GetCorrectCarConfigurationsResults() =>
            new ICarConfiguration[4]
            {
                new CarConfiguration(10, new TimeSpan(0, 0, 14, 20), 3),
                new CarConfiguration(17, new TimeSpan(0, 0, 15, 30), 1),
                new CarConfiguration(16, new TimeSpan(0, 0, 17, 50), 2),
                new CarConfiguration(18, new TimeSpan(0, 0, 18, 1), 2),

            };
    }
}
