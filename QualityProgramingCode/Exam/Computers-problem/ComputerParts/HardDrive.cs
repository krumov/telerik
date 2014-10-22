namespace ComputerParts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HardDrive
    {
        private readonly bool isInRaid;
        private readonly int hardDrivesInRaid;
        private readonly List<HardDrive> collectionOfDrivesInRaid;
        private readonly int capacity;
        private readonly Dictionary<int, string> storageData;
               
        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.storageData = new Dictionary<int, string>();
            this.collectionOfDrivesInRaid = new List<HardDrive>();
        }

        private int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.collectionOfDrivesInRaid.Any())
                    {
                        return 0;
                    }

                    return this.collectionOfDrivesInRaid.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        // TODO: implement RAID array stuff...
        public void SaveDataToStorage(string data, int integerAddress)
        {
            this.storageData.Add(integerAddress, data);
        }

        public string LoadDataFromStorage(int integerAddress)
        {
           return this.storageData[integerAddress];
        }        
    }
}
