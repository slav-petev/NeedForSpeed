using NeedForSpeed.Models.Cars;

namespace NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Interfaces
{
    public interface IPerformanceStrategy
    {
        int CalculateOverallPerformance(Car car);
    }
}
