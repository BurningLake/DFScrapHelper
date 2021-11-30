namespace ScrapItems
{
    public class TrenchKnife : IItem
    {
        public string getName()
        {
            return "trenchknife";
        }

        public int getPrice()
        {
            return 5450;
        }

        public override string ToString()
        {
            return "Trench Knife";
        }
    }
}