namespace ScrapItems
{
    public class Turban : IItem
    {
        public string getName()
        {
            return "turban";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Turban";
        }
    }
}