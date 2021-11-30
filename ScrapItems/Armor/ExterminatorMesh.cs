namespace ScrapItems
{
    public class ExterminatorMesh : IItem
    {
        public string getName()
        {
            return "exterminatormesh_";
        }

        public int getPrice()
        {
            return 40250;
        }

        public override string ToString()
        {
            return "Exterminator Mesh";
        }
    }
}