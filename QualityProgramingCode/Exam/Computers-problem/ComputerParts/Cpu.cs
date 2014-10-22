namespace ComputerParts
{
    using System;

    public class Cpu
    {
        private readonly byte numberOfBits;
        private readonly byte numberOfCores;
        private Random randomGenerator = new Random();

        public Cpu(byte numberOfCores, byte numberOfBits) 
        {
            this.numberOfBits = numberOfBits;
            this.numberOfCores = numberOfCores;
        }
        
        public int GenerateRandomNumber(int a, int b)
        {
            int randomNumber;
            randomNumber = this.randomGenerator.Next(a, b);

            return randomNumber;
        }

        public string SquareNumber(int ramStoredValue)
        {
            int maxValueForCalculation = 0;

            if (this.numberOfBits == 32)
            {
                maxValueForCalculation = 500;
            }
            else if (this.numberOfBits == 64)
            {
                maxValueForCalculation = 1000;
            }

            var storedValue = ramStoredValue;

            if (storedValue < 0)
            {
                var result = string.Format("Number too low.");

                return result;
            }
            else if (storedValue > maxValueForCalculation)
            {
                var result = string.Format("Number too high.");

                return result;
            }
            else
            {
                int value = (int)Math.Pow(storedValue, 2);

                var result = string.Format("Square of {0} is {1}.", storedValue, value);

                return result;
            }
        }        
    }
}
