namespace ScrapItems
{
    public class CrashHelmet : IItem
    {
        public string getName()
        {
            return "crashhelmet";
        }

        public int getPrice()
        {
            return 2450;
        }

        public override string ToString()
        {
            return "Crash Helmet";
        }
    }
}