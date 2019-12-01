namespace AdventOfCode.Modules
{
   public class FuelCalculator
    {
        private const int divider = 3;
        private const int substractor = 2;

        public int Calculate(int mass)
        {
            return (mass / divider) - substractor;
        }

        public int SumOfMassRequirements(int mass)
        {
            int fuelLeft = mass;
            int sumFuel = 0;

            while (fuelLeft > 0)
            {
                fuelLeft = this.Calculate(fuelLeft);
                if (fuelLeft < 0)
                    break;

                sumFuel += fuelLeft;
            }

            return sumFuel;
        }
    }
}
