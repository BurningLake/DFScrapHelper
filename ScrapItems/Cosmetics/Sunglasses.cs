namespace ScrapItems
{
    public class Sunglasses : IItem
    {
        public string getName()
        {
            return "sunglass";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Sunglasses";
        }
    }
}