namespace ScrapItems
{
    public class SledgeHammer : IItem
    {
        public string getName()
        {
            return "sledgehammer";
        }

        public int getPrice()
        {
            return 12200;
        }

        public override string ToString()
        {
            return "Sledge Hammer";
        }
    }
}