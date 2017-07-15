using NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Interfaces;
using NeedForSpeed.Models.Cars;

namespace NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Implementations
{
    public class OverallPerformanceStrategy : IPerformanceStrategy
    {
        public int CalculateOverallPerformance(Car car)
        {
            return (car.HorsePower / car.Acceleration) +
                (car.Suspension + car.Durability);
        }
    }
}
