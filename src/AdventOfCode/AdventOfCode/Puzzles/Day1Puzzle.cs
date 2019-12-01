namespace AdventOfCode.Modules
{
   public class Day1Puzzle
    {
        private const int divider = 3;
        private const int substractor = 2;

        public int CalculateFuel(int mass) => (mass / divider) - substractor;
        
        public int SumOfMassRequirements(int mass)
        {
            int fuelLeft = mass;
            int sumFuel = 0;

            while (fuelLeft > 0)
            {
                fuelLeft = this.CalculateFuel(fuelLeft);
                if (fuelLeft < 0)
                    break;

                sumFuel += fuelLeft;
            }

            return sumFuel;
        }
    }
}
