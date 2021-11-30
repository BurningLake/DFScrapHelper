namespace ScrapItems
{
    public class Implants : IItem
    {
        public string getName()
        {
            return "implant";
        }

        public int getPrice()
        {
            return 62612;
        }

        public override string ToString()
        {
            return "Implant";
        }
    }
}