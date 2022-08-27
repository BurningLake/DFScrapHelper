namespace ScrapItems
{
    public class NomadMesh : IItem
    {
        public string getName()
        {
            return "nomadmesh";
        }

        public int getPrice()
        {
            return 128250;
        }

        public override string ToString()
        {
            return "Nomad Mesh";
        }
    }
}