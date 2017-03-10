using System;

namespace RaceCar.Core.Entities.RaceTracks
{
    public class RaceTrack : IRaceTrack
    {
        public RaceTrack(double lapDistance, int lapsToComplete, TimeSpan pitStopTimeSpan)
        {
            LapDistance = lapDistance;
            LapsToComplete = lapsToComplete;
            PitStopTimeSpan = pitStopTimeSpan;
        }

        public double LapDistance { get; }
        public int LapsToComplete { get; }
        public TimeSpan PitStopTimeSpan { get; }
        public double GetTotalDistance() => this.LapDistance*this.LapsToComplete;
    }
}