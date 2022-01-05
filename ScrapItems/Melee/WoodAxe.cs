namespace ScrapItems
{
    public class WoodAxe : IItem
    {
        public string getName()
        {
            return "woodaxe";
        }

        public int getPrice()
        {
            return 7400;
        }

        public override string ToString()
        {
            return "Wood Axe";
        }
    }
}