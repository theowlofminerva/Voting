using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Party
    {
        public Party()
        {
            Candidates = new HashSet<Candidate>();
            Voters = new HashSet<Voter>();
        }

        public int Id { get; set; }
        public string PartyName { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Voter> Voters { get; set; }
    }
}
