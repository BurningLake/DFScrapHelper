namespace ScrapItems
{
    public class FlyingGoggles : IItem
    {
        public string getName()
        {
            return "flyinggoggles";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Flying Goggles";
        }
    }
}