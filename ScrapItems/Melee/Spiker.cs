namespace ScrapItems
{
    public class Spiker : IItem
    {
        public string getName()
        {
            return "spiker";
        }

        public int getPrice()
        {
            return 28850;
        }

        public override string ToString()
        {
            return "Spiker";
        }
    }
}