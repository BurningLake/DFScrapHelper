namespace ScrapItems
{
    public class ConstructionHelmet : IItem
    {
        public string getName()
        {
            return "constructionhelmet";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Construction Helmet";
        }
    }
}