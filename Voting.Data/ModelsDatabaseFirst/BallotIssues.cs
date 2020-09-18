using System;
using System.Collections.Generic;

namespace Voting.Data.ModelsDatabaseFirst
{
    public partial class BallotIssues
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsYea { get; set; }
        public int? VoteId { get; set; }
        public int ElectionId { get; set; }

        public virtual Elections Election { get; set; }
        public virtual Votes Vote { get; set; }
    }
}
