namespace ScrapItems
{
    public class Katana : IItem
    {
        public string getName()
        {
            return "katana";
        }

        public int getPrice()
        {
            return 20050;
        }

        public override string ToString()
        {
            return "Katana";
        }
    }
}