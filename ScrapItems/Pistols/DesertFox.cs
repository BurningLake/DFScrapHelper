namespace ScrapItems
{
    public class DesertFox : IItem
    {
        public string getName()
        {
            return "desertfox";
        }

        public int getPrice()
        {
            return 24350;
        }

        public override string ToString()
        {
            return "Desert Fox";
        }
    }
}