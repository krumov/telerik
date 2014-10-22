namespace ComputerBuilder.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ComputerParts;

    public class HPFactory
    {
        public static Dictionary<string, Computer> BuildHPComputers()
        {
            var machines = new Dictionary<string, Computer>();

            var pcRam = new Ram(2);
            var pcVideoCard = new VideoCardWithColor();
            var pcCpu = new Cpu(2, 32);
            var pcHdd = new[] { new HardDrive(500, false, 0) };
            machines["pc"] = new Computer(ComputerType.PC, pcCpu, pcRam, pcHdd, pcVideoCard, null);

            var serverRam = new Ram(32);
            var serverVideo = new VideoCardMonochrome();
            var serverCpu = new Cpu(4, 32);
            var serverHdd = new[] { new HardDrive(1000, false, 3) };
            machines["server"] = new Computer(ComputerType.SERVER, serverCpu, serverRam, serverHdd, serverVideo, null);

            var laptopCard = new VideoCardWithColor();
            var laptopRam = new Ram(4);
            var laptopCpu = new Cpu(2, 64);
            var laptopHdd = new[] { new HardDrive(500, false, 0) };
            machines["laptop"] = new Computer(ComputerType.LAPTOP, laptopCpu, laptopRam, laptopHdd, laptopCard, new ComputerParts.LaptopBattery());

            return machines;
        }
    }
}
