using System;
using System.Collections.Generic;
using RaceCar.Core.Entities.Cars;

namespace RaceCar.Core.Entities.CarCollections
{
    public class CarConfigurations : ICarConfigurations
    {
        private readonly IList<ICarConfiguration> carList;

        public CarConfigurations(IEnumerable<ICarConfiguration> list)
        {
            if(list == null) throw  new ArgumentNullException(nameof(list));
            this.carList = new List<ICarConfiguration>(list);
        }

        public IEnumerable<ICarConfiguration> GetAllCarConfigurations() => this.carList;

        public void AddCarConfiguration(ICarConfiguration carConfiguration) => this.carList.Add(carConfiguration);
    }
}