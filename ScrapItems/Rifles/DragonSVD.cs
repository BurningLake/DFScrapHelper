namespace ScrapItems
{
    public class DragonSVD : IItem
    {
        public string getName()
        {
            return "dragonsvd";
        }

        public int getPrice()
        {
            return 24350;
        }

        public override string ToString()
        {
            return "Dragon SVD";
        }
    }
}