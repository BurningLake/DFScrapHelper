namespace ScrapItems
{
    public class FMMAG : IItem
    {
        public string getName()
        {
            return "fmmag";
        }

        public int getPrice()
        {
            return 40050;
        }

        public override string ToString()
        {
            return "FM MAG";
        }
    }
}