using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Vote
    {
        public Vote()
        {
            BallotIssues = new HashSet<BallotIssue>();
        }

        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int VoterId { get; set; }
        public int ElectionId { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Election Election { get; set; }
        public virtual Voter Voter { get; set; }
        public virtual ICollection<BallotIssue> BallotIssues { get; set; }
    }
}
