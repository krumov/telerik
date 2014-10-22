namespace ComputerParts
{
    public class LaptopBattery
    {
        public LaptopBattery()
        {
            this.ChargeAmount = 100 / 2;
        }

        internal int ChargeAmount { get; set; }

        public void Charge(int p)
        {
            this.ChargeAmount += p;
            if (this.ChargeAmount > 100)
            {
                this.ChargeAmount = 100;
            }
            else if (this.ChargeAmount < 0)
            {
                this.ChargeAmount = 0;
            }
        }                
    }
}
