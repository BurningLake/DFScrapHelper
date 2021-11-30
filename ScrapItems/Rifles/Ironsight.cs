namespace ScrapItems
{
    public class Ironsight : IItem
    {
        public string getName()
        {
            return "ironsight";
        }

        public int getPrice()
        {
            return 57650;
        }

        public override string ToString()
        {
            return "Ironsight 33-F";
        }
    }
}