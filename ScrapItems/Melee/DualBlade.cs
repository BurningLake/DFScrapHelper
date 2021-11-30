namespace ScrapItems
{
    public class DualBlade : IItem
    {
        public string getName()
        {
            return "dualblade";
        }

        public int getPrice()
        {
            return 50000;
        }

        public override string ToString()
        {
            return "Dual Blade";
        }
    }
}