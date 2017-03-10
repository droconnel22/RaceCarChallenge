using System;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Tests.Utility
{
    internal static class TestHelper
    {
        internal static ICarConfiguration[] GetCorrectCarConfigurationsResults() =>
            new ICarConfiguration[4]
            {
                new CarConfiguration(16, new TimeSpan(0, 0, 14, 0), 3),
                new CarConfiguration(32, new TimeSpan(0, 0, 15, 0), 2),
                new CarConfiguration(16, new TimeSpan(0, 0, 17, 0), 2),
                new CarConfiguration(24, new TimeSpan(0, 0, 18, 0), 4),
            };
    }
}
