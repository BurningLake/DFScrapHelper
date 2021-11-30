namespace ScrapItems
{
    public class Blueprint : IItem
    {
        public string getName()
        {
            return "blueprint";
        }

        public int getPrice()
        {
            return 200000;
        }

        public override string ToString()
        {
            return "Blueprint";
        }
    }
}