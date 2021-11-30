namespace ScrapItems
{
    public class PAW20 : IItem
    {
        public string getName()
        {
            return "paw20";
        }

        public int getPrice()
        {
            return 48500;
        }

        public override string ToString()
        {
            return "PAW-20";
        }
    }
}