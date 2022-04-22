namespace ScrapItems
{
    public class SIC550 : IItem
    {
        public string getName()
        {
            return "sic550";
        }

        public int getPrice()
        {
            return 16925;
        }

        public override string ToString()
        {
            return "SIC 550";
        }
    }
}