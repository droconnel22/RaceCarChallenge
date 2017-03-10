using System;
using RaceCar.Core.Entities.RaceTracks;

namespace RaceCar.Tests.Utility
{
    //This might be trivial, but it gives us options should race track grow.
    //I would not implement a builder if I knew that this object graph would remain simple.
    //Let the builder object shoulder the responsibiilty of delievering the IRaceTrack contract
    //not the selectors job to know how to build a racetrack and its requirements.
    //Knowledge == liability.
    internal static class RaceTrackBuilder
    {
        //Little fun. Assumed 24 Hour Le Mans. See https://en.wikipedia.org/wiki/24_Hours_of_Le_Mans
        internal static IRaceTrack Build() => new RaceTrack(5233.53, 384,new TimeSpan(0,5,0));
    }
}
