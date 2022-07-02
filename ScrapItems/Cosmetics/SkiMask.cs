namespace ScrapItems
{
    public class SkiMask : IItem
    {
        public string getName()
        {
            return "skimask";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Ski Mask";
        }
    }
}