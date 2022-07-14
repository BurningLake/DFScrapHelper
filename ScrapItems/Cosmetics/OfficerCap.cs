namespace ScrapItems
{
    public class OfficerCap : IItem
    {
        public string getName()
        {
            return "officerscap";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Officer's Cap";
        }
    }
}