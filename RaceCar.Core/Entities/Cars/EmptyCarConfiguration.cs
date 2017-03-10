using System;

namespace RaceCar.Core.Entities.Cars
{
    // Instead of handling nulls, passing nullable objects gives us cleaner implementations.
    // Singleton Pattern used for Empty Car State. 
    // When building this object and we encounter a failure we can return an special state object.
    // This means we do not have to constantly checking for nulls.
    public sealed class EmptyCarConfiguration : ICarConfiguration
    {
        [ThreadStatic]
        private static ICarConfiguration instance;

        private EmptyCarConfiguration()
        {
            
        }

        public static ICarConfiguration GetInstance()
        {
            if(instance == null)
                instance = new EmptyCarConfiguration();
            return instance;
        }

        public double FuelCapacity => 0.0;
        public TimeSpan LapTime => TimeSpan.Zero;
        public double AverageFuelConsumptionPerLap => 0.0;
    }
}