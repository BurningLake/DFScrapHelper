namespace ScrapItems
{
    public class Grinder : IItem
    {
        public string getName()
        {
            return "grinder";
        }

        public int getPrice()
        {
            return 20050;
        }

        public override string ToString()
        {
            return "Grinder";
        }
    }
}