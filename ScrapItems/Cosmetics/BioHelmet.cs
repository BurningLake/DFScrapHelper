namespace ScrapItems
{
    public class BioHelmet : IItem
    {
        public string getName()
        {
            return "biohelmet";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Bio Helmet";
        }
    }
}