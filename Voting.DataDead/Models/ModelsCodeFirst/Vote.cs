using System;
using System.Collections.Generic;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class Vote
    {
        public Vote()
        {
            BallotIssues = new HashSet<Models.BallotIssue>();
        }

        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int VoterId { get; set; }
        public int ElectionId { get; set; }

        public virtual Models.Candidate Candidate { get; set; }

        public virtual Models.Election Election { get; set; }

        public virtual Voter Voter { get; set; }
        public virtual ICollection<Models.BallotIssue> BallotIssues { get; set; }
    }
}
