using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.RaceTracks;
using RaceCar.Core.Selectors;
using RaceCar.Core.Strategies;
using RaceCar.Tests.Utility;

namespace RaceCar.Tests.SelectorTests
{
  
    [TestClass]
    public class SelectorTests
    {
        [TestMethod]
        public void RunRace_WhenGiven_Valid_CarConfigurations_AlwaysReturnsOrderCollectionByTime()
        {
            // Arrange.
            IRaceTrack raceTrack= RaceTrackBuilder.Build();
            ICarConfigurations carConfigurations = CarConfigurationBuilder.Build();

            var selector = new RaceCarSetupSelector(new FullRaceCompletionStrategy(),carConfigurations,raceTrack);

            // Act.
            ICarConfigurations results = selector.RunRace();

            // Assert.
            Assert.AreNotSame(typeof(EmptyCarConfigurations), results.GetType());
            
            var actualCarConfiguartion = results.GetAllCarConfigurations().ToArray();
            var expectedCarConfiguarations = TestHelper.GetCorrectCarConfigurationsResults();

            for (int i = 0; i < actualCarConfiguartion.Length; i++)
            {
                Assert.AreEqual(expectedCarConfiguarations[i].LapTime.TotalMinutes, actualCarConfiguartion[i].LapTime.TotalMinutes);
                Assert.AreEqual(expectedCarConfiguarations[i].AverageFuelConsumptionPerLap, actualCarConfiguartion[i].AverageFuelConsumptionPerLap);
                Assert.AreEqual(expectedCarConfiguarations[i].FuelCapacity, actualCarConfiguartion[i].FuelCapacity);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RunRace_WhenGiven_ValidCarConfigurations_WithBadValues_AlwaysThrowsExecption()
        {
            IRaceTrack raceTrack = RaceTrackBuilder.GetBadTrack();
            ICarConfigurations carConfigurations = CarConfigurationBuilder.GetZeroValues();

            IRaceCarSetupSelector selector = new RaceCarSetupSelector(new FullRaceCompletionStrategy(), carConfigurations,raceTrack);

            var results = selector.RunRace();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RunRace_WhenGiven_InValid_CarConfigurations_AlwaysThrowsExecption()
        {
            IRaceTrack raceTrack = EmptyRaceTrack.GetInstance();
            ICarConfigurations carConfigurations = EmptyCarConfigurations.GetInstance();

            var selector = new RaceCarSetupSelector(new FullRaceCompletionStrategy(), carConfigurations, raceTrack);
            ICarConfigurations results = selector.RunRace();
        }
    }
}
