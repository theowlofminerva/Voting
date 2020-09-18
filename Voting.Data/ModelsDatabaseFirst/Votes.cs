using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Votes
    {
        public Votes()
        {
            BallotIssues = new HashSet<BallotIssues>();
        }

        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int VoterId { get; set; }

        public virtual Candidates Candidate { get; set; }
        public virtual Voters Voter { get; set; }
        public virtual ICollection<BallotIssues> BallotIssues { get; set; }
    }
}
