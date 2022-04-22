namespace ScrapItems
{
    public class Kukri : IItem
    {
        public string getName()
        {
            return "kukri";
        }

        public int getPrice()
        {
            return 9650;
        }

        public override string ToString()
        {
            return "Kukri";
        }
    }
}