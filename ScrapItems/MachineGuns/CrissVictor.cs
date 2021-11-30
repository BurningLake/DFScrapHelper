namespace ScrapItems
{
    public class CrissVictor : IItem
    {
        public string getName()
        {
            return "crissvictor";
        }

        public int getPrice()
        {
            return 44150;
        }

        public override string ToString()
        {
            return "Criss Victor";
        }
    }
}