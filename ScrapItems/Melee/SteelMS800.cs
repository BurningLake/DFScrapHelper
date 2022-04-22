namespace ScrapItems
{
    public class SteelMS800 : IItem
    {
        public string getName()
        {
            return "steelms800";
        }

        public int getPrice()
        {
            return 9650;
        }

        public override string ToString()
        {
            return "Steel MS800";
        }
    }
}