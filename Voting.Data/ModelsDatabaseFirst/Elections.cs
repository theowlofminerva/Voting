using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class Elections
    {
        public Elections()
        {
            BallotIssues = new HashSet<BallotIssues>();
            Candidates = new HashSet<Candidates>();
            Voters = new HashSet<Voters>();
        }

        public int Id { get; set; }
        public DateTimeOffset ElectionDate { get; set; }
        public int? TotalVotes { get; set; }

        public virtual ICollection<BallotIssues> BallotIssues { get; set; }
        public virtual ICollection<Candidates> Candidates { get; set; }
        public virtual ICollection<Voters> Voters { get; set; }
    }
}
