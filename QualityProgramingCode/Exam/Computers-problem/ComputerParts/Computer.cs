namespace ComputerParts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Computer
    {
        private readonly LaptopBattery battery;

        public Computer(
                ComputerType type,
                Cpu cpu, 
                Ram ram,
                IEnumerable<HardDrive> hardDrives,
                IVideoCard videoCard,
                LaptopBattery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;         
            this.battery = battery;
        }

        private IEnumerable<HardDrive> HardDrives { get; set; }

        private IVideoCard VideoCard { get; set; }

        private Cpu Cpu { get; set; }

        private Ram Ram { get; set; }

        public void Play(int guessNumber)
        {
            this.Cpu.GenerateRandomNumber(1, 10);
            var number = this.Ram.LoadValue();
            if (number != guessNumber)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.ChargeAmount));
        }

        public void Process(int data)
        { 
            this.Ram.SaveValue(data);
            var result = this.Cpu.SquareNumber(this.Ram.LoadValue());
            this.VideoCard.Draw(result);
        }
    }
}
