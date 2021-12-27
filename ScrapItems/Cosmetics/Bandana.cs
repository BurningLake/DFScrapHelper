namespace ScrapItems
{
    public class Bandana : IItem
    {
        public string getName()
        {
            return "bandana";
        }

        public int getPrice()
        {
            return 5050;
        }

        public override string ToString()
        {
            return "Bandana";
        }
    }
}