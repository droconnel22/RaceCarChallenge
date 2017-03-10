using System;
using System.Collections.Generic;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Core.Entities.CarCollections
{
    public class EmptyCarConfigurations : ICarConfigurations
    {
        [ThreadStatic]
        private static ICarConfigurations instance;

        private EmptyCarConfigurations()
        {
        }

        public static ICarConfigurations GetInstance()
        {
            if(instance == null)
                instance = new EmptyCarConfigurations();
            return instance;
        }
     
        public IEnumerable<ICarConfiguration> GetAllCarConfigurations() => new ICarConfiguration[0];

        public void AddCarConfiguration(ICarConfiguration carConfiguration) {}
    }
}