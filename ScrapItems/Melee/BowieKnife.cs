namespace ScrapItems
{
    public class BowieKnife : IItem
    {
        public string getName()
        {
            return "bowieknife";
        }

        public int getPrice()
        {
            return 450;
        }

        public override string ToString()
        {
            return "Bowie Knife";
        }
    }
}