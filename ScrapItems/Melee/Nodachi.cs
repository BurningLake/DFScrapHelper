namespace ScrapItems
{
    public class Nodachi : IItem
    {
        public string getName()
        {
            return "nodachi";
        }

        public int getPrice()
        {
            return 24250;
        }

        public override string ToString()
        {
            return "Nodachi";
        }
    }
}