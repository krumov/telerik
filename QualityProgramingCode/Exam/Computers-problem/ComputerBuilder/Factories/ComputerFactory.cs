namespace ComputerBuilder.Factories
{
    using System.Collections.Generic;
    using ComputerParts;

    public class ComputerFactory
    {      
        public ComputerFactory()
        {
        }

        public static Dictionary<string, Computer> BuildComputers(string computerMake)
        {
            Dictionary<string, Computer> machines = new Dictionary<string, Computer>();
            if (computerMake == "HP")
            {
                machines = HPFactory.BuildHPComputers();
            }
            else if (computerMake == "Dell")
            {
                machines = DellFactory.BuildDellComputers();
            }

            return machines;
        }
    }
}
