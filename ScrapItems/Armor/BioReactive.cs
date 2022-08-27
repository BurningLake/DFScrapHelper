namespace ScrapItems
{
    public class BioReactive : IItem
    {
        public string getName()
        {
            return "bioreactive";
        }

        public int getPrice()
        {
            return 128250;
        }

        public override string ToString()
        {
            return "Bio Reactive";
        }
    }
}