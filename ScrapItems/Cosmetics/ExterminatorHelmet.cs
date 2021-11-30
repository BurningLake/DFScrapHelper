namespace ScrapItems
{
    public class ExterminatorHelmet : IItem
    {
        public string getName()
        {
            return "exterminatorhelmet";
        }

        public int getPrice()
        {
            return 7012;
        }

        public override string ToString()
        {
            return "Exterminator Helmet";
        }
    }
}