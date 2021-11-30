namespace ScrapItems
{
    public class Vulcan : IItem
    {
        public string getName()
        {
            return "vulcan";
        }

        public int getPrice()
        {
            return 48500;
        }

        public override string ToString()
        {
            return "Vulcan";
        }
    }
}