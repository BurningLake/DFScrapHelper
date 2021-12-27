namespace ScrapItems
{
    public class Greyhawk : IItem
    {
        public string getName()
        {
            return "greyhawk";
        }

        public int getPrice()
        {
            return 57650;
        }

        public override string ToString()
        {
            return "Greyhawk 55";
        }
    }
}