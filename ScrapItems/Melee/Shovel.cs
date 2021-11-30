namespace ScrapItems
{
    public class Shovel : IItem
    {
        public string getName()
        {
            return "shovel";
        }

        public int getPrice()
        {
            return 2550;
        }

        public override string ToString()
        {
            return "Shovel";
        }
    }
}