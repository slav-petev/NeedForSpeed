using NeedForSpeed.Models.Races;
using NeedForSpeed.Models.States.Car.Implementations;
using NeedForSpeed.Models.States.Car.Interfaces;
using NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Interfaces;
using System.Text;

namespace NeedForSpeed.Models.Cars
{
    public abstract class Car
    {
        private ICarState _carState;

        public string Brand { get; }
        public string Model { get; }
        public int YearOfProduction { get; }
        public virtual int HorsePower { get; private set; }
        public int Acceleration { get; }
        public virtual int Suspension { get; private set; }
        public int Durability { get; }

        protected Car(string brand, string model,
            int yearOfProduction, int horsePower,
            int acceleration, int suspension,
            int durability)
        {
            _carState = new CarAvailableState();

            Brand = brand;
            Model = model;
            YearOfProduction = yearOfProduction;
            HorsePower = horsePower;
            Acceleration = acceleration;
            Suspension = suspension;
            Durability = durability;
        }

        public void Park()
        {

        }

        public void Tune(int tuneIndex, string addOn)
        {
            _carState = _carState.Tune(() =>
            {
                HorsePower += tuneIndex;
                Suspension = Suspension - tuneIndex / 2;
                TuneInternal(tuneIndex, addOn);
            });
        }

        protected abstract void TuneInternal(int tuneIndex, string addOn);

        public void EnterRace(Race race)
        {
            _carState = _carState.EnterRace(() =>
                race.AddParticipant(this));
        }

        public int CalculatePerformancePoints(
            IPerformanceStrategy strategy)
        {
            return strategy.CalculateOverallPerformance(this);
        }

        public override string ToString()
        {
            var carBuilder = new StringBuilder();
            carBuilder.AppendFormat("{0} {1} {2} ",
                Brand, Model, YearOfProduction);
            carBuilder.AppendFormat("{0} HP, {1} m/h in 1 s ",
                HorsePower, Acceleration);
            carBuilder.AppendFormat("{0} Suspension force, {1} Durability",
                Suspension, Durability);

            return carBuilder.ToString();
        }
    }
}
