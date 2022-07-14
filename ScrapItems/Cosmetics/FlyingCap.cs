namespace ScrapItems
{
    public class FlyingCap : IItem
    {
        public string getName()
        {
            return "flyingcap";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Flying Cap";
        }
    }
}