namespace ScrapItems
{
    public class Sabre : IItem
    {
        public string getName()
        {
            return "sabre_";
        }

        public int getPrice()
        {
            return 9650;
        }

        public override string ToString()
        {
            return "Sabre";
        }
    }
}