namespace ScrapItems
{
    public class SurgicalMask : IItem
    {
        public string getName()
        {
            return "surgicalmask";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Surgical Mask";
        }
    }
}