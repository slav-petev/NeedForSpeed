using NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Interfaces;
using NeedForSpeed.Models.Cars;

namespace NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Implementations
{
    public class EnginePerformanceStrategy : IPerformanceStrategy
    {
        public int CalculateOverallPerformance(Car car)
        {
            return car.HorsePower / car.Acceleration;
        }
    }
}
