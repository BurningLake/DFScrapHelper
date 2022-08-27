namespace ScrapItems
{
    public class NomadHelmet : IItem
    {
        public string getName()
        {
            return "nomadhelmet";
        }

        public int getPrice()
        {
            return 9572;
        }

        public override string ToString()
        {
            return "Nomad Helmet";
        }
    }
}