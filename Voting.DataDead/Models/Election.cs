using System;
using System.Collections.Generic;

namespace Voting.Data.Models
{
    public partial class Election
    {
        public Election()
        {
            BallotIssues = new HashSet<BallotIssue>();
            CandidateElections = new HashSet<CandidateElection>();
            VoterElections = new HashSet<VoterElection>();
            Votes = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OfficeId { get; set; }
        public int WinnerId { get; set; }
        public DateTimeOffset ElectionDate { get; set; }

        public virtual Office Office { get; set; }
        public virtual Candidate Winner { get; set; }
        public virtual ICollection<BallotIssue> BallotIssues { get; set; }
        public virtual ICollection<CandidateElection> CandidateElections { get; set; }
        public virtual ICollection<VoterElection> VoterElections { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
