namespace ScrapItems
{
    public class Wakizashi : IItem
    {
        public string getName()
        {
            return "wakizashi";
        }

        public int getPrice()
        {
            return 22100;
        }

        public override string ToString()
        {
            return "Wakizashi";
        }
    }
}