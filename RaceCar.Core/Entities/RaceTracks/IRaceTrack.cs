using System;

namespace RaceCar.Core.Entities.RaceTracks
{
    public interface IRaceTrack
    {
        double LapDistance { get; }

        int LapsToComplete { get; }

        TimeSpan PitStopTimeSpan { get; }

        double GetTotalDistance();
    }
}
