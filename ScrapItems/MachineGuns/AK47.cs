namespace ScrapItems
{
    public class AK47 : IItem
    {
        public string getName()
        {
            return "ak47";
        }

        public int getPrice()
        {
            return 19250;
        }

        public override string ToString()
        {
            return "AK 47";
        }
    }
}