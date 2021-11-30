namespace ScrapItems
{
    public class AlphaBull : IItem
    {
        public string getName()
        {
            return "alphabull";
        }

        public int getPrice()
        {
            return 40050;
        }

        public override string ToString()
        {
            return "Alpha Bull";
        }
    }
}