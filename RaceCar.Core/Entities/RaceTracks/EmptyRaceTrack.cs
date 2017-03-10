using System;

namespace RaceCar.Core.Entities.RaceTracks
{
    public class EmptyRaceTrack : IRaceTrack
    {
        [ThreadStatic]
        private static IRaceTrack instance;

        private EmptyRaceTrack()
        {
        }

        public static IRaceTrack GetInstance()
        {
            if(instance == null)
                instance = new EmptyRaceTrack();
            return instance;
        }

        public double LapDistance => 0.0;
        public int LapsToComplete => 0;
        public TimeSpan PitStopTimeSpan => TimeSpan.Zero;
        public double GetTotalDistance() => 0.0;
    }
}