namespace ScrapItems
{
    public class Sweeper : IItem
    {
        public string getName()
        {
            return "sweeper";
        }

        public int getPrice()
        {
            return 19250;
        }

        public override string ToString()
        {
            return "Sweeper";
        }
    }
}