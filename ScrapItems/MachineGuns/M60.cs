namespace ScrapItems
{
    public class M60 : IItem
    {
        public string getName()
        {
            return "m60";
        }

        public int getPrice()
        {
            return 40050;
        }

        public override string ToString()
        {
            return "M60";
        }
    }
}