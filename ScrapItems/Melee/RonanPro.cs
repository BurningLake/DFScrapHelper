namespace ScrapItems
{
    public class RonanPro : IItem
    {
        public string getName()
        {
            return "ronanpro";
        }

        public int getPrice()
        {
            return 5450;
        }

        public override string ToString()
        {
            return "Ronan Pro";
        }
    }
}