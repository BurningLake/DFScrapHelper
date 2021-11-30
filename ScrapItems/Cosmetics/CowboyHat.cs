namespace ScrapItems
{
    public class CowboyHat : IItem
    {
        public string getName()
        {
            return "cowboyhat";
        }

        public int getPrice()
        {
            return 6100;
        }

        public override string ToString()
        {
            return "Cowboy Hat";
        }
    }
}