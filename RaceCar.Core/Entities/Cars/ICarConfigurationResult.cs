namespace RaceCar.Core.Entities.Cars
{
    public interface ICarConfigurationResult
    {
        double TotalRaceTime { get; }

        ICarConfiguration CarConfiguration { get; }
    }
}
