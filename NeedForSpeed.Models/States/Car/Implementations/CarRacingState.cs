using NeedForSpeed.Models.States.Car.Interfaces;
using System;

namespace NeedForSpeed.Models.States.Car.Implementations
{
    public class CarRacingState : ICarState
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
            return this;
        }

        public ICarState Tune(Action action)
        {
            return this;
        }
    }
}
