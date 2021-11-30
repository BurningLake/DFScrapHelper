namespace ScrapItems
{
    public class TrenchCoat : IItem
    {
        public string getName()
        {
            return "trenchcoat";
        }

        public int getPrice()
        {
            return 7012;
        }

        public override string ToString()
        {
            return "Trench Coat";
        }
    }
}