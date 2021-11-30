namespace ScrapItems
{
    public class ExterminatorReactive : IItem
    {
        public string getName()
        {
            return "exterminatorreactive_";
        }

        public int getPrice()
        {
            return 40250;
        }

        public override string ToString()
        {
            return "Exterminator Reactive";
        }
    }
}