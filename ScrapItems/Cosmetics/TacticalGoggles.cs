namespace ScrapItems
{
    public class TacticalGoggles : IItem
    {
        public string getName()
        {
            return "tacticalgoggles";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Tactical Goggles";
        }
    }
}