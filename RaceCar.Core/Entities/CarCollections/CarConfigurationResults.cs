using System;
using System.Collections.Generic;
using System.Linq;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Core.Entities.CarCollections
{
    /// <summary>
    /// The requirements only specificy the result as "The purpose of the program is to rank a given set of car configurations for a particular, given, race track, based on the full race completion time."
    /// This does not say How. So I assumed that at first glance the results would be an order list of car configurations
    /// But I also thought that the test practictionor might want to see the results of the calculations and then get ordered.
    /// Ordering and calculation can be thought of two seperate requirments. 
    /// Where the calcuation is the domain of the strategy and the ordering is the domain of the result set to the client.
    /// What if the order where to change? Do we change the entire strategy? 
    /// The comprimise was this class, which fullfills the same contract, but intakes a dictionary of the results.
    /// The output is still a list of the car configurations, but for debugging and changing conditions, the order logic can and should be manipulated here.
    /// </summary>

    public class CarConfigurationResults : ICarConfigurations
    {
        private readonly IEnumerable<ICarConfigurationResult> results;

        public CarConfigurationResults(IEnumerable<ICarConfigurationResult> results)
        {
            if(results ==null)
                throw new ArgumentNullException(nameof(results));

            this.results = results;
        }

        // OrderBy is stable (preserves duplicaltes) quick sorts O(N log N) under the covers.
        public IEnumerable<ICarConfiguration> GetAllCarConfigurations() =>
            this.results
                .OrderBy(rd => rd.TotalRaceTime)
                .Select(rdd => rdd.CarConfiguration)
                .ToList();
    }
}