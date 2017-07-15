using NeedForSpeed.Models.Cars;
using System.Collections.Generic;

namespace NeedForSpeed.Models.Garages
{
    public class Garage
    {
        public IEnumerable<Car> ParkedCars { get; }
    }
}
