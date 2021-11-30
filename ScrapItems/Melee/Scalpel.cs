namespace ScrapItems
{
    public class Scalpel : IItem
    {
        public string getName()
        {
            return "scalpel";
        }

        public int getPrice()
        {
            return 1650;
        }

        public override string ToString()
        {
            return "Scalpel";
        }
    }
}