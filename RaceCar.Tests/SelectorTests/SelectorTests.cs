using System;
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
            foreach (var carConfiguration in results.GetAllCarConfigurations())
            {
                
            }

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RunRace_WhenGiven_InValid_CarConfigurations_AlwaysThrowsExecption()
        {
            IRaceTrack raceTrack = EmptyRaceTrack.GetInstance();
            ICarConfigurations carConfigurations = EmptyCarConfigurations.GetInstance();

            var selector = new RaceCarSetupSelector(new FullRaceCompletionStrategy(), carConfigurations, raceTrack);
            ICarConfigurations result = selector.RunRace();
        }
    }
}
