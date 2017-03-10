using System;
using RaceCar.Core.Entities.CarCollections;
using RaceCar.Core.Entities.RaceTracks;
using RaceCar.Core.Strategies;

// Set Defaults. 
// Typically IoC would inject the instances in the constructor.
// But today I am demonstrating Empty Objects & DoI. 
// We can have guard clauses, or altenartively pass empty objects.
namespace RaceCar.Core.Selectors
{
    public class RaceCarSetupSelector : IRaceCarSetupSelector
    {
        private readonly ICarConfigurations carConfigurations;

        private readonly IRaceTrack raceTrack;

        private readonly IRaceStrategy raceStrategy;
      
        public RaceCarSetupSelector(IRaceStrategy strategy, ICarConfigurations carConfigurations, IRaceTrack raceTrack)
        {
            if(strategy == null)
                throw new ArgumentNullException(nameof(strategy));
            this.raceStrategy = strategy;

            this.carConfigurations = carConfigurations ?? EmptyCarConfigurations.GetInstance();
            this.raceTrack = raceTrack ?? EmptyRaceTrack.GetInstance();
        }
        
        public ICarConfigurations RunRace() => this.raceStrategy.Execute(this.carConfigurations, this.raceTrack);
    }
}