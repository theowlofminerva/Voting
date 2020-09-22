namespace Voting.Data.Models
{
    public partial class Precinct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Address Addresses { get; set; }
    }
}
