namespace ComputerParts
{
    public class Ram
    {
        private readonly int ramCapacity;
        private int storedValue;       

        public Ram(int ramCapacity)
        {
            this.ramCapacity = ramCapacity;
        }

        public void SaveValue(int newValue)
        {
            this.storedValue = newValue;
        }

        public int LoadValue()
        {
            return this.storedValue;
        }
    }
}