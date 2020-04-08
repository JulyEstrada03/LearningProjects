namespace Abstract
{
    public class ClientNatural : Client
    {
        public override int Id { get; set; }
        public override string Name { get; set; }

        public ClientNatural(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public override string GetName()
        {
            return this.Name;
        }
    }

}