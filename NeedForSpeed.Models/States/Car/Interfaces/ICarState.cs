using System;

namespace NeedForSpeed.Models.States.Car.Interfaces
{
    public interface ICarState
    {
        ICarState EnterRace(Action enterRaceAction);
        ICarState Park();
        ICarState Unpark();
        ICarState Tune(Action tuneAction);
    }
}
