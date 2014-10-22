namespace ComputerBuilder
{
    using System;
    using System.Collections.Generic;
    using ComputerParts;
    using Factories;

    internal class ComputerBuilder
    {
        public static void Main()
        {
            Dictionary<string, Computer> machines = new Dictionary<string, Computer>();
            var manufacturer = Console.ReadLine();

            machines = ComputerFactory.BuildComputers(manufacturer);

            while (true)
            {
                var userInput = Console.ReadLine();
                
                var inputParameters = userInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                var command = inputParameters[0];
                int commandValue = 0;

                if (inputParameters.Length > 1)
                {
                    commandValue = int.Parse(inputParameters[1]);
                }

                if (command == "Charge")
                {
                    machines["laptop"].ChargeBattery(commandValue);
                }
                else if (command == "Process")
                {
                    machines["server"].Process(commandValue);
                }
                else if (command == "Play")
                {
                    machines["pc"].Play(commandValue);
                }
                else if (command == "Exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }
    }
}