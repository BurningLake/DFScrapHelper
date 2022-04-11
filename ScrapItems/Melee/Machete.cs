namespace ScrapItems
{
    public class Machete : IItem
    {
        public string getName()
        {
            return "machete";
        }

        public int getPrice()
        {
            return 7400;
        }

        public override string ToString()
        {
            return "Machete";
        }
    }
}