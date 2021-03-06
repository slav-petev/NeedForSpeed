﻿using System.Collections.Generic;
using NeedForSpeed.Models.Cars;
using System.Linq;
using NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Implementations;
using NeedForSpeed.Models.Strategies.CarPerformanceStrategies.Interfaces;
using System;

namespace NeedForSpeed.Models.Races
{
    public class DriftRace : Race
    {
        protected override IPerformanceStrategy Strategy => 
            new SuspensionPerformanceStrategy();

        public DriftRace(int length, string route, 
            int prizePool, IEnumerable<Car> participants) 
            : base(length, route, prizePool, participants)
        {
        }
    }
}
