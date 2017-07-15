using NeedForSpeed.Models.States.Car.Interfaces;
using System;

namespace NeedForSpeed.Models.States.Car.Implementations
{
    public class CarAvailableState : ICarState
    {
        public ICarState EnterRace()
        {
            return new CarRacingState();
        }

        public ICarState Park()
        {
            return new CarParkedState();
        }

        public ICarState Unpark()
        {
            return this;
        }

        public ICarState Tune(Action action)
        {
            return this;
        }

        public ICarState EnterRace(Action enterRaceAction)
        {
            enterRaceAction();
            return new CarRacingState();
        }
    }
}
