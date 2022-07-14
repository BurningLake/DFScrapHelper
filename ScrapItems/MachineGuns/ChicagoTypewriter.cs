namespace ScrapItems
{
    public class ChicagoTypewriter : IItem
    {
        public string getName()
        {
            return "chicagotypewriter";
        }

        public int getPrice()
        {
            return 14750;
        }

        public override string ToString()
        {
            return "Chicago Typewriter";
        }
    }
}