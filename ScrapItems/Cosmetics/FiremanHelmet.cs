namespace ScrapItems
{
    public class FiremanHelmet : IItem
    {
        public string getName()
        {
            return "firemanhelmet";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Fireman Helmet";
        }
    }
}