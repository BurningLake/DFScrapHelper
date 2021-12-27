namespace ScrapItems
{
    public class Painshot : IItem
    {
        public string getName()
        {
            return "painshot";
        }

        public int getPrice()
        {
            return 57650;
        }

        public override string ToString()
        {
            return "Painshot 10";
        }
    }
}