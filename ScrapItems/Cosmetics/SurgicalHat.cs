namespace ScrapItems
{
    public class SurgicalHat : IItem
    {
        public string getName()
        {
            return "surgicalhat";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Surgical Hat";
        }
    }
}