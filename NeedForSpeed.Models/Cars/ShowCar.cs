using System.Text;

namespace NeedForSpeed.Models.Cars
{
    public class ShowCar : Car
    {
        public int Stars { get; private set; }

        public ShowCar(string brand, string model,
            int yearOfProduction, int horsePower,
            int acceleration, int suspension,
            int durability, int stars)
            : base(brand, model, yearOfProduction, 
                   horsePower, acceleration, suspension,
                   durability)
        {
            Stars = stars;
        }

        protected override void TuneInternal(int tuneIndex, string addOn)
        {
            Stars += tuneIndex;
        }

        public override string ToString()
        {
            var baseCarInfo = base.ToString();
            var showCarBuilder = new StringBuilder(
                baseCarInfo);
            showCarBuilder.AppendFormat("{0} *", Stars);

            return showCarBuilder.ToString();
        }
    }
}
