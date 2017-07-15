using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeedForSpeed.Models.Cars
{
    public class PerformanceCar : Car
    {
        private readonly HashSet<string> _addOns = 
            new HashSet<string>();
        public IEnumerable<string> AddOns => _addOns;

        public override int HorsePower => base.HorsePower * 3 / 2;

        public override int Suspension => base.Suspension * 3 / 4;

        public PerformanceCar(string brand, string model,
            int yearOfProduction, int horsePower,
            int acceleration, int suspension,
            int durability, IEnumerable<string> addOns)
            : base(brand, model, yearOfProduction,
                   horsePower, acceleration, suspension,
                   durability)
        {
            foreach (var addOn in addOns)
            {
                _addOns.Add(addOn);
            }
        }

        protected override void TuneInternal(int tuneIndex, string addOn)
        {
            _addOns.Add(addOn);
        }

        public override string ToString()
        {
            var baseCarInfo = base.ToString();
            var performanceCarBuilder = new StringBuilder(
                baseCarInfo);

            var addOnsAsString = AddOns.Any()
                ? string.Join(", ", AddOns)
                : "None";
            performanceCarBuilder.AppendFormat("Add-ons: {0}",
                addOnsAsString);

            return performanceCarBuilder.ToString();
        }
    }
}
