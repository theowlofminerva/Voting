﻿namespace Voting.Data.Models
{
    public partial class BallotIssue
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsYea { get; set; }
        public int? VoteId { get; set; }
        public int ElectionId { get; set; }

        public virtual Election Election { get; set; }
        public virtual Vote Vote { get; set; }
    }
}
