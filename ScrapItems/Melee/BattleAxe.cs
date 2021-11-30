namespace ScrapItems
{
    public class BattleAxe : IItem
    {
        public string getName()
        {
            return "battleaxe";
        }

        public int getPrice()
        {
            return 20050;
        }

        public override string ToString()
        {
            return "Battle Axe";
        }
    }
}