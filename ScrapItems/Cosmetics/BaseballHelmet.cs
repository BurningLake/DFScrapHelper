namespace ScrapItems
{
    public class BaseballHelmet : IItem
    {
        public string getName()
        {
            return "baseball";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Baseball Helmet";
        }
    }
}