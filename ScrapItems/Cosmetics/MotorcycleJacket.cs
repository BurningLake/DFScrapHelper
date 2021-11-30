namespace ScrapItems
{
    public class MotorcycleJacket : IItem
    {
        public string getName()
        {
            return "motorcyclejacket";
        }

        public int getPrice()
        {
            return 6100;
        }

        public override string ToString()
        {
            return "Motorcycle Jacket";
        }
    }
}