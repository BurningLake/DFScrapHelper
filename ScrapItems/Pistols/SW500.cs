namespace ScrapItems
{
    public class SW500 : IItem
    {
        public string getName()
        {
            return "sw500";
        }

        public int getPrice()
        {
            return 27125;
        }

        public override string ToString()
        {
            return "SW 500";
        }
    }
}