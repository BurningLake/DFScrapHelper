namespace ScrapItems
{
    public class Nero5A : IItem
    {
        public string getName()
        {
            return "nerotonin5a";
        }

        public int getPrice()
        {
            return 15000;
        }

        public override string ToString()
        {
            return "Nerotonin 5A";
        }
    }
}