using NeedForSpeed.Models.States.Car.Interfaces;
using System;

namespace NeedForSpeed.Models.States.Car.Implementations
{
    public class CarParkedState : ICarState
    {
        public ICarState EnterRace()
        {
            return this;
        }

        public ICarState Park()
        {
            return this;
        }

        public ICarState Unpark()
        {
            return new CarAvailableState();
        }

        public ICarState Tune(Action action)
        {
            action();
            return this;
        }
    }
}
