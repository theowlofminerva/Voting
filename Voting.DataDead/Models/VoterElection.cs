namespace Voting.Data.Models
{
    public partial class VoterElection
    {
        public int ElectionId { get; set; }
        public int VoterId { get; set; }
        public int Id { get; set; }

        public virtual Election Election { get; set; }
        public virtual Voter Voter { get; set; }
    }
}
