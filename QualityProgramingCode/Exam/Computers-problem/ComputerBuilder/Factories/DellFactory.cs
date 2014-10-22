namespace ComputerBuilder.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ComputerParts;

    public class DellFactory
    {
        public static Dictionary<string, Computer> BuildDellComputers()
        {
            var machines = new Dictionary<string, Computer>();

            var pcRam = new Ram(8);
            var pcVideoCard = new VideoCardWithColor();
            var pcCpu = new Cpu(4, 64);
            var pcHdd = new[] { new HardDrive(1000, false, 0) };
            machines["pc"] = new Computer(ComputerType.PC, pcCpu, pcRam, pcHdd, pcVideoCard, null);

            var serverRam = new Ram(64);
            var serverVideo = new VideoCardMonochrome();
            var serverCpu = new Cpu(8, 64);
            var serverHdd = new[] { new HardDrive(2000, false, 2) };
            machines["server"] = new Computer(ComputerType.SERVER, serverCpu, serverRam, serverHdd, serverVideo, null);

            var laptopRam = new Ram(8);
            var laptopVideoCard = new VideoCardWithColor();
            var laptopCpu = new Cpu(4, 32);
            var laptopHdd = new[] { new HardDrive(1000, false, 0) };
            machines["laptop"] = new Computer(ComputerType.LAPTOP, laptopCpu, laptopRam, laptopHdd, laptopVideoCard, new ComputerParts.LaptopBattery()); 
            
            return machines;
        }
    }
}
