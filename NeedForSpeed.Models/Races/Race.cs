using NeedForSpeed.Models.Cars;
using NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed.Models.Races
{
    public abstract class Race
    {
        public int Length { get; }
        public string Route { get; }
        public int PrizePool { get; }

        private readonly List<Car> _participants =
            new List<Car>();
        public IEnumerable<Car> Participants => _participants;

        protected abstract IPerformanceStrategy Strategy { get; }

        protected Race(int length, string route,
            int prizePool, IEnumerable<Car> participants)
        {
            Length = length;
            Route = route;
            PrizePool = prizePool;

            _participants.AddRange(participants);
        }

        public void AddParticipant(Car participant)
        {
            //TODO Check if we need to filter out duplicates
            _participants.Add(participant);
        }

        public IEnumerable<Car> GetWinners()
        {
            return Participants.OrderByDescending(c =>
                c.CalculatePerformancePoints(Strategy))
                    .Take(3);
        }
    }
}
